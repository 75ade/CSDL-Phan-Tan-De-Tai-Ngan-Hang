using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace FinalProjectNHPT.Report
{
    public partial class Xrpt_ThongKeTaiKhoanMoTheoCN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ThongKeTaiKhoanMoTheoCN()
        {
            InitializeComponent();
        }

        public Xrpt_ThongKeTaiKhoanMoTheoCN(DateTime dateFrom, DateTime dateTo, string brandName)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectionStr;
            var query = this.sqlDataSource1.Queries[0];
            query.Parameters[0].Value = dateFrom.Date.ToString("yyyy-MM-dd");
            query.Parameters[1].Value = dateTo.Date.ToString("yyyy-MM-dd");
            query.Parameters[2].Value = brandName;
            // dùng fill để tải về theo đường kết nối 
            this.sqlDataSource1.Fill();

            lbBrandName.Text = brandName;
            lbDate.Text = dateFrom.Date.ToString("d") + " - " + dateTo.Date.ToString("d");
        }
    }
}
