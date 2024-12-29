using System;
using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Util;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace FinalProjectNHPT.Report
{
    public partial class Frpt_ThongKeTaiKhoanMo : Form
    {
        public Frpt_ThongKeTaiKhoanMo()
        {
            InitializeComponent();
        }

        private void Frpt_ThongKeTaiKhoanMo_Load(object sender, EventArgs e)
        {
            cbBrand.DataSource = Program.bindingSource;//sao chep bingding source tu form dang nhap de tai chi nhanh len
            cbBrand.DisplayMember = "TENCN";
            cbBrand.ValueMember = "TENSERVER";
            cbBrand.SelectedIndex = SecurityContext.User.BrandIndex;

            dpDateFrom.DateTime = dpDateTo.DateTime = DateTime.Now;
            rbtChooseBrand.Checked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // ngày bắt đầu không được sau ngày kết thúc
                if (dpDateFrom.DateTime > dpDateTo.DateTime)
                {
                    MessageBox.Show("Ngày bắt đầu không được sau ngày kết thúc");
                    return;
                }

                string MACN;
                if (cbBrand.Text.Equals("NGANHANG_BENTHANH"))
                    MACN = "BENTHANH";
                else
                    MACN = "TANDINH";


                if (rbtChooseBrand.Checked)
                {
                    Xrpt_ThongKeTaiKhoanMoTheoCN report = new Xrpt_ThongKeTaiKhoanMoTheoCN(dpDateFrom.DateTime, dpDateTo.DateTime, MACN);
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();
                }
                else
                {
                    Xrpt_ThongKeTaiKhoanMoTatCaCN report = new Xrpt_ThongKeTaiKhoanMoTatCaCN(dpDateFrom.DateTime, dpDateTo.DateTime);
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void cbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Nếu combobox chi nhánh chưa load danh sách phân mảnh thì thoát
            if (cbBrand.SelectedValue.ToString().Equals("System.Data.RowView"))
                return;
            string serverName = cbBrand.SelectedValue.ToString();
            User user = SecurityContext.User;
            if (cbBrand.SelectedIndex != user.BrandIndex) // kết nối đến site phân mảnh
                Program.setServerToRemote(serverName);
            else
                Program.setServerSubscriber(serverName, user.LoginName, user.Password);
            if (Program.checkConnection() == false)
            {
                MessageBox.Show("Lỗi kết nối sang chi nhánh mới.");
                return;
            }
        }

        private void rbtChooseBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtChooseBrand.Checked)
            {
                cbBrand.Enabled = true;
            }
            else
            {
                cbBrand.Enabled = false;
            }
        }
    }
}
