
namespace FinalProjectNHPT.SimpleForm
{
    partial class FormEmployees
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
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployees));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoveNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS1 = new FinalProjectNHPT.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.taNV = new FinalProjectNHPT.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.taChuyenTien = new FinalProjectNHPT.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.taGuiRut = new FinalProjectNHPT.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.bdsChuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.pnCN = new DevExpress.XtraEditors.PanelControl();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnInput = new DevExpress.XtraEditors.PanelControl();
            this.edTrangThaiXoa = new DevExpress.XtraEditors.TextEdit();
            this.txbBrandId = new DevExpress.XtraEditors.TextEdit();
            this.txbPhoneNum = new DevExpress.XtraEditors.TextEdit();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txbAddress = new DevExpress.XtraEditors.TextEdit();
            this.txbCMND = new DevExpress.XtraEditors.TextEdit();
            this.txbFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txbLastName = new DevExpress.XtraEditors.TextEdit();
            this.txbId = new DevExpress.XtraEditors.TextEdit();
            this.bdsGuiRut = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLayTK = new System.Windows.Forms.BindingSource(this.components);
            this.taLayTK = new FinalProjectNHPT.DSTableAdapters.SP_LAYMANVLOGINNAMENVTableAdapter();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).BeginInit();
            this.pnCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnInput)).BeginInit();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTrangThaiXoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBrandId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhoneNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayTK)).BeginInit();
            this.SuspendLayout();
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(319, 114);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(106, 17);
            trangThaiXoaLabel.TabIndex = 16;
            trangThaiXoaLabel.Text = "Trạng thái xóa: ";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(623, 118);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(52, 17);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "Mã CN:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(319, 70);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(92, 17);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "Số điện thoại:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(42, 110);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(61, 17);
            pHAILabel.TabIndex = 10;
            pHAILabel.Text = "Giới tính:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(623, 74);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 17);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ: ";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(42, 66);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 6;
            cMNDLabel.Text = "CMND:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(623, 28);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(36, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(319, 24);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(42, 24);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(51, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
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
            this.btnMoveNV});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRedo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMoveNV),
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
            // btnMoveNV
            // 
            this.btnMoveNV.Caption = "Chuyển nhân viên";
            this.btnMoveNV.Id = 14;
            this.btnMoveNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveNV.ImageOptions.Image")));
            this.btnMoveNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveNV.ImageOptions.LargeImage")));
            this.btnMoveNV.Name = "btnMoveNV";
            this.btnMoveNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnMoveNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveNV_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1228, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 575);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1228, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 545);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1228, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 545);
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS1;
            // 
            // taNV
            // 
            this.taNV.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.taChuyenTien;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.taGuiRut;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.taNV;
            this.tableAdapterManager.SP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDTableAdapter = null;
            this.tableAdapterManager.SP_LAYTAIKHOANTHEOCMNDTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProjectNHPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taChuyenTien
            // 
            this.taChuyenTien.ClearBeforeFill = true;
            // 
            // taGuiRut
            // 
            this.taGuiRut.ClearBeforeFill = true;
            // 
            // bdsChuyenTien
            // 
            this.bdsChuyenTien.DataMember = "FK_GD_CHUYENTIEN_NhanVien";
            this.bdsChuyenTien.DataSource = this.bdsNV;
            // 
            // pnCN
            // 
            this.pnCN.Controls.Add(this.cbBrand);
            this.pnCN.Controls.Add(this.label1);
            this.pnCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCN.Location = new System.Drawing.Point(0, 30);
            this.pnCN.Margin = new System.Windows.Forms.Padding(21, 18, 21, 18);
            this.pnCN.Name = "pnCN";
            this.pnCN.Size = new System.Drawing.Size(1228, 82);
            this.pnCN.TabIndex = 16;
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(167, 26);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(21, 18, 21, 18);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(462, 31);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.SelectionChangeCommitted += new System.EventHandler(this.cbBrand_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcNV.Location = new System.Drawing.Point(0, 112);
            this.gcNV.MainView = this.gridView1;
            this.gcNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcNV.MenuManager = this.barManager1;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(1228, 176);
            this.gcNV.TabIndex = 16;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcNV.DataSourceChanged += new System.EventHandler(this.gcNV_DataSourceChanged);
            this.gcNV.DefaultViewChanged += new System.EventHandler(this.gcNV_DefaultViewChanged);
            this.gcNV.Load += new System.EventHandler(this.gcNV_Load);
            this.gcNV.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gcNV_ViewRegistered);
            this.gcNV.ViewRemoved += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gcNV_ViewRemoved);
            this.gcNV.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcNV_ProcessGridKey);
            this.gcNV.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gcNV_FocusedViewChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN});
            this.gridView1.DetailHeight = 280;
            this.gridView1.GridControl = this.gcNV;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMANV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMANV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 27;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 100;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 27;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 100;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 27;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 100;
            // 
            // colCMND
            // 
            this.colCMND.AppearanceHeader.Options.UseTextOptions = true;
            this.colCMND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCMND.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 27;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 3;
            this.colCMND.Width = 100;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 27;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 100;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 27;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 5;
            this.colPHAI.Width = 100;
            // 
            // colSODT
            // 
            this.colSODT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSODT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSODT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 27;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 100;
            // 
            // colMACN
            // 
            this.colMACN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMACN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMACN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 27;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 100;
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(trangThaiXoaLabel);
            this.pnInput.Controls.Add(this.edTrangThaiXoa);
            this.pnInput.Controls.Add(mACNLabel);
            this.pnInput.Controls.Add(this.txbBrandId);
            this.pnInput.Controls.Add(sODTLabel);
            this.pnInput.Controls.Add(this.txbPhoneNum);
            this.pnInput.Controls.Add(pHAILabel);
            this.pnInput.Controls.Add(this.cbGender);
            this.pnInput.Controls.Add(dIACHILabel);
            this.pnInput.Controls.Add(this.txbAddress);
            this.pnInput.Controls.Add(cMNDLabel);
            this.pnInput.Controls.Add(this.txbCMND);
            this.pnInput.Controls.Add(tENLabel);
            this.pnInput.Controls.Add(this.txbFirstName);
            this.pnInput.Controls.Add(hOLabel);
            this.pnInput.Controls.Add(this.txbLastName);
            this.pnInput.Controls.Add(mANVLabel);
            this.pnInput.Controls.Add(this.txbId);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInput.Location = new System.Drawing.Point(0, 288);
            this.pnInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(1228, 287);
            this.pnInput.TabIndex = 17;
            // 
            // edTrangThaiXoa
            // 
            this.edTrangThaiXoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TrangThaiXoa", true));
            this.edTrangThaiXoa.Location = new System.Drawing.Point(434, 110);
            this.edTrangThaiXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edTrangThaiXoa.Name = "edTrangThaiXoa";
            this.edTrangThaiXoa.Size = new System.Drawing.Size(21, 22);
            this.edTrangThaiXoa.TabIndex = 17;
            // 
            // txbBrandId
            // 
            this.txbBrandId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txbBrandId.Location = new System.Drawing.Point(689, 114);
            this.txbBrandId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBrandId.Name = "txbBrandId";
            this.txbBrandId.Size = new System.Drawing.Size(133, 22);
            this.txbBrandId.TabIndex = 15;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "SODT", true));
            this.txbPhoneNum.Location = new System.Drawing.Point(420, 66);
            this.txbPhoneNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(148, 22);
            this.txbPhoneNum.TabIndex = 13;
            // 
            // cbGender
            // 
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "PHAI", true));
            this.cbGender.Location = new System.Drawing.Point(116, 106);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Size = new System.Drawing.Size(151, 22);
            this.cbGender.TabIndex = 11;
            // 
            // txbAddress
            // 
            this.txbAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txbAddress.Location = new System.Drawing.Point(689, 70);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(150, 22);
            this.txbAddress.TabIndex = 9;
            // 
            // txbCMND
            // 
            this.txbCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "CMND", true));
            this.txbCMND.Location = new System.Drawing.Point(116, 62);
            this.txbCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(133, 22);
            this.txbCMND.TabIndex = 7;
            // 
            // txbFirstName
            // 
            this.txbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txbFirstName.Location = new System.Drawing.Point(689, 21);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(133, 22);
            this.txbFirstName.TabIndex = 5;
            // 
            // txbLastName
            // 
            this.txbLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.txbLastName.Location = new System.Drawing.Point(420, 25);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(174, 22);
            this.txbLastName.TabIndex = 3;
            // 
            // txbId
            // 
            this.txbId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.txbId.Location = new System.Drawing.Point(116, 21);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(133, 22);
            this.txbId.TabIndex = 1;
            // 
            // bdsGuiRut
            // 
            this.bdsGuiRut.DataMember = "FK_GD_GOIRUT_NhanVien";
            this.bdsGuiRut.DataSource = this.bdsNV;
            // 
            // bdsLayTK
            // 
            this.bdsLayTK.DataMember = "FK_NhanVien_SP_LAYMANVLOGINNAMENV";
            this.bdsLayTK.DataSource = this.bdsNV;
            // 
            // taLayTK
            // 
            this.taLayTK.ClearBeforeFill = true;
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 595);
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.pnCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).EndInit();
            this.pnCN.ResumeLayout(false);
            this.pnCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnInput)).EndInit();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTrangThaiXoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBrandId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhoneNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayTK)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnMoveNV;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS1;
        private DSTableAdapters.NhanVienTableAdapter taNV;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter taChuyenTien;
        private System.Windows.Forms.BindingSource bdsChuyenTien;
        private DevExpress.XtraEditors.PanelControl pnInput;
        private DevExpress.XtraEditors.TextEdit edTrangThaiXoa;
        private DevExpress.XtraEditors.TextEdit txbBrandId;
        private DevExpress.XtraEditors.TextEdit txbPhoneNum;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
        private DevExpress.XtraEditors.TextEdit txbAddress;
        private DevExpress.XtraEditors.TextEdit txbCMND;
        private DevExpress.XtraEditors.TextEdit txbFirstName;
        private DevExpress.XtraEditors.TextEdit txbLastName;
        private DevExpress.XtraEditors.TextEdit txbId;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.PanelControl pnCN;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.GD_GOIRUTTableAdapter taGuiRut;
        private System.Windows.Forms.BindingSource bdsGuiRut;
        private System.Windows.Forms.BindingSource bdsLayTK;
        private DSTableAdapters.SP_LAYMANVLOGINNAMENVTableAdapter taLayTK;
    }
}