
namespace FinalProjectNHPT.SimpleForm
{
    partial class FormCustomer
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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnCN = new DevExpress.XtraEditors.PanelControl();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new FinalProjectNHPT.DS();
            this.taKH = new FinalProjectNHPT.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.taTK = new FinalProjectNHPT.DSTableAdapters.TaiKhoanTableAdapter();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLayLoginNameKH = new System.Windows.Forms.BindingSource(this.components);
            this.taLayLoginNameKH = new FinalProjectNHPT.DSTableAdapters.SP_LAYLOGINNAMEKHTableAdapter();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txbBrandId = new DevExpress.XtraEditors.TextEdit();
            this.txbPhoneNum = new DevExpress.XtraEditors.TextEdit();
            this.deDateAccept = new DevExpress.XtraEditors.DateEdit();
            this.txbAddress = new DevExpress.XtraEditors.TextEdit();
            this.txbFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txbLastName = new DevExpress.XtraEditors.TextEdit();
            this.txbId = new DevExpress.XtraEditors.TextEdit();
            this.pnInput = new System.Windows.Forms.Panel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            mACNLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).BeginInit();
            this.pnCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayLoginNameKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBrandId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhoneNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateAccept.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateAccept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbId.Properties)).BeginInit();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(10, 160);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(128, 24);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "Mã chi nhánh";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(710, 98);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(127, 24);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "Số điện thoại";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYCAPLabel.Location = new System.Drawing.Point(22, 95);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(92, 24);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "Ngày cấp";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(369, 95);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(48, 24);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "Phái";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(369, 164);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(71, 24);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(359, 23);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(97, 24);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ và tên";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(47, 25);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(64, 24);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND";
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
            this.btnInsert,
            this.btnDelete});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(425, 617);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRedo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "Thêm";
            this.btnInsert.Id = 12;
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.LargeImage")));
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsert_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Hiệu chỉnh";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 13;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 10;
            this.btnRedo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.Image")));
            this.btnRedo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.LargeImage")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Xem lại";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1391, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 810);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1391, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 780);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1391, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 780);
            // 
            // pnCN
            // 
            this.pnCN.Controls.Add(this.cbBrand);
            this.pnCN.Controls.Add(this.label1);
            this.pnCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCN.Location = new System.Drawing.Point(0, 30);
            this.pnCN.Margin = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.pnCN.Name = "pnCN";
            this.pnCN.Size = new System.Drawing.Size(1391, 86);
            this.pnCN.TabIndex = 6;
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(146, 27);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(625, 31);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.SelectionChangeCommitted += new System.EventHandler(this.cbBrand_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taKH
            // 
            this.taKH.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.taKH;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.SP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDTableAdapter = null;
            this.tableAdapterManager.SP_LAYTAIKHOANTHEOCMNDTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProjectNHPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taTK
            // 
            this.taTK.ClearBeforeFill = true;
            // 
            // bdsTK
            // 
            this.bdsTK.AllowNew = false;
            this.bdsTK.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // bdsLayLoginNameKH
            // 
            this.bdsLayLoginNameKH.DataMember = "FK_KhachHang_SP_LAYLOGINNAMEKH";
            this.bdsLayLoginNameKH.DataSource = this.bdsKH;
            // 
            // taLayLoginNameKH
            // 
            this.taLayLoginNameKH.ClearBeforeFill = true;
            // 
            // cbGender
            // 
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "PHAI", true));
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "PHAI", true));
            this.cbGender.Location = new System.Drawing.Point(441, 92);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGender.MenuManager = this.barManager1;
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.Properties.Appearance.Options.UseFont = true;
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Size = new System.Drawing.Size(209, 30);
            this.cbGender.TabIndex = 9;
            // 
            // txbBrandId
            // 
            this.txbBrandId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "MACN", true));
            this.txbBrandId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "MACN", true));
            this.txbBrandId.Location = new System.Drawing.Point(167, 158);
            this.txbBrandId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBrandId.MenuManager = this.barManager1;
            this.txbBrandId.Name = "txbBrandId";
            this.txbBrandId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrandId.Properties.Appearance.Options.UseFont = true;
            this.txbBrandId.Size = new System.Drawing.Size(156, 30);
            this.txbBrandId.TabIndex = 15;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "SODT", true));
            this.txbPhoneNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "SODT", true));
            this.txbPhoneNum.Location = new System.Drawing.Point(850, 96);
            this.txbPhoneNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPhoneNum.MenuManager = this.barManager1;
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNum.Properties.Appearance.Options.UseFont = true;
            this.txbPhoneNum.Size = new System.Drawing.Size(156, 30);
            this.txbPhoneNum.TabIndex = 13;
            // 
            // deDateAccept
            // 
            this.deDateAccept.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "NGAYCAP", true));
            this.deDateAccept.EditValue = null;
            this.deDateAccept.Location = new System.Drawing.Point(120, 92);
            this.deDateAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deDateAccept.MenuManager = this.barManager1;
            this.deDateAccept.Name = "deDateAccept";
            this.deDateAccept.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deDateAccept.Properties.Appearance.Options.UseFont = true;
            this.deDateAccept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateAccept.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateAccept.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deDateAccept.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDateAccept.Size = new System.Drawing.Size(209, 30);
            this.deDateAccept.TabIndex = 11;
            // 
            // txbAddress
            // 
            this.txbAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "DIACHI", true));
            this.txbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "DIACHI", true));
            this.txbAddress.Location = new System.Drawing.Point(450, 161);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAddress.MenuManager = this.barManager1;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Properties.Appearance.Options.UseFont = true;
            this.txbAddress.Size = new System.Drawing.Size(563, 30);
            this.txbAddress.TabIndex = 7;
            // 
            // txbFirstName
            // 
            this.txbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "TEN", true));
            this.txbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.txbFirstName.Location = new System.Drawing.Point(748, 18);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFirstName.MenuManager = this.barManager1;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.Properties.Appearance.Options.UseFont = true;
            this.txbFirstName.Size = new System.Drawing.Size(135, 30);
            this.txbFirstName.TabIndex = 5;
            // 
            // txbLastName
            // 
            this.txbLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "HO", true));
            this.txbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "HO", true));
            this.txbLastName.Location = new System.Drawing.Point(460, 18);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbLastName.MenuManager = this.barManager1;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLastName.Properties.Appearance.Options.UseFont = true;
            this.txbLastName.Size = new System.Drawing.Size(272, 30);
            this.txbLastName.TabIndex = 3;
            // 
            // txbId
            // 
            this.txbId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "CMND", true));
            this.txbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "CMND", true));
            this.txbId.Location = new System.Drawing.Point(114, 18);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbId.MenuManager = this.barManager1;
            this.txbId.Name = "txbId";
            this.txbId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Properties.Appearance.Options.UseFont = true;
            this.txbId.Size = new System.Drawing.Size(209, 30);
            this.txbId.TabIndex = 1;
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(cMNDLabel);
            this.pnInput.Controls.Add(this.txbId);
            this.pnInput.Controls.Add(hOLabel);
            this.pnInput.Controls.Add(this.txbLastName);
            this.pnInput.Controls.Add(this.txbFirstName);
            this.pnInput.Controls.Add(dIACHILabel);
            this.pnInput.Controls.Add(this.txbAddress);
            this.pnInput.Controls.Add(pHAILabel);
            this.pnInput.Controls.Add(nGAYCAPLabel);
            this.pnInput.Controls.Add(this.deDateAccept);
            this.pnInput.Controls.Add(sODTLabel);
            this.pnInput.Controls.Add(this.txbPhoneNum);
            this.pnInput.Controls.Add(mACNLabel);
            this.pnInput.Controls.Add(this.txbBrandId);
            this.pnInput.Controls.Add(this.cbGender);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnInput.Location = new System.Drawing.Point(0, 409);
            this.pnInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(1391, 401);
            this.pnInput.TabIndex = 21;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.DetailHeight = 1664;
            this.gridView1.GridControl = this.gcKH;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.AppearanceHeader.Options.UseTextOptions = true;
            this.colCMND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCMND.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 119;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 444;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 119;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 444;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 119;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 444;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 119;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 444;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHAI.Caption = "Giới tính";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 119;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 444;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYCAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYCAP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYCAP.Caption = "Ngày cấp CMND";
            this.colNGAYCAP.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 119;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 444;
            // 
            // colSODT
            // 
            this.colSODT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSODT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSODT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 119;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 444;
            // 
            // colMACN
            // 
            this.colMACN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMACN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMACN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 119;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 444;
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(15);
            this.gcKH.Location = new System.Drawing.Point(0, 116);
            this.gcKH.MainView = this.gridView1;
            this.gcKH.Margin = new System.Windows.Forms.Padding(15);
            this.gcKH.MenuManager = this.barManager1;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(1391, 293);
            this.gcKH.TabIndex = 7;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1391, 830);
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.gcKH);
            this.Controls.Add(this.pnCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).EndInit();
            this.pnCN.ResumeLayout(false);
            this.pnCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayLoginNameKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBrandId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhoneNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateAccept.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateAccept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbId.Properties)).EndInit();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnCN;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KhachHangTableAdapter taKH;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.TaiKhoanTableAdapter taTK;
        private System.Windows.Forms.BindingSource bdsTK;
        private System.Windows.Forms.BindingSource bdsLayLoginNameKH;
        private DSTableAdapters.SP_LAYLOGINNAMEKHTableAdapter taLayLoginNameKH;
        private System.Windows.Forms.Panel pnInput;
        private DevExpress.XtraEditors.TextEdit txbId;
        private DevExpress.XtraEditors.TextEdit txbLastName;
        private DevExpress.XtraEditors.TextEdit txbFirstName;
        private DevExpress.XtraEditors.TextEdit txbAddress;
        private DevExpress.XtraEditors.DateEdit deDateAccept;
        private DevExpress.XtraEditors.TextEdit txbPhoneNum;
        private DevExpress.XtraEditors.TextEdit txbBrandId;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
    }
}