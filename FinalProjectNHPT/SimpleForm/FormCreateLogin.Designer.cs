
namespace FinalProjectNHPT.SimpleForm
{
    partial class FormCreateLogin
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label lOGINNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateLogin));
            this.dS = new FinalProjectNHPT.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCreateLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.sP_LAYHOTENMANVNGANHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.bdsLayMaNVHoTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbLoginName = new DevExpress.XtraEditors.TextEdit();
            this.bdsLayLoginNameNV = new System.Windows.Forms.BindingSource(this.components);
            this.txbMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txbHoTenNV = new DevExpress.XtraEditors.TextEdit();
            this.taLayLoginNameNV = new FinalProjectNHPT.DSTableAdapters.SP_LAYMANVLOGINNAMENVTableAdapter();
            this.taLayMaNVHoTenNV = new FinalProjectNHPT.DSTableAdapters.SP_LAYMANVHOTENNVTableAdapter();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mANVLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            lOGINNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYHOTENMANVNGANHANGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayMaNVHoTenNV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayLoginNameNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHoTenNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(69, 121);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(129, 24);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(35, 47);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(163, 24);
            hOTENLabel.TabIndex = 2;
            hOTENLabel.Text = "Họ tên nhân viên";
            // 
            // lOGINNAMELabel
            // 
            lOGINNAMELabel.AutoSize = true;
            lOGINNAMELabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOGINNAMELabel.Location = new System.Drawing.Point(54, 187);
            lOGINNAMELabel.Name = "lOGINNAMELabel";
            lOGINNAMELabel.Size = new System.Drawing.Size(144, 24);
            lOGINNAMELabel.TabIndex = 4;
            lOGINNAMELabel.Text = "Tên đăng nhập";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnUpdate,
            this.btnSave,
            this.btnUndo,
            this.btnReload,
            this.btnExit,
            this.btnRedo,
            this.btnCreateLogin,
            this.btnDeleteLogin,
            this.btnRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(847, 189);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCreateLogin, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDeleteLogin, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Caption = "Thêm";
            this.btnCreateLogin.Id = 12;
            this.btnCreateLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateLogin.ImageOptions.Image")));
            this.btnCreateLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCreateLogin.ImageOptions.LargeImage")));
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateLogin_ItemClick);
            // 
            // btnDeleteLogin
            // 
            this.btnDeleteLogin.Caption = "Xóa";
            this.btnDeleteLogin.Id = 13;
            this.btnDeleteLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteLogin.ImageOptions.SvgImage")));
            this.btnDeleteLogin.Name = "btnDeleteLogin";
            this.btnDeleteLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteLogin_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 7;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 14;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(1354, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 699);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1354, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 669);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1354, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 669);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Hiệu chỉnh";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Xem lại";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 10;
            this.btnRedo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.Image")));
            this.btnRedo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.LargeImage")));
            this.btnRedo.Name = "btnRedo";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.SP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDTableAdapter = null;
            this.tableAdapterManager.SP_LAYTAIKHOANTHEOCMNDTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProjectNHPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LAYHOTENMANVNGANHANGDataGridView
            // 
            this.sP_LAYHOTENMANVNGANHANGDataGridView.AutoGenerateColumns = false;
            this.sP_LAYHOTENMANVNGANHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sP_LAYHOTENMANVNGANHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn});
            this.sP_LAYHOTENMANVNGANHANGDataGridView.DataSource = this.bdsLayMaNVHoTenNV;
            this.sP_LAYHOTENMANVNGANHANGDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.sP_LAYHOTENMANVNGANHANGDataGridView.Location = new System.Drawing.Point(0, 30);
            this.sP_LAYHOTENMANVNGANHANGDataGridView.Name = "sP_LAYHOTENMANVNGANHANGDataGridView";
            this.sP_LAYHOTENMANVNGANHANGDataGridView.RowHeadersWidth = 51;
            this.sP_LAYHOTENMANVNGANHANGDataGridView.RowTemplate.Height = 24;
            this.sP_LAYHOTENMANVNGANHANGDataGridView.Size = new System.Drawing.Size(600, 669);
            this.sP_LAYHOTENMANVNGANHANGDataGridView.TabIndex = 5;
            this.sP_LAYHOTENMANVNGANHANGDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sP_LAYHOTENMANVNGANHANGDataGridView_CellContentClick);
            this.sP_LAYHOTENMANVNGANHANGDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.sP_LAYHOTENMANVNGANHANGDataGridView_CellEnter);
            // 
            // bdsLayMaNVHoTenNV
            // 
            this.bdsLayMaNVHoTenNV.DataMember = "SP_LAYMANVHOTENNV";
            this.bdsLayMaNVHoTenNV.DataSource = this.dS;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(lOGINNAMELabel);
            this.panel1.Controls.Add(this.txbLoginName);
            this.panel1.Controls.Add(mANVLabel);
            this.panel1.Controls.Add(this.txbMaNV);
            this.panel1.Controls.Add(hOTENLabel);
            this.panel1.Controls.Add(this.txbHoTenNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(600, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 669);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vai trò";
            // 
            // txbRole
            // 
            this.txbRole.Enabled = false;
            this.txbRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRole.Location = new System.Drawing.Point(204, 334);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(214, 32);
            this.txbRole.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(204, 255);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(214, 32);
            this.txbPassword.TabIndex = 6;
            // 
            // txbLoginName
            // 
            this.txbLoginName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLayLoginNameNV, "LOGINNAME", true));
            this.txbLoginName.Location = new System.Drawing.Point(204, 184);
            this.txbLoginName.MenuManager = this.barManager1;
            this.txbLoginName.Name = "txbLoginName";
            this.txbLoginName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginName.Properties.Appearance.Options.UseFont = true;
            this.txbLoginName.Size = new System.Drawing.Size(214, 30);
            this.txbLoginName.TabIndex = 5;
            // 
            // bdsLayLoginNameNV
            // 
            this.bdsLayLoginNameNV.DataMember = "FK_SP_LAYMANVHOTENNV_SP_LAYMANVLOGINNAMENV";
            this.bdsLayLoginNameNV.DataSource = this.bdsLayMaNVHoTenNV;
            // 
            // txbMaNV
            // 
            this.txbMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLayMaNVHoTenNV, "MANV", true));
            this.txbMaNV.Enabled = false;
            this.txbMaNV.Location = new System.Drawing.Point(204, 115);
            this.txbMaNV.MenuManager = this.barManager1;
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNV.Properties.Appearance.Options.UseFont = true;
            this.txbMaNV.Size = new System.Drawing.Size(214, 30);
            this.txbMaNV.TabIndex = 1;
            // 
            // txbHoTenNV
            // 
            this.txbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLayMaNVHoTenNV, "HOTEN", true));
            this.txbHoTenNV.Enabled = false;
            this.txbHoTenNV.Location = new System.Drawing.Point(204, 41);
            this.txbHoTenNV.MenuManager = this.barManager1;
            this.txbHoTenNV.Name = "txbHoTenNV";
            this.txbHoTenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTenNV.Properties.Appearance.Options.UseFont = true;
            this.txbHoTenNV.Size = new System.Drawing.Size(495, 30);
            this.txbHoTenNV.TabIndex = 3;
            // 
            // taLayLoginNameNV
            // 
            this.taLayLoginNameNV.ClearBeforeFill = true;
            // 
            // taLayMaNVHoTenNV
            // 
            this.taLayMaNVHoTenNV.ClearBeforeFill = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Họ tên nhân viên";
            this.hOTENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.ReadOnly = true;
            this.hOTENDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormCreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sP_LAYHOTENMANVNGANHANGDataGridView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormCreateLogin";
            this.Text = "FormCreateLogin";
            this.Load += new System.EventHandler(this.FormCreateLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYHOTENMANVNGANHANGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayMaNVHoTenNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayLoginNameNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHoTenNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCreateLogin;
        private DevExpress.XtraBars.BarButtonItem btnDeleteLogin;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txbMaNV;
        private DevExpress.XtraEditors.TextEdit txbHoTenNV;
        private System.Windows.Forms.DataGridView sP_LAYHOTENMANVNGANHANGDataGridView;
        private System.Windows.Forms.BindingSource bdsLayLoginNameNV;
        private DSTableAdapters.SP_LAYMANVLOGINNAMENVTableAdapter taLayLoginNameNV;
        private DevExpress.XtraEditors.TextEdit txbLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.BindingSource bdsLayMaNVHoTenNV;
        private DSTableAdapters.SP_LAYMANVHOTENNVTableAdapter taLayMaNVHoTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
    }
}