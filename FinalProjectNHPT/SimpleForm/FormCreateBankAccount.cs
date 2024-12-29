using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectNHPT.SimpleForm
{
    public partial class FormCreateBankAccount : Form
    {
        private string maCN;
        public FormCreateBankAccount()
        {
            InitializeComponent();
        }

        private void FormCreateBankAccount_Load(object sender, EventArgs e)
        {
            //Lấy tên chi nhánh từ binding source và bỏ vào combobox
            cbBrand.DataSource = Program.bindingSource;
            cbBrand.DisplayMember = "TENCN";
            cbBrand.ValueMember = "TENSERVER";

            //Tên chi nhánh trong combobox là tên chi nhánh ban đầu
            //đăng nhập vào
            cbBrand.SelectedIndex = SecurityContext.User.BrandIndex;

            //Ta sẽ set lại connectionStr trong trường hợp:
            //Người dùng chuyển chi nhánh sang site còn lại để xem khách hàng sau đó qua lại mở tài khoản
            //Để tránh trường hợp hiển thị dữ liệu của các tài khoản thuộc site còn lại
            User user = SecurityContext.User;
            string serverName = cbBrand.SelectedValue.ToString();
            Program.setServerSubscriber(serverName, user.LoginName, user.Password);


            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.taKH.Connection.ConnectionString = Program.connectionStr;
            this.taKH.Fill(this.dS.KhachHang);

            //pnTTKH.Enabled = false;

            loadDSTK();


            if (!Program.checkConnection())
            {
                MessageBox.Show("Error");
                return;
            }

            switch (SecurityContext.User.Group)
            {
                case DTO.User.GroupENM.NganHang:
                    cbBrand.Enabled = false;
                    btnReload.Enabled = true;
                    break;

                case DTO.User.GroupENM.ChiNhanh:
                    cbBrand.Enabled = false;
                    btnReload.Enabled = true;
                    break;

                default:
                    throw new Exception("Detected undefined group");
            }
        }

        private void loadDSTK()
        {
            string temp = cbBrand.Text;
            string[] arr = temp.Split('_');
            string maCN = arr[1];

/*            string maCN = ((DataRowView)bdsKH[bdsKH.Position])["MACN"].ToString();*/

            /*            Console.WriteLine(maCN);*/
            this.maCN = maCN;

            this.taTK.Connection.ConnectionString = Program.connectionStr;
            this.taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCN, maCN);
        }

        //Nút xem lại
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                taKH.Fill(this.dS.KhachHang);
                this.taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCN, maCN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Nút thoát
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormNhapCMND));
            if (form != null)
                form.Activate();
            else
            {
                Console.WriteLine(maCN.Trim() + " confirm");
                FormNhapCMND f = new FormNhapCMND(maCN)
                {
                    
                };
                f.Show();
            }
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

            this.taKH.Connection.ConnectionString = Program.connectionStr;
            this.taKH.Fill(this.dS.KhachHang);

            loadDSTK();
        }
    }
}