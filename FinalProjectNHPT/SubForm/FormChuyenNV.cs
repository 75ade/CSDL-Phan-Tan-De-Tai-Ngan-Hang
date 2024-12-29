using System;
using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Util;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectNHPT.SubForm
{
    public partial class FormChuyenNV : Form
    {

        private string NhanVienId;
        private string Ho;
        private string Ten;
        private string Cmnd;
        private string DiaChi;
        private string Phai;
        private string SoDT;
        public FormChuyenNV(string MANV, string HO, string TEN, string CMND, string DIACHI, string PHAI, string SODT)
        {
            InitializeComponent();
            this.NhanVienId = MANV;
            this.Ho = HO;
            this.Ten = TEN;
            this.Cmnd = CMND;
            this.DiaChi = DIACHI;
            this.Phai = PHAI;
            this.SoDT = SODT;
        }

        private void FormChuyenNV_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionStr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            Program.setServerToDistributor(Program.serverName);
            if (Program.checkConnection() == false) return;

            this.SP_LAYDSCHINHANHKHACTableAdapter.Connection.ConnectionString = Program.connectionStr;
            // TODO: This line of code loads data into the 'dS.SP_LAYDSCHINHANHKHAC' table. You can move, or remove it, as needed.
            this.SP_LAYDSCHINHANHKHACTableAdapter.Fill(this.dS.SP_LAYDSCHINHANHKHAC);

            txbLastName.Text = Ho;
            txbFirstName.Text = Ten;
            txbCMND.Text = Cmnd;
            txbAddress.Text = DiaChi;
            cbGender.Text = Phai;
            txbPhoneNum.Text = SoDT;
        }

        private void btnMove_Click_1(object sender, EventArgs e)
        {
            // lấy MACN ở row trên bảng Grid
            string selectedBrandId = ((DataRowView)bdsLayDSChiNhanhKhac[bdsLayDSChiNhanhKhac.Position])["MACN"].ToString();

            // Kiểm tra các ràng buộc
            // Nhận mã nhân viên từ khung nhập sau đó bỏ khoảng trắng 2 đầu
            string NhanVienIDNEW = txbId.Text.Trim();
            Cmnd = txbCMND.Text.Trim();
            if (string.IsNullOrEmpty(NhanVienIDNEW))
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                txbId.Focus();
                return;
            }

            // mã nhân viên mới nhập kh được có space
            if (NhanVienIDNEW.Contains(" "))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ");
                txbId.Focus();
                return;
            }

            // mã nhân viên kh dài hơn 10 kí tự
            if (NhanVienIDNEW.Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được vượt quá 10 kí tự");
                txbId.Focus();
                return;
            }

            // Kiểm tra mã nhân viên tồn tại trên site chủ
            if (Program.kiemTraNhanVienTonTai(NhanVienIDNEW) == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng chọn mã khác");
                txbId.Focus();
                return;
            }

            Console.WriteLine(Cmnd);
            // kiểm tra tất cả thông tin của nhân viên cần chuyển có tồn tại bên site kia hay không, nếu có tồn tại thì show thông báo không áp dụng mã nv mới
            if (Program.kiemTraNhanVienTonTai2(Ho, Ten, Cmnd, DiaChi, Phai, SoDT) == 1)
            {
                if (MessageBox.Show($"Nhân viên với mã số mới {NhanVienIDNEW} đã từng thực hiện giao dịch ở chi nhánh " + selectedBrandId + ". Vì thế, mã nhân viên mới sẽ không được áp dụng khi chuyển nhân viên sang chi nhánh " + selectedBrandId + ". Xác nhận chuyển nhân viên?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    /*Console.WriteLine("hello");*/
                    string query = "EXEC dbo.SP_DICHUYENNV @MANV, @MACN, @NEWMANV";

                    int kt = Program.ExecuteNonQuery2(query, new object[] { NhanVienId, selectedBrandId, NhanVienIDNEW });
                    if (kt == 0)
                    {
                        MessageBox.Show("Chuyển nhân viên thành công");
                        Close();
                        // Reload
                        User user = SecurityContext.User;
                        Program.setServerSubscriber(Program.serverName, user.LoginName, user.Password);
                        if (Program.checkConnection() == false)
                            return;

                    }

                }
            }
            else
            {
                // nếu không tồn tại thông tin ở site chuyển đến, chỉ cần lưu mã mới và kiểm tra cmnd có bị trùng hay không
                // gán lại mã nv sau khi kiểm tra
                NhanVienIDNEW = NhanVienIDNEW.ToUpper();
                txbId.Text = NhanVienIDNEW;

                // kiểm tra trùng cmnd
                if (Program.kiemTraCMNDNhanVienTonTai2(Cmnd) == 1)
                {
                    MessageBox.Show("Chứng minh nhân dân đã tồn tại, vui lòng thay đổi CMND của nhân viên cần chuyển ở nút hiệu chỉnh của giao diện chính");
                    Close();
                    return;
                }
                /*Console.WriteLine("hello");*/
                if (MessageBox.Show("Xác nhận chuyển nhân viên?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query = "EXEC dbo.SP_DICHUYENNV @MANV, @MACN, @NEWMANV";

                    int kt = Program.ExecuteNonQuery2(query, new object[] { NhanVienId, selectedBrandId, NhanVienIDNEW });
                    if (kt == 0)
                    {
                        MessageBox.Show("Chuyển nhân viên thành công");
                        Close();
                        // Reload
                        User user = SecurityContext.User;
                        Program.setServerSubscriber(Program.serverName, user.LoginName, user.Password);
                        if (Program.checkConnection() == false)
                            return;

                    }
                }
            }
        }
    }
}

