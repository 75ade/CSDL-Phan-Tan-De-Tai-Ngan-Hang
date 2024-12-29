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

namespace FinalProjectNHPT.SimpleForm
{
    public partial class FormAccount : Form
    {
        private string CMND;
        private string maCN;

        private LinkedList<UserEventData> undoStack = new LinkedList<UserEventData>();
        
        //Constructors
        public FormAccount()
        {
            
        }

        public FormAccount(string CMND, string maCN)
        {
            InitializeComponent();
            this.CMND = CMND;
            this.maCN = maCN;
        }

        //Load
        private void FormAccount_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            //Bảng này sẽ chứa toàn bộ tài khoản ngân hàng của 1 chi nhánh
            this.taTKGoc.Connection.ConnectionString = Program.connectionStr;
            this.taTKGoc.Fill(this.dS.TaiKhoan);

            //Bảng này sẽ chỉ chứa tài khoản ngân hàng theo CMND và mã chi nhánh
            this.taTK.Connection.ConnectionString = Program.connectionStr;
            this.taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCMND, CMND.Trim(), maCN.Trim());

            //2 Bảng gửi rút và chuyển tiền được thêm vào để kiểm tra khóa ngoại trước khi xóa
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.taGoiRut.Connection.ConnectionString = Program.connectionStr;
            this.taGoiRut.Fill(this.dS.GD_GOIRUT);

            // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.taChuyenTien.Connection.ConnectionString = Program.connectionStr;
            this.taChuyenTien.Fill(this.dS.GD_CHUYENTIEN);


            switch (SecurityContext.User.Group)
            {
                case DTO.User.GroupENM.NganHang:
                    btnInsert.Enabled = btnChange.Enabled = btnDelete.Enabled = false;
                    break;

                case DTO.User.GroupENM.ChiNhanh:
                    btnInsert.Enabled = btnChange.Enabled = btnDelete.Enabled = true;
                    break;
            }

