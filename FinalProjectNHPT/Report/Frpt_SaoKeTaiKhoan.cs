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
    public partial class Frpt_SaoKeTaiKhoan : Form
    {
        private string maCN;
        public Frpt_SaoKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void Frpt_SaoKeTaiKhoan_Load(object sender, EventArgs e)
        {
            layChiNhanhHienTai();
            
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.taTK.Connection.ConnectionString = Program.connectionStr;
            this.taTK.Fill(this.dS.SP_LAYTAIKHOANTHEOCN, maCN);

            dpDateFrom.DateTime = dpDateTo.DateTime = DateTime.Now;
        }

        private void layChiNhanhHienTai()
        {
            string temp = ((DataRowView)Program.bindingSource[SecurityContext.User.BrandIndex])["TENCN"].ToString();
            string[] arr = temp.Split('_');
            maCN = arr[1];
        }

        //Nút "Xem"
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra có tài khoản trong db hay không
                if(bdsTK.Count == 0)
                {
                    MessageBox.Show("Không thể xem báo cáo vì không có tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kiểm ngày bắt đầu và ngày kết thúc có hợp lệ hay không
                if(dpDateFrom.DateTime > dpDateTo.DateTime)
                {
                    MessageBox.Show("Chọn ngày không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string accountId = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();

                //Gửi 3 tham số qua form sao kê là:
                //Số tài khoản, ngày bắt đầu sao kê và ngày kết thúc sao kê
                Xrpt_SaoKeTaiKhoan report = new Xrpt_SaoKeTaiKhoan(accountId, dpDateFrom.DateTime, dpDateTo.DateTime);
                
                //ReportPrintTool cho phép xem trước form trước khi in ra
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tài khoản không có giao dịch từ ngày\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
