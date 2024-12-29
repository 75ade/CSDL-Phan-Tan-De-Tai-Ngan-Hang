
namespace FinalProjectNHPT.SimpleForm
{
    partial class FormCreateBankAccount
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateBankAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new FinalProjectNHPT.DS();
            this.taKH = new FinalProjectNHPT.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.pnCN = new DevExpress.XtraEditors.PanelControl();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnKH = new System.Windows.Forms.Panel();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pHAITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYCAPDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.sODTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mACNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.taiKhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.sOTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYMOTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taTK = new FinalProjectNHPT.DSTableAdapters.SP_LAYTAIKHOANTHEOCNTableAdapter();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).BeginInit();
            this.pnCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHAITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(389, 89);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(52, 17);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(29, 39);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(21, 82);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(37, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(12, 242);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(55, 17);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(19, 135);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(40, 17);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "Phái:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(324, 139);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(116, 17);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "Ngày cấp CMND:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(17, 192);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(40, 17);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SĐT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(345, 192);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(97, 17);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "Mã chi nhánh:";
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
            this.btnReload,
            this.btnExit,
            this.btnRedo,
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
            this.bar2.FloatLocation = new System.Drawing.Point(425, 617);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem tài khoản theo CMND";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1483, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 795);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1483, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 765);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1483, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 765);
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
            // pnCN
            // 
            this.pnCN.Controls.Add(this.cbBrand);
            this.pnCN.Controls.Add(this.label1);
            this.pnCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCN.Location = new System.Drawing.Point(0, 30);
            this.pnCN.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnCN.Name = "pnCN";
            this.pnCN.Size = new System.Drawing.Size(1483, 100);
            this.pnCN.TabIndex = 7;
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(329, 34);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(1523, 31);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.SelectionChangeCommitted += new System.EventHandler(this.cbBrand_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bdsKH;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khachHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khachHangGridControl.Location = new System.Drawing.Point(0, 130);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1483, 251);
            this.khachHangGridControl.TabIndex = 7;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.AppearanceHeader.Options.UseTextOptions = true;
            this.colCMND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCMND.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 31;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 117;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 31;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 117;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 31;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 117;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHAI.Caption = "Giới tính";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 31;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 117;
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
            this.colNGAYCAP.MinWidth = 31;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 117;
            // 
            // colSODT
            // 
            this.colSODT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSODT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSODT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 31;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 117;
            // 
            // colMACN
            // 
            this.colMACN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMACN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMACN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 31;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 117;
            // 
            // pnKH
            // 
            this.pnKH.Controls.Add(cMNDLabel);
            this.pnKH.Controls.Add(this.cMNDTextEdit);
            this.pnKH.Controls.Add(hOLabel);
            this.pnKH.Controls.Add(this.hOTextEdit);
            this.pnKH.Controls.Add(tENLabel);
            this.pnKH.Controls.Add(this.tENTextEdit);
            this.pnKH.Controls.Add(dIACHILabel);
            this.pnKH.Controls.Add(this.dIACHITextEdit);
            this.pnKH.Controls.Add(pHAILabel);
            this.pnKH.Controls.Add(this.pHAITextEdit);
            this.pnKH.Controls.Add(nGAYCAPLabel);
            this.pnKH.Controls.Add(this.nGAYCAPDateEdit);
            this.pnKH.Controls.Add(sODTLabel);
            this.pnKH.Controls.Add(this.sODTTextEdit);
            this.pnKH.Controls.Add(mACNLabel);
            this.pnKH.Controls.Add(this.mACNTextEdit);
            this.pnKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnKH.Enabled = false;
            this.pnKH.Location = new System.Drawing.Point(0, 381);
            this.pnKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnKH.Name = "pnKH";
            this.pnKH.Size = new System.Drawing.Size(701, 414);
            this.pnKH.TabIndex = 8;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(451, 80);
            this.cMNDTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cMNDTextEdit.MenuManager = this.barManager1;
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Size = new System.Drawing.Size(205, 22);
            this.cMNDTextEdit.TabIndex = 1;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(79, 37);
            this.hOTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hOTextEdit.MenuManager = this.barManager1;
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Size = new System.Drawing.Size(576, 22);
            this.hOTextEdit.TabIndex = 3;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(79, 80);
            this.tENTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tENTextEdit.MenuManager = this.barManager1;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Size = new System.Drawing.Size(217, 22);
            this.tENTextEdit.TabIndex = 5;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(79, 239);
            this.dIACHITextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dIACHITextEdit.MenuManager = this.barManager1;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(576, 22);
            this.dIACHITextEdit.TabIndex = 7;
            // 
            // pHAITextEdit
            // 
            this.pHAITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "PHAI", true));
            this.pHAITextEdit.Location = new System.Drawing.Point(79, 130);
            this.pHAITextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHAITextEdit.MenuManager = this.barManager1;
            this.pHAITextEdit.Name = "pHAITextEdit";
            this.pHAITextEdit.Size = new System.Drawing.Size(217, 22);
            this.pHAITextEdit.TabIndex = 9;
            // 
            // nGAYCAPDateEdit
            // 
            this.nGAYCAPDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "NGAYCAP", true));
            this.nGAYCAPDateEdit.EditValue = null;
            this.nGAYCAPDateEdit.Location = new System.Drawing.Point(451, 132);
            this.nGAYCAPDateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nGAYCAPDateEdit.MenuManager = this.barManager1;
            this.nGAYCAPDateEdit.Name = "nGAYCAPDateEdit";
            this.nGAYCAPDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYCAPDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYCAPDateEdit.Size = new System.Drawing.Size(205, 22);
            this.nGAYCAPDateEdit.TabIndex = 11;
            // 
            // sODTTextEdit
            // 
            this.sODTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "SODT", true));
            this.sODTTextEdit.Location = new System.Drawing.Point(79, 183);
            this.sODTTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sODTTextEdit.MenuManager = this.barManager1;
            this.sODTTextEdit.Name = "sODTTextEdit";
            this.sODTTextEdit.Size = new System.Drawing.Size(217, 22);
            this.sODTTextEdit.TabIndex = 13;
            // 
            // mACNTextEdit
            // 
            this.mACNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "MACN", true));
            this.mACNTextEdit.Location = new System.Drawing.Point(451, 183);
            this.mACNTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mACNTextEdit.MenuManager = this.barManager1;
            this.mACNTextEdit.Name = "mACNTextEdit";
            this.mACNTextEdit.Size = new System.Drawing.Size(205, 22);
            this.mACNTextEdit.TabIndex = 15;
            // 
            // taiKhoanDataGridView
            // 
            this.taiKhoanDataGridView.AllowUserToAddRows = false;
            this.taiKhoanDataGridView.AllowUserToDeleteRows = false;
            this.taiKhoanDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.taiKhoanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taiKhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taiKhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOTKDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.sODUDataGridViewTextBoxColumn,
            this.mACNDataGridViewTextBoxColumn,
            this.nGAYMOTKDataGridViewTextBoxColumn});
            this.taiKhoanDataGridView.DataSource = this.bdsTK;
            this.taiKhoanDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanDataGridView.Location = new System.Drawing.Point(701, 381);
            this.taiKhoanDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanDataGridView.Name = "taiKhoanDataGridView";
            this.taiKhoanDataGridView.ReadOnly = true;
            this.taiKhoanDataGridView.RowHeadersWidth = 51;
            this.taiKhoanDataGridView.RowTemplate.Height = 24;
            this.taiKhoanDataGridView.Size = new System.Drawing.Size(782, 414);
            this.taiKhoanDataGridView.TabIndex = 8;
            // 
            // sOTKDataGridViewTextBoxColumn
            // 
            this.sOTKDataGridViewTextBoxColumn.DataPropertyName = "SOTK";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sOTKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sOTKDataGridViewTextBoxColumn.HeaderText = "Số tài khoản";
            this.sOTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOTKDataGridViewTextBoxColumn.Name = "sOTKDataGridViewTextBoxColumn";
            this.sOTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cMNDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMNDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sODUDataGridViewTextBoxColumn
            // 
            this.sODUDataGridViewTextBoxColumn.DataPropertyName = "SODU";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.sODUDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sODUDataGridViewTextBoxColumn.HeaderText = "Số dư";
            this.sODUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sODUDataGridViewTextBoxColumn.Name = "sODUDataGridViewTextBoxColumn";
            this.sODUDataGridViewTextBoxColumn.ReadOnly = true;
            this.sODUDataGridViewTextBoxColumn.Width = 125;
            // 
            // mACNDataGridViewTextBoxColumn
            // 
            this.mACNDataGridViewTextBoxColumn.DataPropertyName = "MACN";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mACNDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.mACNDataGridViewTextBoxColumn.HeaderText = "Mã chi nhánh";
            this.mACNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mACNDataGridViewTextBoxColumn.Name = "mACNDataGridViewTextBoxColumn";
            this.mACNDataGridViewTextBoxColumn.ReadOnly = true;
            this.mACNDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYMOTKDataGridViewTextBoxColumn
            // 
            this.nGAYMOTKDataGridViewTextBoxColumn.DataPropertyName = "NGAYMOTK";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nGAYMOTKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.nGAYMOTKDataGridViewTextBoxColumn.HeaderText = "Ngày mở tài khoản";
            this.nGAYMOTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYMOTKDataGridViewTextBoxColumn.Name = "nGAYMOTKDataGridViewTextBoxColumn";
            this.nGAYMOTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.nGAYMOTKDataGridViewTextBoxColumn.Width = 160;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_KhachHang_SP_LAYTAIKHOANTHEOCN";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // taTK
            // 
            this.taTK.ClearBeforeFill = true;
            // 
            // FormCreateBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 815);
            this.Controls.Add(this.taiKhoanDataGridView);
            this.Controls.Add(this.pnKH);
            this.Controls.Add(this.khachHangGridControl);
            this.Controls.Add(this.pnCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCreateBankAccount";
            this.Text = "FormCreateBankAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCreateBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCN)).EndInit();
            this.pnCN.ResumeLayout(false);
            this.pnCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnKH.ResumeLayout(false);
            this.pnKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHAITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KhachHangTableAdapter taKH;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private System.Windows.Forms.DataGridView taiKhoanDataGridView;
        private System.Windows.Forms.Panel pnKH;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit pHAITextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYCAPDateEdit;
        private DevExpress.XtraEditors.TextEdit sODTTextEdit;
        private DevExpress.XtraEditors.TextEdit mACNTextEdit;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.PanelControl pnCN;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.SP_LAYTAIKHOANTHEOCNTableAdapter taTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYMOTKDataGridViewTextBoxColumn;
    }
}