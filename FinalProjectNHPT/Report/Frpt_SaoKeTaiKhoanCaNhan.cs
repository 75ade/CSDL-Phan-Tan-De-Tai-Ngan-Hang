using DevExpress.XtraReports.UI;
using FinalProjectNHPT.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectNHPT.Report
{
    public partial class Frpt_SaoKeTaiKhoanCaNhan : Form
    {
        public Frpt_SaoKeTaiKhoanCaNhan()
        {
            InitializeComponent();
        }

        private void Frpt_SaoKeTaiKhoanCaNhan_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.taTK.Connection.ConnectionString = Program.connectionStr;
            this.taTK.Fill(this.dS.SP_LAYTAIKHOANNGANHANG2CHINHANHTHEOCMND, SecurityContext.User.UserName);

            dpDateFrom.DateTime = dpDateTo.DateTime = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra có tài khoản trong db hay không
                if (bdsTK.Count == 0)
                {
                    MessageBox.Show("Không thể xem báo cáo vì không có tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kiểm ngày bắt đầu và ngày kết thúc có hợp lệ hay không
                if (dpDateFrom.DateTime > dpDateTo.DateTime)
                {
                    MessageBox.Show("Chọn ngày không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Console.WriteLine("Error 0");
                string accountId = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString().Trim();
                Console.WriteLine(accountId);

                Xrpt_SaoKeTaiKhoan report = new Xrpt_SaoKeTaiKhoan(accountId, dpDateFrom.DateTime, dpDateTo.DateTime);
                Console.WriteLine("Error 1");
                ReportPrintTool printTool = new ReportPrintTool(report);
                Console.WriteLine("Error 2");
                printTool.ShowPreviewDialog();
                Console.WriteLine("Error 3");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản không có giao dịch \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
