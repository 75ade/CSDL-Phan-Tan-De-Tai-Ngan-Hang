
namespace FinalProjectNHPT.Report
{
    partial class Frpt_ThongKeTaiKhoanMo
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.dpDateTo = new DevExpress.XtraEditors.DateEdit();
            this.dpDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtBrandAll = new System.Windows.Forms.RadioButton();
            this.rbtChooseBrand = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dpDateTo
            // 
            this.dpDateTo.EditValue = "18-04-24";
            this.dpDateTo.Location = new System.Drawing.Point(446, 247);
            this.dpDateTo.Name = "dpDateTo";
            this.dpDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateTo.Size = new System.Drawing.Size(150, 28);
            this.dpDateTo.TabIndex = 46;
            // 
            // dpDateFrom
            // 
            this.dpDateFrom.EditValue = "18-04-24";
            this.dpDateFrom.Location = new System.Drawing.Point(223, 247);
            this.dpDateFrom.Name = "dpDateFrom";
            this.dpDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpDateFrom.Size = new System.Drawing.Size(150, 28);
            this.dpDateFrom.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(77, 244);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 30);
            label3.TabIndex = 42;
            label3.Text = "Thời gian:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(399, 255);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(14, 20);
            label4.TabIndex = 43;
            label4.Text = "-";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(651, 238);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 46);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Xem";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(223, 167);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(4);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(502, 36);
            this.cbBrand.TabIndex = 41;
            this.cbBrand.SelectionChangeCommitted += new System.EventHandler(this.cbBrand_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "Chi nhánh:";
            // 
            // rbtBrandAll
            // 
            this.rbtBrandAll.AutoSize = true;
            this.rbtBrandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtBrandAll.Location = new System.Drawing.Point(510, 86);
            this.rbtBrandAll.Name = "rbtBrandAll";
            this.rbtBrandAll.Size = new System.Drawing.Size(227, 29);
            this.rbtBrandAll.TabIndex = 39;
            this.rbtBrandAll.TabStop = true;
            this.rbtBrandAll.Text = "Chọn tất cả chi nhánh";
            this.rbtBrandAll.UseVisualStyleBackColor = true;
            // 
            // rbtChooseBrand
            // 
            this.rbtChooseBrand.AutoSize = true;
            this.rbtChooseBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtChooseBrand.Location = new System.Drawing.Point(82, 86);
            this.rbtChooseBrand.Name = "rbtChooseBrand";
            this.rbtChooseBrand.Size = new System.Drawing.Size(218, 29);
            this.rbtChooseBrand.TabIndex = 38;
            this.rbtChooseBrand.TabStop = true;
            this.rbtChooseBrand.Text = "Chọn theo chi nhánh";
            this.rbtChooseBrand.UseVisualStyleBackColor = true;
            this.rbtChooseBrand.CheckedChanged += new System.EventHandler(this.rbtChooseBrand_CheckedChanged);
            // 
            // Frpt_ThongKeTaiKhoanMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 405);
            this.Controls.Add(this.dpDateTo);
            this.Controls.Add(this.dpDateFrom);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtBrandAll);
            this.Controls.Add(this.rbtChooseBrand);
            this.Name = "Frpt_ThongKeTaiKhoanMo";
            this.Text = "Frpt_ThongKeTaiKhoanMo";
            this.Load += new System.EventHandler(this.Frpt_ThongKeTaiKhoanMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpDateFrom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dpDateTo;
        private DevExpress.XtraEditors.DateEdit dpDateFrom;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtBrandAll;
        private System.Windows.Forms.RadioButton rbtChooseBrand;
    }
}