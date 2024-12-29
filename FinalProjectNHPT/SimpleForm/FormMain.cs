using DevExpress.XtraBars;
using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Report;
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
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void createAndShowLogin()
        {
            FormLogin f = new FormLogin
            {
                MdiParent = this,
                ChangeUserInfo = UpdateUserInfo
            };
            f.Show();
        }

        private void UpdateUserInfo()
        {
            User user = SecurityContext.User;
            bool isCustomer = user.getGroup().Equals("KhachHang");
            if (user == null)
                return;

            //Phân quyền:
            else
            {
/*                Console.WriteLine(user.getGroup());
                Console.WriteLine(DTO.User.GroupENM.KhachHang);*/
                //Trường hợp User là khách hàng
                if (isCustomer == true)
                {
                    //Cập nhật thanh status 
                    tssID.Text = $"Số CMND: {user.UserName}";
                    tssFullName.Text = $"Họ tên: {user.FullName}";
                    tssGroup.Text = $"Nhóm: {user.getGroup()}";

                    //Khóa nút "Đăng nhập" và 'Tạo tài khoản"
                    btnLogin.Enabled = btnCreateLogin.Enabled = false;

                    //Mở khóa 2 nút "Đăng xuất"
                    btnLogout.Enabled = true;

                    //Khóa các tab "Quản lý", "Nghiệp vụ"
                    ribCategory.Visible = ribService.Visible = false;

                    //Chỉ cho phép khách hàng xem sao kê trong tab "Báo cáo"
                    ribReport.Visible = true;
                    btnDVSaoKe.Enabled = true;
                    btnSaoKe.Enabled = false;

                    btnSaoKe.Visibility = BarItemVisibility.Never;
                    btnDVSaoKe.Visibility = BarItemVisibility.Always;
                    btnTKTKM.Visibility = BarItemVisibility.Never;
                    btnTKTTKH.Visibility = BarItemVisibility.Never;
                }
                else
                {
                    //Cập nhật thanh status 
                    tssID.Text = $"Mã nhân viên: {user.UserName}";
                    tssFullName.Text = $"Họ tên: {user.FullName}";
                    tssGroup.Text = $"Nhóm: {user.getGroup()}";

                    if (user.getGroup().Equals("NganHang"))
                    {
                        btnCKGR.Visibility = BarItemVisibility.Never;
                    }
                    else
                    {
                        btnCKGR.Visibility = BarItemVisibility.Always;
                    }
                    //Khóa nút "Đăng nhập" 
                    btnLogin.Enabled = false;

                    //Mở khóa 2 nút "Đăng xuất" và "Tạo tài khoản"
                    btnLogout.Enabled = btnCreateLogin.Enabled = true;

                    //Cho phép nhấn vào các tab "Quản lý", "Nghiệp vụ" và "Báo cáo"
                    ribCategory.Visible = ribService.Visible = ribReport.Visible = true;
                    btnDVSaoKe.Visibility = BarItemVisibility.Never;

                }
            }
        }

        private void btnLogin_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormLogin));
            if (form != null)
                form.Activate();
            else
                createAndShowLogin();
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {
            btnLogout.Enabled = btnCreateLogin.Enabled = false;
            ribCategory.Visible = ribService.Visible = ribReport.Visible = false;
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach(Form f in MdiChildren)
                {
                    f.Close();
                }
                
                //Bỏ lưu các thong tin liên quan đến tài khoản vừa đăng nhập
                SecurityContext.clearUser();

                //Bật tắt các chức năng hiển thị
                tssID.Text = "Mã nhân viên: ";
                tssFullName.Text = "Họ tên: ";
                tssGroup.Text = "Nhóm: ";

                btnLogin.Enabled = true;
                btnLogout.Enabled = btnCreateLogin.Enabled = false;
                ribCategory.Visible = ribService.Visible = ribReport.Visible = false;
            }
        }

        private void btnCreateLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormCustomer));
            if (form != null)
                form.Activate();
            else
            {
                FormCustomer f = new FormCustomer()
                {
                    MdiParent = this,
                };
                f.Show();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình ?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnMoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormCreateBankAccount));
            if (form != null)
                form.Activate();
            else
            {
                FormCreateBankAccount f = new FormCreateBankAccount()
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnSaoKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(Frpt_SaoKeTaiKhoan));
            if (form != null)
                form.Activate();
            else
            {
                Frpt_SaoKeTaiKhoan f = new Frpt_SaoKeTaiKhoan()
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnDVSaoKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(Frpt_SaoKeTaiKhoanCaNhan));
            if (form != null)
                form.Activate();
            else
            {
                Frpt_SaoKeTaiKhoanCaNhan f = new Frpt_SaoKeTaiKhoanCaNhan()
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnTKDNKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormCustomerCreateLogin));
            if(form != null)
                form.Activate();
            else
            {
                FormCustomerCreateLogin f = new FormCustomerCreateLogin()
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(TempForm));
            if (form != null)
                form.Activate();
            else
            {
                TempForm f = new TempForm()
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnNVNH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormCreateLogin));

            if (form != null)
                form.Activate();
            else
            {
                FormCreateLogin f = new FormCreateLogin()
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormTransaction));
            if (form != null)
                form.Activate();
            else
            {
                FormTransaction f = new FormTransaction()
                {
                    MdiParent = this,
                };

                f.Show();
            }
        }

        // nút nhân viên
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(FormEmployees));
            if (form != null)
                form.Activate();
            else
            {
                FormEmployees f = new FormEmployees()
                {
                    MdiParent = this,

                };
                f.Show();

            }
        }

        // thống kê thông tin khách hàng
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(Frpt_ThongKeKhachHang));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Frpt_ThongKeKhachHang f = new Frpt_ThongKeKhachHang()
                {
                    MdiParent = this,
                };
                f.Show();
            }
        }

        //thống kê tài khoản mở
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = ControlUtil.checkFormExists(this, typeof(Frpt_ThongKeTaiKhoanMo));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Frpt_ThongKeTaiKhoanMo f = new Frpt_ThongKeTaiKhoanMo()
                {
                    MdiParent = this,
                };
                f.Show();
            }
        }
    }
}