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
    public partial class FormCustomerCreateLogin : Form
    {
        public FormCustomerCreateLogin()
        {
            InitializeComponent();
        }
        
        private void FormCustomerCreateLogin_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

          
            // TODO: This line of code loads data into the 'dS.SP_LAYHOTENCMNDKH' table. You can move, or remove it, as needed.
            this.taLayHoTenCMNDKH.Connection.ConnectionString = Program.connectionStr;
            this.taLayHoTenCMNDKH.Fill(this.dS.SP_LAYHOTENCMNDKH);

            // TODO: This line of code loads data into the 'dS.SP_LAYLOGINNAMEKH' table. You can move, or remove it, as needed.
            this.taLayLoginName.Connection.ConnectionString = Program.connectionStr;
            this.taLayLoginName.Fill(this.dS.SP_LAYLOGINNAMEKH);



            cbBrand.DataSource = Program.bindingSource;
            cbBrand.DisplayMember = "TENCN";
            cbBrand.ValueMember = "TENSERVER";
            

            cbBrand.SelectedIndex = SecurityContext.User.BrandIndex;

            switch (SecurityContext.User.Group)
            {
                case DTO.User.GroupENM.NganHang:
                    cbBrand.Enabled = true;
                    txbLoginName.Enabled = txbPassword.Enabled = false;
                    btnCreateLogin.Enabled = btnDeleteLogin.Enabled = false;
                    break;

                case DTO.User.GroupENM.ChiNhanh:
                    cbBrand.Enabled = false;
                    txbLoginName.Enabled = txbPassword.Enabled = true;
                    btnCreateLogin.Enabled = btnDeleteLogin.Enabled = true;
                    break;

                default:
                    throw new Exception("Undefined group");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cbBrand_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            String serverName = cbBrand.SelectedValue.ToString();
            User user = SecurityContext.User;

            if (cbBrand.SelectedIndex != user.BrandIndex)
                Program.setServerToRemote(serverName);

            else
                Program.setServerSubscriber(serverName, user.LoginName, user.Password);

            if (!Program.checkConnection())
            {
                MessageBox.Show("Lỗi kết nối sang chi nhánh khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.taLayHoTenCMNDKH.Connection.ConnectionString = Program.connectionStr;
            this.taLayHoTenCMNDKH.Fill(this.dS.SP_LAYHOTENCMNDKH);
        }

        private void btnCreateLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string CMND = txbCMND.Text;
            string loginName = txbLoginName.Text;

            Console.WriteLine(CMND);
/*
            if (!loginName.Equals("NO ACCOUNT"))
            {
                MessageBox.Show("Tài khoản đã có login name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            if (string.IsNullOrEmpty(loginName))
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loginName.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không được chứa ký tự space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txbPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "EXEC SP_TAOLOGIN @LGNAME, @PW, @USERNAME, @ROLE";
            int res = Program.ExecuteNonQuery(query, new object[] { loginName, password, CMND, "KhachHang" });
            if (res == -1)
            {
                MessageBox.Show("Tạo tài khoản đăng nhập cho khách hàng thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.taLayHoTenCMNDKH.Fill(this.dS.SP_LAYHOTENCMNDKH);
                this.taLayLoginName.Fill(this.dS.SP_LAYLOGINNAMEKH);
                return;
            }
        }

        private void btnDeleteLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String loginName = txbLoginName.Text;
            String userName = txbCMND.Text;
            String query = "EXEC SP_XOALOGIN @LGNAME, @USERNAME";

/*            if(loginName.Equals("NO ACCOUNT"))
            {
                MessageBox.Show("Không thể xóa vì khách hàng này chưa có tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            int res = Program.ExecuteNonQuery(query, new object[] { loginName, userName });
            if (res == -1)
            {
                MessageBox.Show("Xóa tài khoản đăng nhập cho khách hàng thành công", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.taLayHoTenCMNDKH.Fill(this.dS.SP_LAYHOTENCMNDKH);
                this.taLayLoginName.Fill(this.dS.SP_LAYLOGINNAMEKH);
                return;
            }  
        }

        private void bar2_VisibleChanged(object sender, EventArgs e)
        {
            
        }


        private void sP_LAYHOTENCMNDKHDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String loginName = txbLoginName.Text;

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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taLayHoTenCMNDKH.Fill(this.dS.SP_LAYHOTENCMNDKH);
            this.taLayLoginName.Fill(this.dS.SP_LAYLOGINNAMEKH);
        }
    }
}
