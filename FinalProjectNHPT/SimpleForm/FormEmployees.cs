using DevExpress.XtraEditors;
using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Util;
using FinalProjectNHPT.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FinalProjectNHPT.SimpleForm
{
    public partial class FormEmployees : Form
    {

        private LinkedList<UserEventData> undoStack = new LinkedList<UserEventData>();
        private LinkedList<UserEventData> redoStack = new LinkedList<UserEventData>();

        private FormChuyenNV formNhanVienMove;
      
        public FormEmployees()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS1);

        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
           
            DS1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.taNV.Connection.ConnectionString = Program.connectionStr;
            this.taNV.Fill(this.DS1.NhanVien);
            // TODO: This line of code loads data into the 'DS1.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.taGuiRut.Connection.ConnectionString = Program.connectionStr;
            this.taGuiRut.Fill(this.DS1.GD_GOIRUT);
            // TODO: This line of code loads data into the 'DS1.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.taChuyenTien.Connection.ConnectionString = Program.connectionStr;
            this.taChuyenTien.Fill(this.DS1.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'DS1.SP_LAYMANVLOGINNAMENV' table. You can move, or remove it, as needed.
            this.taLayTK.Connection.ConnectionString = Program.connectionStr;
            this.taLayTK.Fill(this.DS1.SP_LAYMANVLOGINNAMENV);


            //Lấy tên chi nhánh từ binding source 
            cbBrand.DataSource = Program.bindingSource;
            cbBrand.DisplayMember = "TENCN";
            cbBrand.ValueMember = "TENSERVER";

            //Đăng nhâp vào chi nhánh nào trong form login
            //thì bên đây sẽ hiển thị đúng tên của chi nhánh trong
            //combo box bên form login
            cbBrand.SelectedIndex = SecurityContext.User.BrandIndex;

            //Bật tắt các nút chức năng tùy theo chức vụ = Phân quyền
            switch (SecurityContext.User.Group)
            {
                case DTO.User.GroupENM.NganHang:
                    cbBrand.Enabled = true;
                    btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnMoveNV.Enabled = false;
                    break;

                case DTO.User.GroupENM.ChiNhanh:
                    cbBrand.Enabled = false;
                    btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnMoveNV.Enabled = true;
                    break;

                default:
                    throw new Exception("Detected undefined group");
            }

            btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;
            pnInput.Enabled = false;


        }


        private void UndoUnSaveAction(UserEventData action)
        {
            // Hủy chỉnh sửa hiện tại trên bdsNV bằng cách gọi phương thức CancelEdit.
            bdsNV.CancelEdit();

            if (btnSave.Tag == btnInsert)
            {
                /*bdsNV.Position = action.GridPos;*/
                bdsNV.RemoveAt(bdsNV.Count - 1);
            }

            gcNV.Enabled = true;
            pnInput.Enabled = false;

            btnMoveNV.Enabled = btnInsert.Enabled = btnUpdate.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = false;

            btnSave.Tag = null;


            btnUndo.Enabled = undoStack.Count > 0;
            btnDelete.Enabled = bdsNV.Count > 0;
            btnRedo.Enabled = redoStack.Count > 0;
        }


        // xóa nhân viên xong ấn undo để khôi phục lại nv vừa xóa
        private bool UndoByInsertAction(UserEventData action)
        {
            if (action == null)
                throw new Exception();

            bdsNV.AddNew();

            txbBrandId.Text = Program.MACNHT;

            NhanVien NhanVien = (NhanVien)action.Content;
            txbId.Text = NhanVien.MaNV;
            txbLastName.Text = NhanVien.Ho;
            txbFirstName.Text = NhanVien.Ten;
            txbAddress.Text = NhanVien.DiaChi;
            txbCMND.Text = NhanVien.Cmnd;
            txbPhoneNum.Text = NhanVien.SoDT;
            cbGender.SelectedItem = NhanVien.Phai;
            edTrangThaiXoa.Text = Convert.ToString(0);
            cbGender.DataBindings[0].WriteValue();

            try
            {
                // Lưu thông tin trên binding source
                bdsNV.EndEdit();
                // Đặt thông tin nhân viên mới lên grid control
                bdsNV.ResetCurrentItem();

                //Cập nhật lại database
                taNV.Update(this.DS1.NhanVien);
                taNV.Fill(this.DS1.NhanVien);
                bdsNV.Position = bdsNV.Find(NhanVien.MANV_HEADER, NhanVien.MaNV);
                btnMoveNV.Enabled = SecurityContext.User.Group == DTO.User.GroupENM.ChiNhanh;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không thể khôi phục nhân viên đã xóa có mã số {NhanVien.MaNV}.\nChi tiết: {ex.Message}");
                return false;
            }
            return true;
        }


        // vừa thêm nhân viên vào, sau đó nhấn undo để gỡ hành động thêm
        private int UndoByDeleteAction(UserEventData action)
        {
            NhanVien NhanVien = (NhanVien)action.Content;
            bdsNV.Position = bdsNV.Find(NhanVien.MANV_HEADER, NhanVien.MaNV);

            if (bdsGuiRut.Count > 0 || bdsChuyenTien.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên đã thực hiện giao dịch cho khách hàng");
                return -1;
            }

            if (MessageBox.Show($"Xác nhận xóa nhân viên có mã số {NhanVien.MaNV}?") != DialogResult.OK)
                return 0;

            try
            {
                // Xóa trên máy trước
                bdsNV.RemoveCurrent();
                // Xóa trên server
                taNV.Update(this.DS1.NhanVien);
            }
            catch (Exception ex)
            {
                // Phục hồi nếu xóa không thành công
                MessageBox.Show($"Lỗi không thể xóa nhân viên. Thử thực hiện lại.\nChi tiết: {ex.Message}");
                taNV.Fill(this.DS1.NhanVien);
                bdsNV.Position = bdsNV.Find(NhanVien.MANV_HEADER, NhanVien.MaNV);
                return 0;
            }
            btnMoveNV.Enabled = btnDelete.Enabled = bdsNV.Count != 0;
            return 1;
        }

        //hoàn tác một hành động cập nhật không lưu
        private bool UndoByUpdateAction(UserEventData action)
        {
            NhanVien updatedNhanVien = (NhanVien)action.Content;

            bdsNV.Position = bdsNV.Find(NhanVien.MANV_HEADER, updatedNhanVien.MaNV);

            txbLastName.Text = updatedNhanVien.Ho;
            txbFirstName.Text = updatedNhanVien.Ten;
            txbAddress.Text = updatedNhanVien.DiaChi;
            txbCMND.Text = updatedNhanVien.Cmnd;
            txbPhoneNum.Text = updatedNhanVien.SoDT;
            cbGender.SelectedItem = updatedNhanVien.Phai;

            cbGender.DataBindings[0].WriteValue();

            try
            {
                // Lưu thông tin trên binding source
                bdsNV.EndEdit();
                // Đặt thông tin nhân viên mới lên grid control
                bdsNV.ResetCurrentItem();
                taNV.Update(this.DS1.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không thể hiệu chỉnh nhân viên.Thử thực hiện lại.\nChi tiết: {ex.Message}");
                return false;
            }
            return true;
        }

        private void btnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // lưu vị trí con trỏ trên grid
            /*int gridPos = bdsNV.Position;*/

            bdsNV.AddNew();

            // bật form nhập thông tin nhân viên
            pnInput.Enabled = true;
            txbBrandId.Text = Program.MACNHT;  // lấy mã chi nhánh hiện tại
            txbBrandId.Enabled = false;
            gcNV.Enabled = false;

            cbGender.SelectedIndex = 0;
            edTrangThaiXoa.Text = Convert.ToString(0);
            edTrangThaiXoa.Enabled = false;
            txbId.Enabled = true;
            txbId.Focus();
            btnMoveNV.Enabled = btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnRedo.Enabled = false;

            btnSave.Tag = btnInsert;

            // Push cancel-editing event to undo stack
            undoStack.AddLast(new UserEventData(UserEventData.EventType.CANCEL_EDIT, null, 0));
            btnUndo.Enabled = true;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* int gridPos = bdsNV.Position;*/  // lưu vị trí trên lưới grid

            pnInput.Enabled = true;
            //không cho chỉnh lại mã nv, tên chi nhánh và trạng thái xóa 
            txbBrandId.Enabled = false;
            txbId.Enabled = false;
            edTrangThaiXoa.Enabled = false;

            gcNV.Enabled = false;
            btnMoveNV.Enabled = btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnRedo.Enabled = false;
            btnSave.Tag = btnUpdate;



            NhanVien employee = new NhanVien((DataRowView)bdsNV[bdsNV.Position]);

            undoStack.AddLast(new UserEventData(UserEventData.EventType.CANCEL_EDIT, employee, 0));
            btnUndo.Enabled = true;
            ControlUtil.ResolveStackStorage(undoStack);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xóa nhân viên là chỉ cần xóa sau khi kiểm tra ràng buộc
            // Còn chuyển nhân viên mới dùng tới trạng thái xóa

            // Không thể xóa nhân viên đang là user
            string NhanVienId = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.MANV_HEADER].ToString().Trim();
            
            if (NhanVienId.Equals(SecurityContext.User.UserName))
            {
                MessageBox.Show("Bạn chỉ được thay đổi thông tin của mình, không thể xóa.");
                return;
            }

            //nếu có tk login thì không cho xóa
            string loginName = ((DataRowView)bdsLayTK[bdsLayTK.Position])["LOGINNAME"].ToString().Trim();
            if (!loginName.Equals("NO ACCOUNT"))
            {
                MessageBox.Show("Không thể xóa nhân viên đã có tài khoản login");
                return;
            }


            if (bdsGuiRut.Count > 0 || bdsChuyenTien.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên đã thực hiện giao dịch cho khách hàng");
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa nhân viên có mã số {NhanVienId} ?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhanVien deletedNhanVien = null;
                try
                {
                    deletedNhanVien = new NhanVien((DataRowView)bdsNV[bdsNV.Position]);
                    // Xóa trên máy trước
                    bdsNV.RemoveCurrent();
                    // Xóa trên server
                    taNV.Update(this.DS1.NhanVien);
                }
                catch (Exception ex)
                {
                    // Phục hồi nếu xóa không thành công
                    MessageBox.Show($"Lỗi không thể xóa nhân viên. Thử thực hiện lại.\nChi tiết: {ex.Message}");
                    taNV.Fill(this.DS1.NhanVien);
                    bdsNV.Position = bdsNV.Find(NhanVien.MANV_HEADER, deletedNhanVien.MaNV);
                    return;
                }


                // string idNhanVien = deletedNhanVien.MaNV;

                //  string query = "EXEC usp_DeleteLogin @MaNV";
                // int res = Program.ExecuteNonQuery(query, new object[] { idNhanVien});

                // nếu vẫn còn nhân viên trong bảng thì vẫn cho phép xóa
                btnDelete.Enabled = bdsNV.Count != 0;

                // Thêm vào stack của undo, nghĩa là nếu bấm undo thì sẽ khôi phục lại dữ liệu nhân viên vừa xóa
                undoStack.AddLast(new UserEventData(UserEventData.EventType.INSERT, deletedNhanVien, -1));
                btnUndo.Enabled = true;
                ControlUtil.ResolveStackStorage(undoStack);
                redoStack.Clear();
                btnRedo.Enabled = false;
                btnMoveNV.Enabled = bdsNV.Count != 0;
            }
        
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*NhanVien oldNhanVien = null;*/
            string NhanVienID = "";

            // Kiểm tra các ràng buộc trước khi lưu
            // kiểm tra Họ
            string lastName = txbLastName.Text.Trim();
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Họ tên nhân viên không được để trống");
                txbLastName.Focus();
                return;
            }

            lastName = ControlUtil.RemoveDuplicateSpace(lastName); // xóa space dư thừa (nhiều hơn 1)
            lastName = ControlUtil.CapitalizeFirstLetter(lastName);
            txbLastName.Text = lastName;

            // kiểm tra Tên
            string firstName = txbFirstName.Text.Trim();
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Họ tên nhân viên không được để trống");
                txbFirstName.Focus();
                return;
            }

            if (firstName.Contains(" "))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ");
                txbFirstName.Focus();
                return;
            }

            firstName = ControlUtil.CapitalizeFirstLetter(firstName);
            txbFirstName.Text = firstName;

            string address = txbAddress.Text.Trim();
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống");
                txbAddress.Focus();
                return;
            }

            address = ControlUtil.RemoveDuplicateSpace(address);
            txbAddress.Text = address;

            string phoneNum = txbPhoneNum.Text.Trim();
            if (string.IsNullOrEmpty(phoneNum))
            {
                MessageBox.Show("Số điện thoại nhân viên không được để trống");
                txbPhoneNum.Focus();
                return;
            }

            if (!phoneNum.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại nhân viên không hợp lệ");
                txbPhoneNum.Focus();
                return;
            }

            if (phoneNum.Length != 10)
            {
                MessageBox.Show("Số điện thoại nhân viên không đúng 10 chữ số");
                txbPhoneNum.Focus();
                return;
            }

            txbPhoneNum.Text = phoneNum;

            if (btnSave.Tag == btnUpdate) // tag trạng thái trước đó là hiệu chỉnh
            {
                //Lưu lại thông tin của nhân viên nếu như trước đó ta chọn nút "Hiệu chỉnh"
               /* oldNhanVien = new NhanVien((DataRowView)bdsNV[bdsNV.Position]);*/

                // kiểm tra cmnd trùng
                string cmnd1 = txbCMND.Text.Trim();
                if (string.IsNullOrEmpty(cmnd1))
                {
                    MessageBox.Show("CMND nhân viên không được để trống");
                    txbAddress.Focus();
                    return;
                }

                if (cmnd1.Contains(" "))
                {
                    MessageBox.Show("CMND nhân viên không hợp lệ");
                    txbCMND.Focus();
                    return;
                }

                if (!Regex.Match(cmnd1, @"\b\d{10}\b").Success)
                {
                    MessageBox.Show("CMND nhân viên phải là số và đủ 10 kí tự");
                    txbCMND.Focus();
                    return;
                }

                // kiểm tra cmnd trùng
                // lưu lại cmnd ban đầu của nv
                string oldCMND = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.CMND_HEADER].ToString().Trim();
                Console.WriteLine(oldCMND);
                // kiểm tra cmnd hiện tại (có thể đã thay đổi) với cmnd ban đầu
                if (!cmnd1.Trim().Equals(oldCMND))
                {
                    if (Program.kiemTraCMNDNhanVienTonTai(cmnd1) == 1)
                    {
                        MessageBox.Show("Chứng minh nhân dân đã tồn tại");
                        txbCMND.Focus();
                        return;
                    }
                }

               /* Console.WriteLine("update");
                Console.WriteLine(cmnd1 + " "+ oldCMND);*/
                cmnd1 = cmnd1.ToUpper();
                txbCMND.Text = cmnd1;
            }
            else // ngược lại là nút thêm
            {
                NhanVienID = txbId.Text.Trim();
                if (string.IsNullOrEmpty(NhanVienID))
                {
                    MessageBox.Show("Mã nhân viên không được để trống.");
                    txbId.Focus();
                    return;
                }

                if (NhanVienID.Contains(" "))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ");
                    txbId.Focus();
                    return;
                }

                if (NhanVienID.Length > 10)
                {
                    MessageBox.Show("Mã nhân viên không được vượt quá 10 kí tự");
                    txbId.Focus();
                    return;
                }

                // Kiểm tra mã nhân viên tồn tại trên site chủ
                if (Program.kiemTraNhanVienTonTai(NhanVienID) == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng chọn mã khác");
                    txbId.Focus();
                    return;
                }
                NhanVienID = NhanVienID.ToUpper();
                txbId.Text = NhanVienID;

                //kiểm tra cmnd
                string cmnd = txbCMND.Text.Trim();
                if (string.IsNullOrEmpty(cmnd))
                {
                    MessageBox.Show("CMND nhân viên không được để trống");
                    txbCMND.Focus();
                    return;
                }

                if (cmnd.Contains(" "))
                {
                    MessageBox.Show("CMND nhân viên không hợp lệ");
                    txbCMND.Focus();
                    return;
                }

                if (!Regex.Match(cmnd, @"\b\d{10}\b").Success)
                {
                    MessageBox.Show("CMND nhân viên phải là số và đủ 10 kí tự");
                    txbCMND.Focus();
                    return;
                }

                if (Program.kiemTraCMNDNhanVienTonTai(cmnd) == 1)
                {
                    MessageBox.Show("Chứng minh nhân dân đã tồn tại");
                    txbCMND.Focus();
                    return;
                }

                cmnd = cmnd.ToUpper();
                txbCMND.Text = cmnd;
            }

            cbGender.DataBindings[0].WriteValue();

            try
            {
                // Lưu thông tin trên binding source
                bdsNV.EndEdit();
                // Đặt thông tin nhân viên mới lên grid control
                bdsNV.ResetCurrentItem();
                taNV.Update(this.DS1.NhanVien);


                MessageBox.Show("Ghi thành công");
            }
            catch (Exception ex)
            {
                string msg = btnSave.Tag == btnInsert ? "Lỗi không thể thêm nhân viên mới" : "Lỗi không thể hiệu chỉnh nhân viên";
                MessageBox.Show($"{msg}.\nChi tiết: {ex.Message}");
                return;
            }


            //bat su kien undo

            if (btnSave.Tag == btnInsert)
            {
                taNV.Fill(this.DS1.NhanVien);
                bdsNV.Position = bdsNV.Find(NhanVien.MANV_HEADER, NhanVienID);
            }

            // xoa su kien cancel trong stack
            UserEventData action = undoStack.Last();
            undoStack.RemoveLast();

            if (btnSave.Tag == btnInsert)
            {
                // Nếu INSERT, thêm vào undo stack DELETE action (xóa thông tin vừa thêm)
                action.Type = UserEventData.EventType.DELETE;
                action.Content = new NhanVien((DataRowView)bdsNV[bdsNV.Position]);
                // Không cần lưu action.GridPos vì là DELETE action
            }
            else
            {
                // Nếu UPDATE, thêm vào undo stack UPDATE action, khôi phục lại ban đầu (thông tin gốc)
                action.Type = UserEventData.EventType.UPDATE;
                /*action.Content = oldNhanVien;*/
                // Không cần lưu action.GridPos vì không cần phục hồi gridPos khi UPDATE
            }

            undoStack.AddLast(action);
            ControlUtil.ResolveStackStorage(undoStack);


            btnUndo.Enabled = true;

            // Xóa redo stack
            redoStack.Clear();
            btnRedo.Enabled = false;

            gcNV.Enabled = true;
            pnInput.Enabled = false;
            btnMoveNV.Enabled = btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = false;
            btnMoveNV.Enabled = (cbBrand.Items.Count > 1);
            txbId.Enabled = false;
            btnSave.Tag = null;

            reload();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                UserEventData action = undoStack.Last();
                undoStack.RemoveLast();
                switch (action.Type)
                {
                    //hủy 1 lệnh thêm (chỉnh sửa)
                    case UserEventData.EventType.CANCEL_EDIT:
                        {
                            UndoUnSaveAction(action);
                            break;
                        }
                    //Trước đó xóa, nhấn Undo thì thêm lại
                    case UserEventData.EventType.INSERT:
                        {
                            /*int gridPos = bdsNV.Position;*/
                            if (UndoByInsertAction(action))
                            {
                                action.Type = UserEventData.EventType.DELETE;
                                /*action.GridPos = gridPos;*/
                                redoStack.AddLast(action);
                            }
                            else
                            {
                                undoStack.AddLast(action);
                            }
                            break;
                        }
                    //Trước đó thêm, nhấn Undo thì xóa đi
                    case UserEventData.EventType.DELETE:
                        {
                            int res = UndoByDeleteAction(action);
                            if (res == 1)
                            {
                                action.Type = UserEventData.EventType.INSERT;
                                redoStack.AddLast(action);
                                bdsNV.Position = 0;
                            }
                            else if (res == 0)
                            {
                                undoStack.AddLast(action);
                            }
                            break;
                        }
                    //Trước đó chỉnh và đã nhấn Save, nhấn Undo thì khôi phục lại thông tin trước khi chỉnh
                    case UserEventData.EventType.UPDATE:
                        {
                            NhanVien oldNhanVien = new NhanVien(((DataRowView)bdsNV[bdsNV.Find(NhanVien.MANV_HEADER, ((NhanVien)action.Content).MaNV)]));
                            if (UndoByUpdateAction(action))
                            {
                                action.Type = UserEventData.EventType.UPDATE;
                                action.Content = oldNhanVien;
                                redoStack.AddLast(action);
                            }
                            else
                            {
                                undoStack.AddLast(action);
                            }
                            break;
                        }
                    default:
                        break;
                }
                btnRedo.Enabled = (redoStack.Count > 0);
            }
            btnUndo.Enabled = (undoStack.Count > 0);
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (redoStack.Count > 0)
            {
                UserEventData action = redoStack.Last();
                redoStack.RemoveLast();
                switch (action.Type)
                {
                    // vừa xóa nhân viên, ấn redo để thêm lại nhân viên vừa xóa
                    case UserEventData.EventType.INSERT:
                        {
                            /*int gridPos = bdsNV.Position;*/
                            if (UndoByInsertAction(action))
                            {

                                // vừa redo lại, có thể ấn undo để xóa tiếp
                                action.Type = UserEventData.EventType.DELETE;
                                /*action.GridPos = gridPos;*/
                                undoStack.AddLast(action);
                            }
                            else
                            {
                                redoStack.AddLast(action);
                            }
                            break;
                        }
                    // trước đó xóa nhân viên -> undo thêm lại -> redo xóa đi
                    case UserEventData.EventType.DELETE:
                        {
                            int res = UndoByDeleteAction(action);
                            if (res == 1)
                            {
                                action.Type = UserEventData.EventType.INSERT;
                                undoStack.AddLast(action);
                                bdsNV.Position = 0;
                            }
                            else if (res == 0)
                            {
                                redoStack.AddLast(action);
                            }
                            break;
                        }
                    // (A1)chỉnh sửa và ấn save -> undo khôi phục thông tin trước chỉnh sửa(A0) -> redo khôi phục thông tin sau chỉnh sửa(A1)
                    case UserEventData.EventType.UPDATE:
                        {
                            NhanVien oldNhanVien = new NhanVien(((DataRowView)bdsNV[bdsNV.Find(NhanVien.MANV_HEADER, ((NhanVien)action.Content).MaNV)]));
                            if (UndoByUpdateAction(action))
                            {
                                action.Type = UserEventData.EventType.UPDATE;
                                action.Content = oldNhanVien;
                                undoStack.AddLast(action);
                            }
                            else
                            {
                                redoStack.AddLast(action);
                            }
                            break;
                        }
                    default:
                        break;
                }
                btnUndo.Enabled = (undoStack.Count > 0);
            }
            btnRedo.Enabled = (redoStack.Count > 0);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                taNV.Fill(this.DS1.NhanVien);
                taChuyenTien.Fill(this.DS1.GD_CHUYENTIEN);
                taGuiRut.Fill(this.DS1.GD_GOIRUT);
                taLayTK.Fill(this.DS1.SP_LAYMANVLOGINNAMENV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnMoveNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // lấy vị trí manv ở 1 hàng trên grid
            string NhanVienId = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.MANV_HEADER].ToString().Trim();
            string Ho = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.HO_HEADER].ToString().Trim();
            string Ten = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.TEN_HEADER].ToString().Trim();
            string Cmnd = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.CMND_HEADER].ToString().Trim();
            string DiaChi = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.DIACHI_HEADER].ToString().Trim();
            string Phai = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.PHAI_HEADER].ToString().Trim();
            string SoDT = ((DataRowView)bdsNV[bdsNV.Position])[NhanVien.SODT_HEADER].ToString().Trim();
            int trangThaiXoa = int.Parse(edTrangThaiXoa.Text);

            if (trangThaiXoa == 1)
            {
                MessageBox.Show("Nhân viên đã chuyển chi nhánh, không thể tiếp tục chuyển.");
                return;
            }

            // Không thể chuyển nhân viên đang là user
            if (NhanVienId.Equals(SecurityContext.User.UserName))
            {
                MessageBox.Show("Bạn chỉ được thay đổi thông tin của mình, không thể tự chuyển sang chi nhánh khác.");
                return;
            }

            formNhanVienMove = new FormChuyenNV(NhanVienId, Ho, Ten, Cmnd, DiaChi, Phai, SoDT);
            formNhanVienMove.ShowDialog(this);
            this.taNV.Fill(this.DS1.NhanVien);
            formNhanVienMove.Close();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbBrand.SelectedValue.ToString().Equals("System.Data.RowView"))
                return;

            string serverName = cbBrand.SelectedValue.ToString();
            User user = SecurityContext.User;

            //Trường hợp sang chi nhánh khác
            if (cbBrand.SelectedIndex != user.BrandIndex)
                Program.setServerToRemote(serverName);

            //Trường hợp cùng chi nhánh = Không thay đổi
            else
                Program.setServerSubscriber(serverName, user.LoginName, user.Password);

            //Kiểm tra kết nối
            if (!Program.checkConnection())
            {
                MessageBox.Show("Lỗi khi kết nối sang chi nhánh mới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Sau khi kết nối thì đổ dữ liệu lên bảng
            taNV.Connection.ConnectionString = Program.connectionStr;
            taNV.Fill(this.DS1.NhanVien);
        }

        private void reload()
        {
            taNV.Fill(this.DS1.NhanVien);
            taChuyenTien.Fill(this.DS1.GD_CHUYENTIEN);
            taGuiRut.Fill(this.DS1.GD_GOIRUT);
            taLayTK.Fill(this.DS1.SP_LAYMANVLOGINNAMENV);
        }

        private void gcNV_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void gcNV_DefaultViewChanged(object sender, EventArgs e)
        {

        }

        private void gcNV_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }

        private void gcNV_Load(object sender, EventArgs e)
        {

        }

        private void gcNV_ProcessGridKey(object sender, KeyEventArgs e)
        {

        }

        private void gcNV_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {

        }

        private void gcNV_ViewRemoved(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {

        }
    }
}
