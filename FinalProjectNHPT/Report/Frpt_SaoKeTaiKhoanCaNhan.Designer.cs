
namespace FinalProjectNHPT.Report
{
    partial class Frpt_SaoKeTaiKhoanCaNhan
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
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new FinalProjectNHPT.DS();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.taTK = new FinalProjectNHPT.DSTableAdapters.SP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDTableAdapter();
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dpDateTo = new DevExpress.XtraEditors.DateEdit();
            this.dpDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "SP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMND";
            this.bdsTK.DataSource = this.dS;
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
            // taTK
            // 
            this.taTK.ClearBeforeFill = true;
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.dS;
            this.dSBindingSource.Position = 0;
            // 
            // sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl
            // 
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.DataSource = this.bdsTK;
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.MainView = this.gridView1;
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.Name = "sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl";
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.Size = new System.Drawing.Size(1250, 298);
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.TabIndex = 1;
            this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl;
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
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSubmit);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.dpDateTo);
            this.groupControl2.Controls.Add(this.dpDateFrom);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 298);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1250, 400);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Nhập thông tin báo cáo sao kê";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(622, 124);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(168, 58);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Xem";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // dpDateTo
            // 
            this.dpDateTo.EditValue = null;
            this.dpDateTo.Location = new System.Drawing.Point(418, 139);
            this.dpDateTo.Name = "dpDateTo";
            this.dpDateTo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDateTo.Properties.Appearance.Options.UseFont = true;
            this.dpDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateTo.Size = new System.Drawing.Size(125, 28);
            this.dpDateTo.TabIndex = 7;
            // 
            // dpDateFrom
            // 
            this.dpDateFrom.EditValue = null;
            this.dpDateFrom.Location = new System.Drawing.Point(202, 139);
            this.dpDateFrom.Name = "dpDateFrom";
            this.dpDateFrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDateFrom.Properties.Appearance.Options.UseFont = true;
            this.dpDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateFrom.Size = new System.Drawing.Size(125, 28);
            this.dpDateFrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thời gian";
            // 
            // Frpt_SaoKeTaiKhoanCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 698);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl);
            this.Name = "Frpt_SaoKeTaiKhoanCaNhan";
            this.Text = "Frpt_SaoKeTaiKhoanCaNhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frpt_SaoKeTaiKhoanCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.SP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDTableAdapter taTK;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private DevExpress.XtraGrid.GridControl sP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMNDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dpDateTo;
        private DevExpress.XtraEditors.DateEdit dpDateFrom;
        private System.Windows.Forms.Label label4;
    }
}