            //Nếu khách hàng không có tài khoản ngân hàng
            if(bdsTK.Count <= 0)
            {
                btnChange.Enabled = btnDelete.Enabled = false;
            }

            
            pnInput.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = false;
            btnReload.Enabled = btnExit.Enabled = true;

        }

        //Các module phục vụ cho nút undo
        private void UndoSaveAction(UserEventData action)
        {
            bdsTK.CancelEdit();
            bdsTKGoc.CancelEdit();

            if (btnSave.Tag == btnInsert)
            {
                if (bdsTK.Count > 0)
                {
                    bdsTK.Position = action.GridPos;
                    bdsTK.RemoveAt(bdsTK.Count - 1);
                }
                else { }
            }

            gcTK.Enabled = true;
            pnInput.Enabled = false;

            btnInsert.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnChange.Enabled = bdsTK.Count > 0;
            btnSave.Enabled = false;
            btnUndo.Enabled = undoStack.Count > 0;

            btnSave.Tag = null;
            btnDelete.Enabled = bdsTK.Count > 0;
        }

        private bool UndoByDeleteAction(UserEventData action)
        {
            //Lưu lại tài khoản chuẩn bị xóa
            TaiKhoanNganHang taiKhoan = (TaiKhoanNganHang)action.Content;
            bdsTK.Position = bdsTK.Find(TaiKhoanNganHang.SOTK_HEADER, taiKhoan.SoTK);
            bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, taiKhoan.SoTK);

            if (MessageBox.Show($"Xác nhận xóa tài khoản với số tài khoản: {taiKhoan.SoTK}", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            try
            {
                //Xóa trên giao diện = Xóa trên grid control
                bdsTK.RemoveCurrent();
                bdsTKGoc.RemoveCurrent();

                //Cập nhật dữ liệu lên database
                taTK.Update(this.dS.SP_LAYTAIKHOANTHEOCMND);
                taTKGoc.Update(this.dS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể xóa tài khoản ngân hàng. Vui lòng thực hiện lại \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCMND, CMND, maCN);
                taTKGoc.Fill(this.dS.TaiKhoan);

                bdsTK.Position = bdsTK.Find(TaiKhoanNganHang.SOTK_HEADER, taiKhoan.SoDu);
                bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, taiKhoan.SoDu);
                return false;
            }

            btnDelete.Enabled = bdsTK.Count != 0;
            return true;
        }

        private bool UndoByUpdateAction(UserEventData action)
        {
            TaiKhoanNganHang updatedTaiKhoan = (TaiKhoanNganHang)action.Content;

            bdsTK.Position = bdsTK.Find(TaiKhoanNganHang.SOTK_HEADER, updatedTaiKhoan.SoTK);
            bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, updatedTaiKhoan.SoTK);

            txbSoTK.Text = updatedTaiKhoan.SoTK;
            txbCMND.Text = updatedTaiKhoan.Cmnd;
            txbSoDu.Value = (decimal)updatedTaiKhoan.SoDu;
            txbMaCN.Text = updatedTaiKhoan.MaCN;
            edNgayMoTK.DateTime = updatedTaiKhoan.NgayMoTK;

            txbSoTKGoc.Text = txbSoTK.Text;
            txbCMNDGoc.Text = txbCMND.Text;
            txbSoDuGoc.Value = txbSoDu.Value;
            txbMaCNGoc.Text = txbMaCN.Text;
            edNgayMoTKGoc.Text = edNgayMoTK.Text;



            try
            {
                //Lưu thông tin trên giao diện
                bdsTK.EndEdit();
                bdsTKGoc.EndEdit();

                //Đặt thông tin lên giao diện
                bdsTK.ResetCurrentItem();
                bdsTKGoc.ResetCurrentItem();

                //Cập nhật dữ liệu lên database
                taTK.Update(this.dS.SP_LAYTAIKHOANTHEOCMND);
                taTKGoc.Update(this.dS.TaiKhoan);

                //Load lại dữ liệu
                taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCMND, CMND, maCN);
                taTKGoc.Fill(this.dS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể hiệu chỉnh tài khoản. \nVui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool UndoByInsertAction(UserEventData action)
        {
            if (action == null)
                throw new Exception();

            bdsTK.AddNew();
            bdsTKGoc.AddNew();

            TaiKhoanNganHang taiKhoan = (TaiKhoanNganHang)action.Content;

            txbSoTK.Text = taiKhoan.SoTK;
            txbCMND.Text = taiKhoan.Cmnd;
            txbSoDu.Value = (decimal)taiKhoan.SoDu;
            txbMaCN.Text = taiKhoan.MaCN;
            edNgayMoTK.DateTime = taiKhoan.NgayMoTK;

            txbSoTKGoc.Text = txbSoTK.Text;
            txbCMNDGoc.Text = txbCMND.Text;
            txbSoDuGoc.Value = txbSoDu.Value;
            txbMaCNGoc.Text = txbMaCN.Text;
            edNgayMoTKGoc.Text = edNgayMoTK.Text;

            try
            {
                //Thêm lại tài khoản trên giao diện
                bdsTK.EndEdit();
                bdsTKGoc.EndEdit();

                //Đặt thông tin lên giao diện
                bdsTK.ResetCurrentItem();
                bdsTKGoc.ResetCurrentItem();

                //Cập nhật dữ liệu lên database
                taTK.Update(this.dS.SP_LAYTAIKHOANTHEOCMND);
                taTKGoc.Update(this.dS.TaiKhoan);
                bdsTK.Position = bdsTK.Find(TaiKhoanNganHang.SOTK_HEADER, taiKhoan.SoTK);
                bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, taiKhoan.SoTK);

                //Tải dữ liệu lên giao diện
                taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCMND, CMND, maCN);
                taTKGoc.Fill(this.dS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không thể khôi phục tài khoản ngân hàng với số tài khoản: {taiKhoan.SoTK}\nChi tiết lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //--------------------------------------------Các nút chức năng trong form------------------------------------------------//
        //Nút "Exit"
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        //Nút "Reload"
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        //Nút "Thêm"
        private void btnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int gridPos = bdsTK.Position;

            Console.WriteLine("This is the index of your grid: " + gridPos);
            bdsTKGoc.AddNew();
            bdsTK.AddNew();
            
            pnInput.Enabled = true;
            gcTK.Enabled = true;

            txbMaCN.Text = maCN.Trim();
            txbMaCN.Enabled = false;

            txbCMND.Text = CMND;
            txbCMND.Enabled = false;

            txbSoTK.Enabled = true;
            txbSoTK.Focus();

            edNgayMoTK.Enabled = false;
            edNgayMoTK.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txbSoDu.Text = "100000";

            btnInsert.Enabled = btnChange.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnSave.Tag = btnInsert;

            undoStack.AddLast(new UserEventData(UserEventData.EventType.CANCEL_EDIT, null, gridPos));
        }

        //Nút "Undo"
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                UserEventData action = undoStack.Last();
                undoStack.RemoveLast();

                switch (action.Type)
                {
                    //Hủy Chỉnh sửa hoặc thêm
                    case UserEventData.EventType.CANCEL_EDIT:
                        UndoSaveAction(action);
                        break;

                    //Trước đó xóa, nhấn nút "Undo" -> Thêm lại
                    case UserEventData.EventType.INSERT:
                        if (UndoByInsertAction(action)) { }
                        else
                        {
                            undoStack.AddLast(action);
                        }
                        break;

                    //Trước đó thêm, nhấn nút "Undo" -> Xóa
                    case UserEventData.EventType.DELETE:
                        if (UndoByDeleteAction(action))
                        {

                        }
                        else
                        {
                            undoStack.AddLast(action);
                        }
                        break;

                    //Trước đó hiệu chỉnh, nhấn nút "Undo" -> Khôi phục lại dữ liệu cũ
                    case UserEventData.EventType.UPDATE:
                        if (UndoByUpdateAction(action))
                        {

                        }
                        else
                        {
                            undoStack.AddLast(action);
                        }
                        break;

                    default:
                        break;
                }

            }
            btnDelete.Enabled = bdsTK.Count != 0;
            btnUndo.Enabled = undoStack.Count > 0;
            reload();
        }

        //Nút "Hiệu chỉnh"
        private void btnChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int gridPos = bdsTK.Position;
            pnInput.Enabled = true;
            gcTK.Enabled = false;


            txbSoTK.Enabled = false;
            txbCMND.Enabled = false;
            txbSoDu.Enabled = true;
            edNgayMoTK.Enabled = false;
            txbMaCN.Enabled = false;

            btnInsert.Enabled = btnChange.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = true;
            btnSave.Tag = btnChange;

            undoStack.AddLast(new UserEventData(UserEventData.EventType.CANCEL_EDIT, null, gridPos));
            btnUndo.Enabled = true;
            ControlUtil.ResolveStackStorage(undoStack);
        }

        //Nút "Lưu"
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaiKhoanNganHang oldTaiKhoan = null;
            string soTK = "";

            if(btnSave.Tag == btnChange)
            {   //Lưu lại tài khoản cũ
                oldTaiKhoan = new TaiKhoanNganHang((DataRowView)bdsTK[bdsTK.Position]);
                bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, txbSoTK.Text.Trim());
            }
            else
            {
                //Kiểm tra số tài khoản đối với nút "Thêm"
                soTK = txbSoTK.Text.Trim();


                if (string.IsNullOrEmpty(soTK))
                {
                    MessageBox.Show("Số tài khoản không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoTK.Focus();
                    return;
                }

                if(soTK.Contains(" ") || !Regex.Match(soTK, @"\b\d{9}\b").Success || soTK.Length > 9)
                {
                    MessageBox.Show("Số tài khoản không hợp lệ hoặc chưa đủ hoặc vượt quá 9 chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoTK.Focus();
                    return;
                }

                if(Program.ExecSqlCheck("SP_KIEMTRASOTK", soTK) == 1)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoTK.Text = "";
                    txbSoTK.Focus();
                    return;
                }

                txbSoTK.Text = soTK;
            }

            
            if (string.IsNullOrEmpty(txbSoDu.Text))
            {
                MessageBox.Show("Số dư không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoDu.Text = "";
                txbSoDu.Focus();
                return;
            }          

            if(txbSoDu.Value < 0)
            {
                MessageBox.Show("Số dư không được là số âm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoDu.Text = "";
                txbSoDu.Focus();
                return;
            }


            /*            txbSoTKGoc.Text = txbSoTK.Text;
                        txbCMNDGoc.Text = txbCMND.Text;
                        txbSoDuGoc.Value = txbSoDu.Value;
                        txbMaCNGoc.Text = txbMaCN.Text;
                        edNgayMoTKGoc.Text = edNgayMoTK.Text;

                        Console.WriteLine(txbSoTKGoc.Text);
                        Console.WriteLine(txbCMNDGoc.Text);
                        Console.WriteLine(txbSoDuGoc.Value);
                        Console.WriteLine(txbMaCNGoc.Text);
                        Console.WriteLine(edNgayMoTKGoc.Text);*/

/*            Console.WriteLine("This belongs to the bdsTK: ");
            Console.WriteLine(txbSoTK.Text);
            Console.WriteLine(txbCMND.Text);
            Console.WriteLine(txbSoDu.Value);
            Console.WriteLine(txbMaCN.Text);
            Console.WriteLine(edNgayMoTK.Text);*/

            try
            {
                txbSoTKGoc.Text = txbSoTK.Text;
                txbCMNDGoc.Text = txbCMND.Text;
                txbSoDuGoc.Value = txbSoDu.Value;
                txbMaCNGoc.Text = txbMaCN.Text;
                edNgayMoTKGoc.DateTime = DateTime.Now;

                /*                edNgayMoTK.DataBindings[0].WriteValue();
                                edNgayMoTKGoc.DataBindings[0].WriteValue();*/

                /*                Console.WriteLine(txbSoTKGoc.Text);
                                Console.WriteLine(txbCMNDGoc.Text);
                                Console.WriteLine(txbSoDuGoc.Value);
                                Console.WriteLine(txbMaCNGoc.Text);
                                Console.WriteLine(edNgayMoTKGoc.Text);*/


                bdsTKGoc.EndEdit();
/*                Console.WriteLine("Bug here 1");*/
                bdsTKGoc.ResetCurrentItem();
                /*                Console.WriteLine("Bug here 2");*/
                taTKGoc.Update(this.dS.TaiKhoan);
                /*                Console.WriteLine("Bug here 3");*/

                bdsTK.EndEdit();
                bdsTK.ResetCurrentItem();
                taTK.Update(this.dS.SP_LAYTAIKHOANTHEOCMND);

                MessageBox.Show("Ghi tài khoản ngân hàng thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                string msg = btnSave.Tag == btnInsert ? "Lỗi không thể thêm tài khoản ngân hàng mới" : "Lỗi không thể hiệu chỉnh tài khoản ngân hàng";
                MessageBox.Show($"{msg}.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Bắt nút undo
            if (btnSave.Tag == btnInsert)
            {
                taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCMND, CMND, maCN);
                taTKGoc.Fill(this.dS.TaiKhoan);

                bdsTK.Position = bdsTK.Find(TaiKhoanNganHang.SOTK_HEADER, soTK);
                bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, soTK);
            }

            //Xóa trạng thái Cancel - Edit trong stack
            UserEventData action = undoStack.Last();
            undoStack.RemoveLast();

            if (btnSave.Tag == btnInsert)
            {
                action.Type = UserEventData.EventType.DELETE;
                TaiKhoanNganHang newTaiKhoan = new TaiKhoanNganHang((DataRowView)bdsTK[bdsTK.Position]);
                action.Content = newTaiKhoan;
            }
            else
            {
                action.Type = UserEventData.EventType.UPDATE;
                //Lưu lại tài khoản cũ để nếu như nhấn nút "Undo" thì
                //thì trả về dữ liệu của tài khoản cũ
                action.Content = oldTaiKhoan;
            }

            undoStack.AddLast(action);
            ControlUtil.ResolveStackStorage(undoStack);

            btnUndo.Enabled = true;

            gcTK.Enabled = true;
            pnInput.Enabled = false;
            btnInsert.Enabled = btnChange.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = false;
            btnSave.Tag = null;

            reload();
        }

        //Nút "Xóa"
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            string soTK = ((DataRowView)bdsTK[bdsTK.Position])[TaiKhoanNganHang.SOTK_HEADER].ToString();

            bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, soTK);

            if (bdsChuyenTien.Count > 0)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã có giao dịch chuyển tiền hoặc nhận tiền", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bdsGoiRut.Count > 0)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã có giao dịch gửi hoặc rút tiền", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa tài khoản với số tài khoản: {soTK}", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Lưu lại tài khoản ngân hàng trước khi xóa
                TaiKhoanNganHang deletedTaiKhoan = new TaiKhoanNganHang((DataRowView)bdsTK[bdsTK.Position]);

                try
                {
                    //Xóa trên trên giao diện
                    bdsTK.RemoveCurrent();
                    bdsTKGoc.RemoveCurrent();

                    //Cập nhật dữ liệu lên database
                    taTK.Update(this.dS.SP_LAYTAIKHOANTHEOCMND);
                    taTKGoc.Update(this.dS.TaiKhoan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa tài khoản: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCMND, CMND, maCN);
                    taTKGoc.Fill(this.dS.TaiKhoan);

                    bdsTK.Position = bdsTK.Find(TaiKhoanNganHang.SOTK_HEADER, soTK);
                    bdsTKGoc.Position = bdsTKGoc.Find(TaiKhoanNganHang.SOTK_HEADER, soTK);
                }

                //Enable nút "Delete" nếu còn tài khoản ngân hàng của khách hàng
                btnDelete.Enabled = bdsTK.Count != 0;

                //Thêm vào stack undo
                undoStack.AddLast(new UserEventData(UserEventData.EventType.INSERT, deletedTaiKhoan, -1));
                btnUndo.Enabled = true;
                ControlUtil.ResolveStackStorage(undoStack);

                reload();
            }
        }

        //Module hỗ trợ việc reload:
        public void reload()
        {
            this.taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCMND, CMND.Trim(), maCN.Trim());
            this.taTKGoc.Fill(this.dS.TaiKhoan);
        }

        private void txbSoDu_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
