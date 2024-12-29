
namespace FinalProjectNHPT.SimpleForm
{
    partial class FormCustomerCreateLogin
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
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label lOGINNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerCreateLogin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbLoginName = new DevExpress.XtraEditors.TextEdit();
            this.bdsLayLoginName = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLayHoTenCMNDKH = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new FinalProjectNHPT.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCreateLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
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
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbHoTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txbCMND = new DevExpress.XtraEditors.TextEdit();
            this.sP_LAYHOTENCMNDKHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCN = new DevExpress.XtraEditors.PanelControl();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taLayHoTenCMNDKH = new FinalProjectNHPT.DSTableAdapters.SP_LAYHOTENCMNDKHTableAdapter();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.taLayLoginName = new FinalProjectNHPT.DSTableAdapters.SP_LAYLOGINNAMEKHTableAdapter();
            hOTENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            lOGINNAMELabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayLoginName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayHoTenCMNDKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHoTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYHOTENCMNDKHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).BeginInit();
            this.pnCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(140, 47);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(202, 25);
            hOTENLabel.TabIndex = 0;
            hOTENLabel.Text = "Họ và tên khách hàng";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(270, 116);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(72, 25);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND";
            // 
            // lOGINNAMELabel
            // 
            lOGINNAMELabel.AutoSize = true;
            lOGINNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOGINNAMELabel.Location = new System.Drawing.Point(197, 176);
            lOGINNAMELabel.Name = "lOGINNAMELabel";
            lOGINNAMELabel.Size = new System.Drawing.Size(145, 25);
            lOGINNAMELabel.TabIndex = 9;
            lOGINNAMELabel.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sP_LAYHOTENCMNDKHDataGridView);
            this.panel1.Controls.Add(this.pnCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 530);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(lOGINNAMELabel);
            this.panel2.Controls.Add(this.txbLoginName);
            this.panel2.Controls.Add(this.txbPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(hOTENLabel);
            this.panel2.Controls.Add(this.txbHoTenKH);
            this.panel2.Controls.Add(cMNDLabel);
            this.panel2.Controls.Add(this.txbCMND);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(756, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 427);
            this.panel2.TabIndex = 10;
            // 
            // txbLoginName
            // 
            this.txbLoginName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLayLoginName, "LOGINNAME", true));
            this.txbLoginName.Location = new System.Drawing.Point(376, 179);
            this.txbLoginName.MenuManager = this.barManager1;
            this.txbLoginName.Name = "txbLoginName";
            this.txbLoginName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginName.Properties.Appearance.Options.UseFont = true;
            this.txbLoginName.Size = new System.Drawing.Size(249, 30);
            this.txbLoginName.TabIndex = 10;
            // 
            // bdsLayLoginName
            // 
            this.bdsLayLoginName.DataMember = "SP_LAYHOTENCMNDKH_SP_LAYLOGINNAMEKH";
            this.bdsLayLoginName.DataSource = this.bdsLayHoTenCMNDKH;
            // 
            // bdsLayHoTenCMNDKH
            // 
            this.bdsLayHoTenCMNDKH.DataMember = "SP_LAYHOTENCMNDKH";
            this.bdsLayHoTenCMNDKH.DataSource = this.dS;
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
            this.barButtonItem1});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            this.bar2.VisibleChanged += new System.EventHandler(this.bar2_VisibleChanged);
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1381, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 560);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1381, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1381, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
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
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(376, 243);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(249, 30);
            this.txbPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // txbHoTenKH
            // 
            this.txbHoTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLayHoTenCMNDKH, "HOTEN", true));
            this.txbHoTenKH.Enabled = false;
            this.txbHoTenKH.Location = new System.Drawing.Point(376, 44);
            this.txbHoTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txbHoTenKH.Name = "txbHoTenKH";
            this.txbHoTenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTenKH.Properties.Appearance.Options.UseFont = true;
            this.txbHoTenKH.Size = new System.Drawing.Size(398, 30);
            this.txbHoTenKH.TabIndex = 1;
            // 
            // txbCMND
            // 
            this.txbCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLayHoTenCMNDKH, "CMND", true));
            this.txbCMND.Enabled = false;
            this.txbCMND.Location = new System.Drawing.Point(376, 113);
            this.txbCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCMND.Properties.Appearance.Options.UseFont = true;
            this.txbCMND.Size = new System.Drawing.Size(249, 30);
            this.txbCMND.TabIndex = 3;
            // 
            // sP_LAYHOTENCMNDKHDataGridView
            // 
            this.sP_LAYHOTENCMNDKHDataGridView.AllowUserToAddRows = false;
            this.sP_LAYHOTENCMNDKHDataGridView.AllowUserToDeleteRows = false;
            this.sP_LAYHOTENCMNDKHDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sP_LAYHOTENCMNDKHDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sP_LAYHOTENCMNDKHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sP_LAYHOTENCMNDKHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sP_LAYHOTENCMNDKHDataGridView.DataSource = this.bdsLayHoTenCMNDKH;
            this.sP_LAYHOTENCMNDKHDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.sP_LAYHOTENCMNDKHDataGridView.Location = new System.Drawing.Point(0, 103);
            this.sP_LAYHOTENCMNDKHDataGridView.Name = "sP_LAYHOTENCMNDKHDataGridView";
            this.sP_LAYHOTENCMNDKHDataGridView.ReadOnly = true;
            this.sP_LAYHOTENCMNDKHDataGridView.RowHeadersWidth = 100;
            this.sP_LAYHOTENCMNDKHDataGridView.RowTemplate.Height = 24;
            this.sP_LAYHOTENCMNDKHDataGridView.Size = new System.Drawing.Size(756, 427);
            this.sP_LAYHOTENCMNDKHDataGridView.TabIndex = 7;
            this.sP_LAYHOTENCMNDKHDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.sP_LAYHOTENCMNDKHDataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn2.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // pnCN
            // 
            this.pnCN.Controls.Add(this.cbBrand);
            this.pnCN.Controls.Add(this.label1);
            this.pnCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCN.Location = new System.Drawing.Point(0, 0);
            this.pnCN.Margin = new System.Windows.Forms.Padding(12);
            this.pnCN.Name = "pnCN";
            this.pnCN.Size = new System.Drawing.Size(1381, 103);
            this.pnCN.TabIndex = 7;
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(184, 48);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(12);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(985, 31);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.SelectionChangeCommitted += new System.EventHandler(this.cbBrand_SelectionChangeCommitted_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // taLayHoTenCMNDKH
            // 
            this.taLayHoTenCMNDKH.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProjectNHPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taLayLoginName
            // 
            this.taLayLoginName.ClearBeforeFill = true;
            // 
            // FormCustomerCreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormCustomerCreateLogin";
            this.Text = "FormCustomerCreateLogin";
            this.Load += new System.EventHandler(this.FormCustomerCreateLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayLoginName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayHoTenCMNDKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHoTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYHOTENCMNDKHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).EndInit();
            this.pnCN.ResumeLayout(false);
            this.pnCN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLayHoTenCMNDKH;
        private DSTableAdapters.SP_LAYHOTENCMNDKHTableAdapter taLayHoTenCMNDKH;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCreateLogin;
        private DevExpress.XtraBars.BarButtonItem btnDeleteLogin;
        private DevExpress.XtraBars.BarButtonItem btnExit;
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
        private DevExpress.XtraEditors.PanelControl pnCN;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsLayLoginName;
        private DSTableAdapters.SP_LAYLOGINNAMEKHTableAdapter taLayLoginName;
        private System.Windows.Forms.DataGridView sP_LAYHOTENCMNDKHDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txbHoTenKH;
        private DevExpress.XtraEditors.TextEdit txbCMND;
        private DevExpress.XtraEditors.TextEdit txbLoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}