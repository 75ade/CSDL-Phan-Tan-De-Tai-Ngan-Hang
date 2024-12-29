using DevExpress.XtraEditors;
using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectNHPT.SimpleForm
{
    public partial class FormCreateLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormCreateLogin()
        {
            InitializeComponent();
        }

        private void reload()
        {
            this.taLayMaNVHoTenNV.Fill(this.dS.SP_LAYMANVHOTENNV);
            this.taLayLoginNameNV.Fill(this.dS.SP_LAYMANVLOGINNAMENV);
        }

        private void FormCreateLogin_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.SP_LAYMANVHOTENNV' table. You can move, or remove it, as needed.
            //Bảng này sẽ lưu họ tên và mã của NV
            this.taLayMaNVHoTenNV.Connection.ConnectionString = Program.connectionStr;
            this.taLayMaNVHoTenNV.Fill(this.dS.SP_LAYMANVHOTENNV);

            //Bảng này sẽ lưu login name của nhân viên
            this.taLayLoginNameNV.Connection.ConnectionString = Program.connectionStr;
            this.taLayLoginNameNV.Fill(this.dS.SP_LAYMANVLOGINNAMENV);
        }

        private void btnCreateLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maNV = txbMaNV.Text.Trim();
            string loginName = txbLoginName.Text;

            txbRole.Text = SecurityContext.User.getGroup();
            string currentUserRole = txbRole.Text;

            if (string.IsNullOrEmpty(loginName))
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loginName.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không được chứa ký tự khoảng trắng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txbPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "EXEC SP_TAOLOGIN @LGNAME, @PW, @USERNAME, @ROLE";
            int res = Program.ExecuteNonQuery(query, new object[] { loginName, password, maNV, currentUserRole });
            if (res == -1)
            {
                MessageBox.Show("Tạo tài khoản đăng nhập cho nhân viên thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
                return;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        private void btnDeleteLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String loginName = txbLoginName.Text.Trim();
            String userName = txbMaNV.Text.Trim();
            String query = "EXEC SP_XOALOGIN @LGNAME, @USERNAME";

            /*            if(loginName.Equals("NO ACCOUNT"))
                        {
                            MessageBox.Show("Không thể xóa vì khách hàng này chưa có tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }*/

            if(MessageBox.Show("Xác nhận xóa tài khoản đăng nhập này của nhân viên ?", "Inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            int res = Program.ExecuteNonQuery(query, new object[] { loginName, userName });
            if (res == -1)
            {
                MessageBox.Show("Xóa tài khoản đăng nhập cho nhân viên thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
                return;
            }
        }

        private void sP_LAYHOTENMANVNGANHANGDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string loginName = txbLoginName.Text;
            string maNV = ((DataRowView)bdsLayMaNVHoTenNV[bdsLayMaNVHoTenNV.Position])["MANV"].ToString().Trim();
            string role;

            /*Console.WriteLine(maNV + ":)");*/

            SqlDataReader myReader = Program.ExecuteSqlDataReader($"EXEC SP_LAYROLENHANVIEN '{maNV}'");

            if(!myReader.Read())
            {
                txbRole.Text = "";
            }
            else
            {
                role = myReader["ROLENAME"].ToString();
                txbRole.Text = role;
            }
            

            if (loginName.Equals("NO ACCOUNT"))
            {
                txbPassword.Text = "";
                txbPassword.Enabled = true;
                txbLoginName.Enabled = true;
                btnDeleteLogin.Enabled = false;
                btnCreateLogin.Enabled = true;
            }
            else
            {
                txbPassword.Text = "******";
                txbPassword.Enabled = false;
                txbLoginName.Enabled = false;
                btnDeleteLogin.Enabled = true;
                btnCreateLogin.Enabled = false;
            }
        }

        private void sP_LAYHOTENMANVNGANHANGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}