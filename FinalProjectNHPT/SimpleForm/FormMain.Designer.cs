
namespace FinalProjectNHPT.SimpleForm
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoKe = new DevExpress.XtraBars.BarButtonItem();
            this.btnDVSaoKe = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKDNKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnTemp = new DevExpress.XtraBars.BarButtonItem();
            this.btnNVNH = new DevExpress.XtraBars.BarButtonItem();
            this.btnCKGR = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKTKM = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKTTKH = new DevExpress.XtraBars.BarButtonItem();
            this.ribSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribCategory = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribService = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFullName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssGroup = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLogin,
            this.btnLogout,
            this.btnCreateLogin,
            this.btnKhachHang,
            this.btnMoTaiKhoan,
            this.btnSaoKe,
            this.btnDVSaoKe,
            this.btnTKDNKH,
            this.btnTemp,
            this.btnNVNH,
            this.btnCKGR,
            this.barButtonItem3,
            this.btnTKTKM,
            this.btnTKTTKH});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribSystem,
            this.ribCategory,
            this.ribService,
            this.ribReport});
            this.ribbon.Size = new System.Drawing.Size(1041, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.LargeWidth = 100;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 2;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.LargeWidth = 100;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Caption = "Tạo tài khoản";
            this.btnCreateLogin.Id = 3;
            this.btnCreateLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateLogin.ImageOptions.SvgImage")));
            this.btnCreateLogin.LargeWidth = 100;
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCreateLogin.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnCreateLogin.VisibleInSearchMenu = false;
            this.btnCreateLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateLogin_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 6;
            this.btnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.Image")));
            this.btnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.LargeImage")));
            this.btnKhachHang.LargeWidth = 100;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnMoTaiKhoan
            // 
            this.btnMoTaiKhoan.Caption = "Mở tài khoản";
            this.btnMoTaiKhoan.Id = 7;
            this.btnMoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoTaiKhoan.ImageOptions.Image")));
            this.btnMoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoTaiKhoan.ImageOptions.LargeImage")));
            this.btnMoTaiKhoan.LargeWidth = 100;
            this.btnMoTaiKhoan.Name = "btnMoTaiKhoan";
            this.btnMoTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoTaiKhoan_ItemClick);
            // 
            // btnSaoKe
            // 
            this.btnSaoKe.Caption = "Sao kê tài khoản";
            this.btnSaoKe.Id = 8;
            this.btnSaoKe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaoKe.ImageOptions.SvgImage")));
            this.btnSaoKe.LargeWidth = 100;
            this.btnSaoKe.Name = "btnSaoKe";
            this.btnSaoKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoKe_ItemClick);
            // 
            // btnDVSaoKe
            // 
            this.btnDVSaoKe.Caption = "Dịch vụ sao kê";
            this.btnDVSaoKe.Id = 9;
            this.btnDVSaoKe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDVSaoKe.ImageOptions.SvgImage")));
            this.btnDVSaoKe.LargeWidth = 100;
            this.btnDVSaoKe.Name = "btnDVSaoKe";
            this.btnDVSaoKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDVSaoKe_ItemClick);
            // 
            // btnTKDNKH
            // 
            this.btnTKDNKH.Caption = "Tài khoản đăng nhập KH";
            this.btnTKDNKH.Id = 10;
            this.btnTKDNKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTKDNKH.ImageOptions.SvgImage")));
            this.btnTKDNKH.LargeWidth = 100;
            this.btnTKDNKH.Name = "btnTKDNKH";
            this.btnTKDNKH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTKDNKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKDNKH_ItemClick);
            // 
            // btnTemp
            // 
            this.btnTemp.Caption = "Temp";
            this.btnTemp.Id = 11;
            this.btnTemp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemp.ImageOptions.Image")));
            this.btnTemp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTemp.ImageOptions.LargeImage")));
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTemp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnNVNH
            // 
            this.btnNVNH.Caption = "Tạo tài khoản NV";
            this.btnNVNH.Id = 12;
            this.btnNVNH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNVNH.ImageOptions.SvgImage")));
            this.btnNVNH.LargeWidth = 100;
            this.btnNVNH.Name = "btnNVNH";
            this.btnNVNH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNVNH_ItemClick);
            // 
            // btnCKGR
            // 
            this.btnCKGR.Caption = "Chuyển khoản và Gửi/Rút tiền";
            this.btnCKGR.Id = 14;
            this.btnCKGR.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btnCKGR.Name = "btnCKGR";
            this.btnCKGR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Nhân viên";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.LargeWidth = 100;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnTKTKM
            // 
            this.btnTKTKM.Caption = "Thống kê tài khoản mở";
            this.btnTKTKM.Id = 16;
            this.btnTKTKM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKTKM.ImageOptions.Image")));
            this.btnTKTKM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTKTKM.ImageOptions.LargeImage")));
            this.btnTKTKM.LargeWidth = 100;
            this.btnTKTKM.Name = "btnTKTKM";
            this.btnTKTKM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnTKTTKH
            // 
            this.btnTKTTKH.Caption = "Thống kê thông tin khách hàng";
            this.btnTKTTKH.Id = 18;
            this.btnTKTTKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKTTKH.ImageOptions.Image")));
            this.btnTKTTKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTKTTKH.ImageOptions.LargeImage")));
            this.btnTKTTKH.LargeWidth = 100;
            this.btnTKTTKH.Name = "btnTKTTKH";
            this.btnTKTTKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // ribSystem
            // 
            this.ribSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribSystem.Name = "ribSystem";
            this.ribSystem.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCreateLogin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribCategory
            // 
            this.ribCategory.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribCategory.Name = "ribCategory";
            this.ribCategory.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTKDNKH);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNVNH);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTemp);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribService
            // 
            this.ribService.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribService.Name = "ribService";
            this.ribService.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMoTaiKhoan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCKGR);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribReport
            // 
            this.ribReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribReport.Name = "ribReport";
            this.ribReport.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSaoKe);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDVSaoKe);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTKTKM);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTKTTKH);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 740);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1041, 30);
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssID,
            this.tssFullName,
            this.tssGroup});
            this.statusStrip1.Location = new System.Drawing.Point(0, 714);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1041, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssID
            // 
            this.tssID.Name = "tssID";
            this.tssID.Size = new System.Drawing.Size(100, 20);
            this.tssID.Text = "Mã nhân viên:";
            // 
            // tssFullName
            // 
            this.tssFullName.Name = "tssFullName";
            this.tssFullName.Size = new System.Drawing.Size(57, 20);
            this.tssFullName.Text = "Họ tên:";
            // 
            // tssGroup
            // 
            this.tssGroup.Name = "tssGroup";
            this.tssGroup.Size = new System.Drawing.Size(53, 20);
            this.tssGroup.Text = "Nhóm:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 770);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FormLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnCreateLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribService;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssID;
        private System.Windows.Forms.ToolStripStatusLabel tssFullName;
        private System.Windows.Forms.ToolStripStatusLabel tssGroup;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnMoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnSaoKe;
        private DevExpress.XtraBars.BarButtonItem btnDVSaoKe;
        private DevExpress.XtraBars.BarButtonItem btnTKDNKH;
        private DevExpress.XtraBars.BarButtonItem btnTemp;
        private DevExpress.XtraBars.BarButtonItem btnNVNH;
        private DevExpress.XtraBars.BarButtonItem btnCKGR;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnTKTKM;
        private DevExpress.XtraBars.BarButtonItem btnTKTTKH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}