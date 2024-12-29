using DevExpress.XtraReports.UI;
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
    public partial class Frpt_ThongKeKhachHang : Form
    {
        public Frpt_ThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Xrpt_ThongKeKhachHang thongke = new Xrpt_ThongKeKhachHang();
                ReportPrintTool printTool = new ReportPrintTool(thongke);
                printTool.ShowPreviewDialog();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
