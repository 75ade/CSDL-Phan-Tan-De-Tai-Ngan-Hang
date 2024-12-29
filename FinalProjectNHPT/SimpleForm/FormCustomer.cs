using DevExpress.XtraEditors;
using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectNHPT.DTO;

namespace FinalProjectNHPT.SimpleForm
{
    public partial class FormCustomer : DevExpress.XtraEditors.XtraForm
    {
        private LinkedList<UserEventData> undoStack = new LinkedList<UserEventData>();
        private LinkedList<UserEventData> redoStack = new LinkedList<UserEventData>();
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            //Thêm vào bảng tài khoản để kiểm tra khóa ngoại trước khi xóa
            this.taTK.Connection.ConnectionString = Program.connectionStr;
            this.taTK.Fill(this.dS.TaiKhoan);

            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.taKH.Connection.ConnectionString = Program.connectionStr;
            this.taKH.Fill(this.dS.KhachHang);

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
                    btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
                    break;

                case DTO.User.GroupENM.ChiNhanh:
                    cbBrand.Enabled = false;
                    btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
                    break;

                default:
                    throw new Exception("Detected undefined group");
            }

            btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;
            pnInput.Enabled = false;
/*            txbId.Enabled = false;*/
        }

        //Các module phục vụ cho nút Undo và Redo:
        private void UndoUnSaveAction(UserEventData action)
        {
            bdsKH.CancelEdit();

            if(btnSave.Tag == btnInsert)
            {
/*                bdsKH.Position = action.GridPos;*/
                bdsKH.RemoveAt(bdsKH.Count - 1);
            }

            gcKH.Enabled = true;
            pnInput.Enabled = false;

            btnInsert.Enabled = btnUpdate.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = false;

            btnSave.Tag = null;


            btnUndo.Enabled = undoStack.Count > 0;
            btnDelete.Enabled = bdsKH.Count > 0;
            btnRedo.Enabled = redoStack.Count > 0;
        }

        private bool undoByInsertAction(UserEventData action)
        {
            if (action == null)
                throw new Exception();

            bdsKH.AddNew();
            Console.WriteLine("bds 5: " + bdsKH.Position);

            txbBrandId.Text = Program.MACNHT;

            KhachHang khachHang = (KhachHang)action.Content;
            txbId.Text = khachHang.Cmnd;
            txbLastName.Text = khachHang.Ho;
            txbFirstName.Text = khachHang.Ten;
            txbAddress.Text = khachHang.DiaChi;
            txbPhoneNum.Text = khachHang.SoDT;
            cbGender.SelectedItem = khachHang.Phai;
            deDateAccept.DateTime = khachHang.NgayCap;

            cbGender.DataBindings[0].WriteValue();
            deDateAccept.DataBindings[0].WriteValue();

            try
            {
                //Thêm lại tài khoản login của khách hàng
                string loginName = khachHang.Cmnd;
                string password = khachHang.Cmnd;
                string userName = khachHang.Cmnd;
                string query = "EXEC SP_TAOLOGIN @LGNAME, @PW, @USERNAME, @ROLE";

                int res = Program.ExecuteNonQuery(query, new object[] { loginName, password, userName, "KhachHang" });
                if (res == -1)
                {
                    MessageBox.Show("Tạo tài khoản đăng nhập cho khách hàng thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Lưu thông tin trên bds
                bdsKH.EndEdit();

                //Đặt thông tin nhân viên mới lên grid control
                bdsKH.ResetCurrentItem();

                //Cập nhật lại database
                taKH.Update(this.dS.KhachHang);
                taKH.Fill(this.dS.KhachHang);
                bdsKH.Position = bdsKH.Find(KhachHang.CMND_HEADER, khachHang.Cmnd);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi không thể khôi phục khách hàng với CMND: {khachHang.Cmnd}\nChi tiết lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool undoByDeleteAction(UserEventData action)
        {
            //Lưu lại khách hàng chuẩn bị xóa
            KhachHang khachHang = (KhachHang)action.Content;
            bdsKH.Position = bdsKH.Find(KhachHang.CMND_HEADER, khachHang.Cmnd);


            if(bdsTK.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì khách hàng đã có tài khoản ngân hàng. \nVui lòng thực hiện xóa tài khoản của khách hàng trước", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (MessageBox.Show($"Xác nhận xóa khách hàng với số CMND: {khachHang.Cmnd}", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            try
            {
                //Xóa tài khoản login của khách hàng
                string loginName = khachHang.Cmnd;
                string userName = khachHang.Cmnd;
                string query = "EXEC SP_XOALOGIN @LGNAME, @USERNAME";

                int res = Program.ExecuteNonQuery(query, new object[] { loginName, userName });

                if (res == -1)
                {
                    MessageBox.Show("Xóa tài khoản đăng nhập cho khách hàng thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Xóa trên giao diện trước
                bdsKH.RemoveCurrent();

                //Xóa trên database sau
                taKH.Update(this.dS.KhachHang);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi không thể xóa khách hàng. Vui lòng thực hiện lại \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taKH.Fill(this.dS.KhachHang);
                bdsKH.Position = bdsKH.Find(KhachHang.CMND_HEADER, khachHang.Cmnd);
                return false;
            }

            btnDelete.Enabled = bdsKH.Count != 0;
            return true;
        }

        private bool undoByUpdateAction(UserEventData action)
        {
            KhachHang updatedKhachHang = (KhachHang)action.Content;

            bdsKH.Position = bdsKH.Find(KhachHang.CMND_HEADER, updatedKhachHang.Cmnd);
            
            txbLastName.Text = updatedKhachHang.Ho;
            txbFirstName.Text = updatedKhachHang.Ten;
            txbAddress.Text = updatedKhachHang.DiaChi;
            txbPhoneNum.Text = updatedKhachHang.SoDT;
            cbGender.SelectedItem = updatedKhachHang.Phai;
            deDateAccept.DateTime = updatedKhachHang.NgayCap;

            Console.WriteLine("Họ trước khi chỉnh sửa: " + updatedKhachHang.Ho);
            Console.WriteLine("Tên trước khi chỉnh sửa " + updatedKhachHang.Ten);
            Console.WriteLine("Địa chỉ trước khi chỉnh sửa " + updatedKhachHang.DiaChi);
            Console.WriteLine("SDT trước khi chỉnh sửa " + updatedKhachHang.SoDT);
            Console.WriteLine("Phái trước khi chỉnh sửa " + updatedKhachHang.Phai);
            Console.WriteLine("Ngày cấp CMND trước khi chỉnh sửa " + updatedKhachHang.NgayCap);

            cbGender.DataBindings[0].WriteValue();
            deDateAccept.DataBindings[0].WriteValue();

            try
            {
                //Lưu thông tin trên bds
                bdsKH.EndEdit();

                //Đặt thông tin mới lên bảng grid control
                bdsKH.ResetCurrentItem();

                //Cập nhật dữ liệu trên database
                taKH.Update(this.dS.KhachHang);
                taKH.Fill(this.dS.KhachHang);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi không thể hiệu chỉnh khách hàng. \nVui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //-------------------------------------Các nút chức năng--------------------------------//
        //Nút Insert (thêm)
        private void btnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int gridPos = bdsKH.Position;

            Console.WriteLine("Old grid's position value: " + gridPos);

            bdsKH.AddNew();

            Console.WriteLine("BDS's position value: " + bdsKH.Position);
            Console.WriteLine("New grid's position value: " + gridPos);

            pnInput.Enabled = true;

            gcKH.Enabled = true;

            txbBrandId.Text = Program.MACNHT;
            txbBrandId.Enabled = false;

            cbGender.SelectedIndex = 0;

            txbId.Enabled = true;
            txbId.Focus();

            btnInsert.Enabled = btnDelete.Enabled = btnUpdate.Enabled = btnReload.Enabled = btnExit.Enabled = btnRedo.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnSave.Tag = btnInsert;
            
            undoStack.AddLast(new UserEventData(UserEventData.EventType.CANCEL_EDIT, null, 0));
        }
        
        //Nút Update (Hiệu chỉnh)
        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Giữ vị trí của khách hàng trong lưới
            int gridPos = bdsKH.Position;

            pnInput.Enabled = true;
            txbBrandId.Enabled = false;
            txbId.Enabled = false;

            gcKH.Enabled = false;

            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = btnRedo.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;

            btnSave.Tag = btnUpdate;

            KhachHang customer = new KhachHang((DataRowView)bdsKH[bdsKH.Position]);

            undoStack.AddLast(new UserEventData(UserEventData.EventType.CANCEL_EDIT, customer, 0));
            ControlUtil.ResolveStackStorage(undoStack);

            

            Console.WriteLine("Old lastname: " + customer.Ho);
            Console.WriteLine("Old firstname: " + customer.Ten);
            Console.WriteLine("Old CMND: " + customer.Cmnd);
            Console.WriteLine("Old sex: " + customer.Phai);
            Console.WriteLine("Old address: " + customer.DiaChi);
            Console.WriteLine("Old SĐT: " + customer.SoDT);
        }

        //Nut Delete (Xoa)
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Lưu lại CMND của khách hàng sẽ thực hiện xóa
            string khachHangId = ((DataRowView)bdsKH[bdsKH.Position])[KhachHang.CMND_HEADER].ToString();
/*            string accountLoginKH;*/
            /*            string temp = ((DataRowView)bdsLayLoginNameKH[bdsLayLoginNameKH.Find(KhachHang.CMND_HEADER, khachHangId)])["LOGINNAME"].ToString();*/

/*            int res = bdsLayLoginNameKH.Position;
            if(res < 0)
            {
                this..FilltaLayLoginNameKH(this.dS.SP_LAYLOGINNAMEKH);
                return;
            }
            
            string temp = ((DataRowView)bdsLayLoginNameKH[bdsLayLoginNameKH.Position])["LOGINNAME"].ToString();*/

            //Kiểm tra khách hàng có tài khoản hay chưa
            if (bdsTK.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì khách hàng đã có tài khoản ngân hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

/*            if(temp.Equals("NO ACCOUNT"))
            {

            }
            else
            {
*//*                accountLoginKH = ((DataRowView)bdsLayLoginNameKH[bdsLayLoginNameKH.Position])["LOGINNAME"].ToString();
                //Kiểm tra khách hàng có tài khoản đăng nhập hay chưa
                if (!accountLoginKH.Equals("NO ACCOUNT"))
                {
                    MessageBox.Show("Vui lòng xóa tài khoản đăng nhập của khách hàng trước khi xóa khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*//*

                MessageBox.Show("Vui lòng xóa tài khoản đăng nhập của khách hàng trước khi xóa khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            

            if (MessageBox.Show($"Xác nhận xóa vị khách hàng với số CMND: {khachHangId} ?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // lưu lại khách hàng bị xóa để undo
                KhachHang deletedKhachHang;
                Console.WriteLine("Bdskh position before: " + bdsKH.Position);

                try
                {
                    //Thực hiện xóa tài khoản login của khách hàng
                    string loginName = khachHangId; //cmnd
                    string userName = khachHangId;
                    string query = "EXEC SP_XOALOGIN @LGNAME, @USERNAME";

                    int res = Program.ExecuteNonQuery(query, new object[] { loginName, userName });
                    if (res == -1)
                    {
                        MessageBox.Show("Xóa tài khoản đăng nhập cho khách hàng thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Lưu lại thông tin của khách hàng sẽ thực hiện xóa
                    deletedKhachHang = new KhachHang((DataRowView)bdsKH[bdsKH.Position]);

                    //Xóa trên giao diện trước
                    bdsKH.RemoveCurrent();

                    //Xóa trên database sau
                    taKH.Update(this.dS.KhachHang);
                }
                catch (Exception ex)
                {
                    //Khôi phục lại dữ liệu nếu như xóa không thành công
                    MessageBox.Show("Lỗi không thể xóa khách hàng. Vui lòng thực hiện lại \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    taKH.Fill(this.dS.KhachHang);
                    bdsKH.Position = bdsKH.Find(KhachHang.CMND_HEADER, khachHangId);
                    return;
                }

                //Enable nút Delete (Xóa) nếu có khách hàng trong bảng
                btnDelete.Enabled = bdsKH.Count != 0;

                //Thêm vào stack của undo
                undoStack.AddLast(new UserEventData(UserEventData.EventType.INSERT, deletedKhachHang, 0));
                btnUndo.Enabled = true;
                ControlUtil.ResolveStackStorage(undoStack);

                redoStack.Clear();
                btnRedo.Enabled = false;

            }
        }

        //Nút Exit (Thoát)
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        //Nút Save (Lưu/Ghi)
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHang oldKhachHang = null;
            string khachHangID = "";

            if (btnSave.Tag == btnUpdate)
            {
                //Lưu lại thông tin của khách hàng nếu như trước đó ta chọn nút "Hiệu chỉnh"
                /*string oldCMND = ((DataRowView)bdsKH[bdsKH.Position])[KhachHang.CMND_HEADER].ToString().Trim();
                string oldHO = ((DataRowView)bdsKH[bdsKH.Position])[KhachHang.HO_HEADER].ToString().Trim();
                string oldTEN = ((DataRowView)bdsKH[bdsKH.Position])[KhachHang.TEN_HEADER].ToString().Trim();
                string oldDIACHI = ((DataRowView)bdsKH[bdsKH.Position])[KhachHang.DIACHI_HEADER].ToString().Trim();
                string oldPHAI = ((DataRowView)bdsKH[bdsKH.Position])[KhachHang.PHAI_HEADER].ToString().Trim();
                DateTime oldNGAYCAP = (DateTime)((DataRowView)bdsKH[bdsKH.Position])[KhachHang.NGAYCAPKHACH_HEADER];
                string oldSODT = ((DataRowView)bdsKH[bdsKH.Position])[KhachHang.SODT_HEADER].ToString().Trim();

                oldKhachHang = new KhachHang(oldCMND, oldHO, oldTEN, oldDIACHI, oldPHAI, oldNGAYCAP, oldSODT);

                Console.WriteLine(oldCMND + " " + oldHO + " " + oldTEN + " " + oldDIACHI + " " + oldPHAI + " " + oldNGAYCAP + " " + oldSODT);*/
              
/*
                oldKhachHang = new KhachHang((DataRowView)bdsKH[bdsKH.Position]);

                Console.WriteLine("BDSKH's position: " + bdsKH.Position);

                Console.WriteLine("Old 1 Ho: " + oldKhachHang.Ho);
                Console.WriteLine("Old 1 Ten: " + oldKhachHang.Ten);
                Console.WriteLine("Old 1 Dia Chi: " + oldKhachHang.DiaChi);*/
            }
            else
            {
                //Ta chỉ thực hiện các bước kiểm tra CMND (PK)
                //nếu đây là nút "Thêm" (Create)
                khachHangID = txbId.Text.Trim();

                //Kiểm tra CMND có rỗng hay không
                if (string.IsNullOrEmpty(khachHangID))
                {
                    MessageBox.Show("Mã khách hàng (CMND) không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbId.Focus();
                    return;
                }

                //Kiểm tra CMND có hợp lệ hay không
                if (khachHangID.Contains(" ") || !Regex.Match(khachHangID, @"\b\d{10}\b").Success)
                {
                    MessageBox.Show("Mã khách hàng (CMND) không hợp lệ hoặc chưa đủ 10 chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbId.Focus();
                    return;
                }

                //Kiểm tra CMND đã có trong chi nhánh khác chưa = Kiểm tra khách hàng có thuộc chi nhánh nào không
                if (Program.kiemTraKhachHangTonTai(khachHangID) > 0)
                {
                    MessageBox.Show("Không thể thêm khách hàng vì người này đã có trong chi nhánh khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbId.Focus();
                    return;
                }

                khachHangID = khachHangID.ToUpper();
                txbId.Text = khachHangID.Trim();
            }

            //Thực hiện kiểm tra và chuẩn hóa các thông tin còn lại của khách hàng

            //Kiểm tra "Họ"
            string lastName = txbLastName.Text.Trim();
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Họ của khách hàng không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbLastName.Focus();
                return;
            }

            lastName = ControlUtil.RemoveDuplicateSpace(lastName);
            lastName = ControlUtil.CapitalizeFirstLetter(lastName);
            txbLastName.Text = lastName;

            //Kiểm tra "Tên"
            string firstName = txbFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Tên của khách hàng không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbFirstName.Focus();
                return;
            }

            if (firstName.Contains(" "))
            {
                MessageBox.Show("Tên của khách hàng không được chứa khoảng trắng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbFirstName.Focus();
                return;
            }

            firstName = ControlUtil.CapitalizeFirstLetter(firstName);
            txbFirstName.Text = firstName.Trim();

            //Kiểm tra địa chỉ
            string address = txbAddress.Text;
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Địa chỉ của khách hàng không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbAddress.Focus();
                return;
            }

            address = ControlUtil.RemoveDuplicateSpace(address);
            txbAddress.Text = address.Trim();

            //Kiểm tra số điện thoại
            string phoneNum = txbPhoneNum.Text;
            if (string.IsNullOrEmpty(phoneNum))
            {
                MessageBox.Show("Số điện thoại của khách hàng không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPhoneNum.Focus();
                return;
            }

            //Kiểm tra SDT có chứa ký tự là chữ hay không
            if (!phoneNum.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại của khách hàng không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPhoneNum.Focus();
                return;
            }

            //Kiểm tra SDT có đủ 10 số hay không
            if (phoneNum.Length != 10)
            {
                MessageBox.Show("Số điện thoại của khách hàng không đủ 10 chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPhoneNum.Focus();
                return;
            }

            txbPhoneNum.Text = phoneNum.Trim();

            //Kiểm tra ngày cấp CMND của khách hàng:
            if (deDateAccept.DateTime > DateTime.Now)
            {
                MessageBox.Show("Ngày cấp CMND không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deDateAccept.Focus();
                return;
            }

            else
            {
                cbGender.DataBindings[0].WriteValue();
                deDateAccept.DataBindings[0].WriteValue();
            }


            try
            {
                //Tạo tài khoản cho khách hàng trong trường hợp là thêm vào
                if (btnSave.Tag == btnInsert)
                {

                    /*FormEnterCustomerPassword form = new FormEnterCustomerPassword(khachHangID);
                    form.Show();*/

                    string query = "EXEC SP_TAOLOGIN @LGNAME, @PW, @USERNAME, @ROLE";
                    int res = Program.ExecuteNonQuery(query, new object[] { khachHangID, khachHangID, khachHangID, "KhachHang" });

                    if (res == -1)
                    {
                        MessageBox.Show("Tạo tài khoản đăng nhập cho khách hàng thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //Không tạo tài khoản cho khách hàng trong trường hợp là edit
                else
                {

                }

                //Cập nhật trên giao diện
                bdsKH.EndEdit();
                bdsKH.ResetCurrentItem();

                //Cập nhật xuống database
                taKH.Update(this.dS.KhachHang);
                MessageBox.Show("Ghi thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string msg = btnSave.Tag == btnInsert ? "Lỗi không thể thêm khách hàng mới" : "Lỗi không thể hiệu chỉnh khách hàng";
                MessageBox.Show($"{msg}.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Bắt nút "Undo"
            if (btnSave.Tag == btnInsert)
            {
                taKH.Fill(this.dS.KhachHang);
                bdsKH.Position = bdsKH.Find(KhachHang.CMND_HEADER, khachHangID);
            }

            //Xóa trạng thái Cancel - Edit trong stack
            UserEventData action = undoStack.Last();
            undoStack.RemoveLast();
            
            //Nếu là thêm vào thì sẽ thêm vào stack Undo là Delete
            //Để khi nhấn nút Undo sau khi lưu thêm vào thì sẽ xóa đi người vừa thêm
            if (btnSave.Tag == btnInsert)
            {
                action.Type = UserEventData.EventType.DELETE;
                KhachHang newKhachHang = new KhachHang((DataRowView)bdsKH[bdsKH.Position]);

                //Tạo tài khoản đăng nhập cho khách hàng:
/*                FormCustomerCreateLogin formCCL = new FormCustomerCreateLogin(khachHangID);
                formCCL.Show();
                newKhachHang.Password = formCCL.getPassword();*/

                action.Content = newKhachHang;
                Console.WriteLine("Bds 1: " + action.GridPos);
            }

            //Nếu là Edit (Chỉnh sửa) thì thêm vào stack Undo là Update
            //Để khi nhấn Undo sau khi Edit thông tin của một người sẽ trả về thông tin ban đầu 
            else
            {
                action.Type = UserEventData.EventType.UPDATE;
                /*action.Content = oldKhachHang;*/

/*                Console.WriteLine("Old Ho: " + oldKhachHang.Ho);
                Console.WriteLine("Old Ten: " + oldKhachHang.Ten);
                Console.WriteLine("Old Dia Chi: " + oldKhachHang.DiaChi);*/
            }

            undoStack.AddLast(action);
            ControlUtil.ResolveStackStorage(undoStack);

            btnUndo.Enabled = true;
            redoStack.Clear();
            btnRedo.Enabled = false;


            gcKH.Enabled = true;
            pnInput.Enabled = false;
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = false;
            txbId.Enabled = false;
            btnSave.Tag = null;
        }

        //Nút Undo
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(undoStack.Count > 0)
            {
                UserEventData action = undoStack.Last();
                undoStack.RemoveLast();
                Console.WriteLine("bds 2: " + action.GridPos);

                switch (action.Type)
                {
                    case UserEventData.EventType.CANCEL_EDIT:
                        UndoUnSaveAction(action);
                        break;
                    
                    //Trước đó xóa, nhấn Undo thì thêm lại
                    case UserEventData.EventType.INSERT:
                       /* int gridPos = bdsKH.Position;*/
                        Console.WriteLine("BdsKh position after: " + bdsKH.Position);
                        if (undoByInsertAction(action))
                        {
                            action.Type = UserEventData.EventType.DELETE;
                           /* action.GridPos = gridPos;*/
                            redoStack.AddLast(action);
                        }
                        else
                        {
                            undoStack.AddLast(action);
                        }
                        break;

                    //Trước đó thêm, nhấn Undo thì xóa đi
                    case UserEventData.EventType.DELETE:
                        if (undoByDeleteAction(action))
                        {
                            action.Type = UserEventData.EventType.INSERT;
                            redoStack.AddLast(action);
                            bdsKH.Position = 0;
                            Console.WriteLine("bds 3: " + bdsKH.Position);
                        }
                        else
                            undoStack.AddLast(action);
                        break;

                    //Trước đó chỉnh và đã nhấn Save, nhấn Undo thì khôi phục lại 
                    //thông tin trước khi chỉnh
                    case UserEventData.EventType.UPDATE:
                        // tt kh da chinh sua 
                        KhachHang oldKhachHang = new KhachHang((DataRowView)bdsKH[bdsKH.Find(KhachHang.CMND_HEADER, ((KhachHang)action.Content).Cmnd)]);
                        if (undoByUpdateAction(action))
                        {
                            action.Type = UserEventData.EventType.UPDATE;
                            action.Content = oldKhachHang;
                            redoStack.AddLast(action);
                        }   
                        else
                            undoStack.AddLast(action);
                        break;

                    default:
                        break;
                }
                btnRedo.Enabled = (redoStack.Count > 0);
            }
            btnUndo.Enabled = (undoStack.Count > 0);

            this.taKH.Fill(this.dS.KhachHang);
            this.taTK.Fill(this.dS.TaiKhoan);
        }

        //Nút Redo
        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(redoStack.Count > 0)
            {
                UserEventData action = redoStack.Last();
                redoStack.RemoveLast();
                switch (action.Type)
                {
                    case UserEventData.EventType.INSERT:
                       /* int gridPos = bdsKH.Position;*/
                        Console.WriteLine("bds 4: " + bdsKH.Position);
                        if (undoByInsertAction(action))
                        {
                            action.Type = UserEventData.EventType.DELETE;
                            /*action.GridPos = gridPos;*/
                            Console.WriteLine("grid pos 6 " + action.GridPos);
                            undoStack.AddLast(action);
                        }
                        else
                            redoStack.AddLast(action);
                        break;

                    case UserEventData.EventType.DELETE:
                        if (undoByDeleteAction(action))
                        {
                            action.Type = UserEventData.EventType.INSERT;
                            undoStack.AddLast(action);
                            bdsKH.Position = 0;
                        }
                        else
                            redoStack.AddLast(action);
                        break;

                    case UserEventData.EventType.UPDATE:
                        KhachHang oldKhachHang = new KhachHang((DataRowView)bdsKH[bdsKH.Find(KhachHang.CMND_HEADER, ((KhachHang)action.Content).Cmnd)]);
                        if (undoByUpdateAction(action))
                        {
                            action.Type = UserEventData.EventType.UPDATE;
                            action.Content = oldKhachHang;
                            undoStack.AddLast(action);
                        }
                        else
                        {
                            redoStack.AddLast(action);
                        }
                        break;

                    default:
                        break;
                }
                btnUndo.Enabled = undoStack.Count > 0;
            }
            btnRedo.Enabled = redoStack.Count > 0;

            this.taKH.Fill(this.dS.KhachHang);
            this.taTK.Fill(this.dS.TaiKhoan);
        }


        //Nút Reload (Xem lại)
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taKH.Fill(this.dS.KhachHang);
                this.taTK.Fill(this.dS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        

        //Combox box chuyển sang chi nhánh khác
        private void cbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbBrand.SelectedValue.ToString().Equals("System.Data.RowView"))
                return;

            string serverName = cbBrand.SelectedValue.ToString();
            User user = SecurityContext.User;

            //Setup chuỗi kết nối connectionStr đến site phân mảnh theo combo box
            //Trường hợp sang chi nhánh khác
            if (cbBrand.SelectedIndex != user.BrandIndex)
                Program.setServerToRemote(serverName);

            //Trường hợp cùng chi nhánh = Không thay đổi
            else
                Program.setServerSubscriber(serverName, user.LoginName, user.Password);
            //-------------------------------------------------------------------------//

            //Thực hiện kết nối đồng thời kiểm tra kết nối
            if (!Program.checkConnection())
            {
                MessageBox.Show("Lỗi khi kết nối sang chi nhánh mới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Sau khi kết nối thì đổ dữ liệu lên bảng
            taKH.Connection.ConnectionString = Program.connectionStr;
            taKH.Fill(this.dS.KhachHang);
        }
    }
}