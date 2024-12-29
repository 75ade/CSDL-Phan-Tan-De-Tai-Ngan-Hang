
namespace FinalProjectNHPT.SubForm
{
    partial class FormChuyenNV
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
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label pHAILabel;
            this.dS = new FinalProjectNHPT.DS();
            this.bdsLayDSChiNhanhKhac = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LAYDSCHINHANHKHACTableAdapter = new FinalProjectNHPT.DSTableAdapters.SP_LAYDSCHINHANHKHACTableAdapter();
            this.tableAdapterManager = new FinalProjectNHPT.DSTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sP_LAYDSCHINHANHKHACGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMove = new System.Windows.Forms.Button();
            this.txbId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new FinalProjectNHPT.DSTableAdapters.NhanVienTableAdapter();
            this.txbPhoneNum = new DevExpress.XtraEditors.TextEdit();
            this.txbAddress = new DevExpress.XtraEditors.TextEdit();
            this.txbFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txbLastName = new DevExpress.XtraEditors.TextEdit();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            cMNDLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDSChiNhanhKhac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDSCHINHANHKHACGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhoneNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(215, 127);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(71, 24);
            cMNDLabel.TabIndex = 3;
            cMNDLabel.Text = "CMND:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLayDSChiNhanhKhac
            // 
            this.bdsLayDSChiNhanhKhac.DataMember = "SP_LAYDSCHINHANHKHAC";
            this.bdsLayDSChiNhanhKhac.DataSource = this.dS;
            // 
            // SP_LAYDSCHINHANHKHACTableAdapter
            // 
            this.SP_LAYDSCHINHANHKHACTableAdapter.ClearBeforeFill = true;
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
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1230, 80);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chọn chi nhánh cần chuyển nhân viên: ";
            // 
            // sP_LAYDSCHINHANHKHACGridControl
            // 
            this.sP_LAYDSCHINHANHKHACGridControl.DataSource = this.bdsLayDSChiNhanhKhac;
            this.sP_LAYDSCHINHANHKHACGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LAYDSCHINHANHKHACGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sP_LAYDSCHINHANHKHACGridControl.Location = new System.Drawing.Point(0, 80);
            this.sP_LAYDSCHINHANHKHACGridControl.MainView = this.gridView1;
            this.sP_LAYDSCHINHANHKHACGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sP_LAYDSCHINHANHKHACGridControl.Name = "sP_LAYDSCHINHANHKHACGridControl";
            this.sP_LAYDSCHINHANHKHACGridControl.Size = new System.Drawing.Size(1230, 176);
            this.sP_LAYDSCHINHANHKHACGridControl.TabIndex = 2;
            this.sP_LAYDSCHINHANHKHACGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 280;
            this.gridView1.GridControl = this.sP_LAYDSCHINHANHKHACGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(pHAILabel);
            this.groupControl2.Controls.Add(this.cbGender);
            this.groupControl2.Controls.Add(sODTLabel);
            this.groupControl2.Controls.Add(this.txbPhoneNum);
            this.groupControl2.Controls.Add(dIACHILabel);
            this.groupControl2.Controls.Add(this.txbAddress);
            this.groupControl2.Controls.Add(tENLabel);
            this.groupControl2.Controls.Add(this.txbFirstName);
            this.groupControl2.Controls.Add(hOLabel);
            this.groupControl2.Controls.Add(this.txbLastName);
            this.groupControl2.Controls.Add(cMNDLabel);
            this.groupControl2.Controls.Add(this.txbCMND);
            this.groupControl2.Controls.Add(this.btnMove);
            this.groupControl2.Controls.Add(this.txbId);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 256);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1230, 350);
            this.groupControl2.TabIndex = 4;
            // 
            // txbCMND
            // 
            this.txbCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "CMND", true));
            this.txbCMND.Enabled = false;
            this.txbCMND.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCMND.Location = new System.Drawing.Point(314, 119);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(181, 32);
            this.txbCMND.TabIndex = 4;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dS;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(557, 282);
            this.btnMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(100, 41);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Chuyển";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click_1);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(314, 66);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbId.Name = "txbId";
            this.txbId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Properties.Appearance.Options.UseFont = true;
            this.txbId.Size = new System.Drawing.Size(181, 30);
            this.txbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(111, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên mới:";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(152, 188);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(134, 24);
            sODTLabel.TabIndex = 20;
            sODTLabel.Text = "Số điện thoại:";
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Enabled = false;
            this.txbPhoneNum.Location = new System.Drawing.Point(314, 185);
            this.txbPhoneNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNum.Properties.Appearance.Options.UseFont = true;
            this.txbPhoneNum.Size = new System.Drawing.Size(181, 30);
            this.txbPhoneNum.TabIndex = 21;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(533, 188);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(84, 24);
            dIACHILabel.TabIndex = 18;
            dIACHILabel.Text = "Địa chỉ: ";
            // 
            // txbAddress
            // 
            this.txbAddress.Enabled = false;
            this.txbAddress.Location = new System.Drawing.Point(623, 182);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Properties.Appearance.Options.UseFont = true;
            this.txbAddress.Size = new System.Drawing.Size(427, 30);
            this.txbAddress.TabIndex = 19;
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(859, 116);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(51, 24);
            tENLabel.TabIndex = 16;
            tENLabel.Text = "Tên:";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Enabled = false;
            this.txbFirstName.Location = new System.Drawing.Point(917, 113);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.Properties.Appearance.Options.UseFont = true;
            this.txbFirstName.Size = new System.Drawing.Size(133, 30);
            this.txbFirstName.TabIndex = 17;
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(575, 124);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(42, 24);
            hOLabel.TabIndex = 14;
            hOLabel.Text = "Họ:";
            // 
            // txbLastName
            // 
            this.txbLastName.Enabled = false;
            this.txbLastName.Location = new System.Drawing.Point(623, 119);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLastName.Properties.Appearance.Options.UseFont = true;
            this.txbLastName.Size = new System.Drawing.Size(174, 30);
            this.txbLastName.TabIndex = 15;
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(195, 260);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(91, 24);
            pHAILabel.TabIndex = 22;
            pHAILabel.Text = "Giới tính:";
            // 
            // cbGender
            // 
            this.cbGender.Enabled = false;
            this.cbGender.Location = new System.Drawing.Point(314, 254);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.Properties.Appearance.Options.UseFont = true;
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Size = new System.Drawing.Size(181, 30);
            this.cbGender.TabIndex = 23;
            // 
            // FormChuyenNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 606);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.sP_LAYDSCHINHANHKHACGridControl);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChuyenNV";
            this.Text = "FormChuyenNV";
            this.Load += new System.EventHandler(this.FormChuyenNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDSChiNhanhKhac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDSCHINHANHKHACGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhoneNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsLayDSChiNhanhKhac;
        private DSTableAdapters.SP_LAYDSCHINHANHKHACTableAdapter SP_LAYDSCHINHANHKHACTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl sP_LAYDSCHINHANHKHACGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnMove;
        private DevExpress.XtraEditors.TextEdit txbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.TextBox txbCMND;
        private DevExpress.XtraEditors.TextEdit txbPhoneNum;
        private DevExpress.XtraEditors.TextEdit txbAddress;
        private DevExpress.XtraEditors.TextEdit txbFirstName;
        private DevExpress.XtraEditors.TextEdit txbLastName;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
    }
}