
namespace FinalProjectNHPT.SimpleForm
{
    partial class FormAccount
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnChange = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new FinalProjectNHPT.DS();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnInput = new System.Windows.Forms.Panel();
            this.pnTinyButVitalAF = new System.Windows.Forms.Panel();
            this.edNgayMoTKGoc = new DevExpress.XtraEditors.DateEdit();
            this.bdsTKGoc = new System.Windows.Forms.BindingSource(this.components);
            this.txbSoTKGoc = new DevExpress.XtraEditors.TextEdit();
            this.txbMaCNGoc = new DevExpress.XtraEditors.TextEdit();
            this.txbCMNDGoc = new DevExpress.XtraEditors.TextEdit();
            this.txbSoDuGoc = new DevExpress.XtraEditors.SpinEdit();
            this.txbSoTK = new DevExpress.XtraEditors.TextEdit();
            this.txbCMND = new DevExpress.XtraEditors.TextEdit();
            this.txbSoDu = new DevExpress.XtraEditors.SpinEdit();
            this.txbMaCN = new DevExpress.XtraEditors.TextEdit();
            this.edNgayMoTK = new DevExpress.XtraEditors.DateEdit();
            this.taTK = new FinalProjectNHPT.DSTableAdapters.SP_LAYTAIKHOANTHEOCMNDTableAdapter();
            this.bdsChuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.taChuyenTien = new FinalProjectNHPT.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.bdsGoiRut = new System.Windows.Forms.BindingSource(this.components);
            this.taGoiRut = new FinalProjectNHPT.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.taTKGoc = new FinalProjectNHPT.DSTableAdapters.TaiKhoanTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnInput.SuspendLayout();
            this.pnTinyButVitalAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTKGoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTKGoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTKGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoTKGoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaCNGoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMNDGoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoDuGoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(77, 41);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(145, 29);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(749, 41);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(85, 29);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODULabel.Location = new System.Drawing.Point(146, 123);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(76, 29);
            sODULabel.TabIndex = 4;
            sODULabel.Text = "Số dư";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(680, 123);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(154, 29);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã chi nhánh";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYMOTKLabel.Location = new System.Drawing.Point(11, 206);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(211, 29);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "Ngày mở tài khoản";
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
            this.btnDelete,
            this.btnChange});
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
            this.bar2.FloatLocation = new System.Drawing.Point(425, 617);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChange),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnChange
            // 
            this.btnChange.Caption = "Hiệu chỉnh";
            this.btnChange.Id = 14;
            this.btnChange.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChange.ImageOptions.SvgImage")));
            this.btnChange.Name = "btnChange";
            this.btnChange.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChange_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1355, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 829);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1355, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 799);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1355, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 799);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Hiệu chỉnh";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 10;
            this.btnRedo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.Image")));
            this.btnRedo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.LargeImage")));
            this.btnRedo.Name = "btnRedo";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gcTK
            // 
            this.gcTK.DataSource = this.bdsTK;
            this.gcTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTK.Location = new System.Drawing.Point(0, 30);
            this.gcTK.MainView = this.gridView1;
            this.gcTK.MenuManager = this.barManager1;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(1355, 254);
            this.gcTK.TabIndex = 9;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "SP_LAYTAIKHOANTHEOCMND";
            this.bdsTK.DataSource = this.dS;
            this.bdsTK.Sort = "";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.gcTK;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.DisplayFormat.FormatString = "{0:#,#đ}";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở tài khoản";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.pnTinyButVitalAF);
            this.pnInput.Controls.Add(sOTKLabel);
            this.pnInput.Controls.Add(this.txbSoTK);
            this.pnInput.Controls.Add(cMNDLabel);
            this.pnInput.Controls.Add(this.txbCMND);
            this.pnInput.Controls.Add(sODULabel);
            this.pnInput.Controls.Add(this.txbSoDu);
            this.pnInput.Controls.Add(mACNLabel);
            this.pnInput.Controls.Add(this.txbMaCN);
            this.pnInput.Controls.Add(nGAYMOTKLabel);
            this.pnInput.Controls.Add(this.edNgayMoTK);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInput.Location = new System.Drawing.Point(0, 284);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(1355, 545);
            this.pnInput.TabIndex = 10;
            // 
            // pnTinyButVitalAF
            // 
            this.pnTinyButVitalAF.Controls.Add(this.edNgayMoTKGoc);
            this.pnTinyButVitalAF.Controls.Add(this.txbSoTKGoc);
            this.pnTinyButVitalAF.Controls.Add(this.txbMaCNGoc);
            this.pnTinyButVitalAF.Controls.Add(this.txbCMNDGoc);
            this.pnTinyButVitalAF.Controls.Add(this.txbSoDuGoc);
            this.pnTinyButVitalAF.Location = new System.Drawing.Point(1312, 498);
            this.pnTinyButVitalAF.Name = "pnTinyButVitalAF";
            this.pnTinyButVitalAF.Size = new System.Drawing.Size(10, 10);
            this.pnTinyButVitalAF.TabIndex = 20;
            // 
            // edNgayMoTKGoc
            // 
            this.edNgayMoTKGoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGoc, "NGAYMOTK", true));
            this.edNgayMoTKGoc.EditValue = null;
            this.edNgayMoTKGoc.Location = new System.Drawing.Point(27, 132);
            this.edNgayMoTKGoc.MenuManager = this.barManager1;
            this.edNgayMoTKGoc.Name = "edNgayMoTKGoc";
            this.edNgayMoTKGoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNgayMoTKGoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNgayMoTKGoc.Size = new System.Drawing.Size(125, 22);
            this.edNgayMoTKGoc.TabIndex = 19;
            // 
            // bdsTKGoc
            // 
            this.bdsTKGoc.DataMember = "TaiKhoan";
            this.bdsTKGoc.DataSource = this.dS;
            // 
            // txbSoTKGoc
            // 
            this.txbSoTKGoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGoc, "SOTK", true));
            this.txbSoTKGoc.Location = new System.Drawing.Point(27, 18);
            this.txbSoTKGoc.MenuManager = this.barManager1;
            this.txbSoTKGoc.Name = "txbSoTKGoc";
            this.txbSoTKGoc.Size = new System.Drawing.Size(125, 22);
            this.txbSoTKGoc.TabIndex = 11;
            // 
            // txbMaCNGoc
            // 
            this.txbMaCNGoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGoc, "MACN", true));
            this.txbMaCNGoc.Location = new System.Drawing.Point(27, 104);
            this.txbMaCNGoc.MenuManager = this.barManager1;
            this.txbMaCNGoc.Name = "txbMaCNGoc";
            this.txbMaCNGoc.Size = new System.Drawing.Size(125, 22);
            this.txbMaCNGoc.TabIndex = 17;
            // 
            // txbCMNDGoc
            // 
            this.txbCMNDGoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGoc, "CMND", true));
            this.txbCMNDGoc.Location = new System.Drawing.Point(27, 46);
            this.txbCMNDGoc.MenuManager = this.barManager1;
            this.txbCMNDGoc.Name = "txbCMNDGoc";
            this.txbCMNDGoc.Size = new System.Drawing.Size(125, 22);
            this.txbCMNDGoc.TabIndex = 13;
            // 
            // txbSoDuGoc
            // 
            this.txbSoDuGoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGoc, "SODU", true));
            this.txbSoDuGoc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txbSoDuGoc.Location = new System.Drawing.Point(27, 74);
            this.txbSoDuGoc.MenuManager = this.barManager1;
            this.txbSoDuGoc.Name = "txbSoDuGoc";
            this.txbSoDuGoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txbSoDuGoc.Size = new System.Drawing.Size(125, 24);
            this.txbSoDuGoc.TabIndex = 15;
            // 
            // txbSoTK
            // 
            this.txbSoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txbSoTK.Location = new System.Drawing.Point(248, 36);
            this.txbSoTK.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoTK.Name = "txbSoTK";
            this.txbSoTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoTK.Properties.Appearance.Options.UseFont = true;
            this.txbSoTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbSoTK.Size = new System.Drawing.Size(294, 34);
            this.txbSoTK.TabIndex = 1;
            // 
            // txbCMND
            // 
            this.txbCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "CMND", true));
            this.txbCMND.Location = new System.Drawing.Point(854, 36);
            this.txbCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCMND.Properties.Appearance.Options.UseFont = true;
            this.txbCMND.Size = new System.Drawing.Size(294, 34);
            this.txbCMND.TabIndex = 3;
            // 
            // txbSoDu
            // 
            this.txbSoDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SODU", true));
            this.txbSoDu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txbSoDu.Location = new System.Drawing.Point(248, 118);
            this.txbSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoDu.Name = "txbSoDu";
            this.txbSoDu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoDu.Properties.Appearance.Options.UseFont = true;
            this.txbSoDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txbSoDu.Size = new System.Drawing.Size(294, 34);
            this.txbSoDu.TabIndex = 5;
            this.txbSoDu.EditValueChanged += new System.EventHandler(this.txbSoDu_EditValueChanged);
            // 
            // txbMaCN
            // 
            this.txbMaCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "MACN", true));
            this.txbMaCN.Location = new System.Drawing.Point(854, 118);
            this.txbMaCN.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaCN.Name = "txbMaCN";
            this.txbMaCN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaCN.Properties.Appearance.Options.UseFont = true;
            this.txbMaCN.Size = new System.Drawing.Size(294, 34);
            this.txbMaCN.TabIndex = 7;
            // 
            // edNgayMoTK
            // 
            this.edNgayMoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.edNgayMoTK.EditValue = null;
            this.edNgayMoTK.Location = new System.Drawing.Point(248, 201);
            this.edNgayMoTK.Margin = new System.Windows.Forms.Padding(4);
            this.edNgayMoTK.Name = "edNgayMoTK";
            this.edNgayMoTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNgayMoTK.Properties.Appearance.Options.UseFont = true;
            this.edNgayMoTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNgayMoTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNgayMoTK.Size = new System.Drawing.Size(294, 34);
            this.edNgayMoTK.TabIndex = 9;
            // 
            // taTK
            // 
            this.taTK.ClearBeforeFill = true;
            // 
            // bdsChuyenTien
            // 
            this.bdsChuyenTien.DataMember = "FK_GD_CHUYENTIEN_TaiKhoan1";
            this.bdsChuyenTien.DataSource = this.bdsTKGoc;
            // 
            // taChuyenTien
            // 
            this.taChuyenTien.ClearBeforeFill = true;
            // 
            // bdsGoiRut
            // 
            this.bdsGoiRut.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.bdsGoiRut.DataSource = this.bdsTKGoc;
            // 
            // taGoiRut
            // 
            this.taGoiRut.ClearBeforeFill = true;
            // 
            // taTKGoc
            // 
            this.taTKGoc.ClearBeforeFill = true;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 849);
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.gcTK);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.pnTinyButVitalAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTKGoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTKGoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTKGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoTKGoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaCNGoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMNDGoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoDuGoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNgayMoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnChange;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.Panel pnInput;
        private DevExpress.XtraEditors.TextEdit txbSoTK;
        private DevExpress.XtraEditors.TextEdit txbCMND;
        private DevExpress.XtraEditors.SpinEdit txbSoDu;
        private DevExpress.XtraEditors.TextEdit txbMaCN;
        private DevExpress.XtraEditors.DateEdit edNgayMoTK;
        private DevExpress.XtraEditors.TextEdit txbSoTKGoc;
        private DevExpress.XtraEditors.TextEdit txbCMNDGoc;
        private DevExpress.XtraEditors.SpinEdit txbSoDuGoc;
        private DevExpress.XtraEditors.TextEdit txbMaCNGoc;
        private DevExpress.XtraEditors.DateEdit edNgayMoTKGoc;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.SP_LAYTAIKHOANTHEOCMNDTableAdapter taTK;
        private System.Windows.Forms.Panel pnTinyButVitalAF;
        private System.Windows.Forms.BindingSource bdsChuyenTien;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter taChuyenTien;
        private System.Windows.Forms.BindingSource bdsGoiRut;
        private DSTableAdapters.GD_GOIRUTTableAdapter taGoiRut;
        private System.Windows.Forms.BindingSource bdsTKGoc;
        private DSTableAdapters.TaiKhoanTableAdapter taTKGoc;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}