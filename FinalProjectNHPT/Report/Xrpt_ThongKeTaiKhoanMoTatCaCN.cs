using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace FinalProjectNHPT.Report
{
    public partial class Xrpt_ThongKeTaiKhoanMoTatCaCN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ThongKeTaiKhoanMoTatCaCN()
        {
            InitializeComponent();
        }

        public Xrpt_ThongKeTaiKhoanMoTatCaCN(DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectionStr;
            var query = this.sqlDataSource1.Queries[0];
            query.Parameters[0].Value = dateFrom.Date.ToString("yyyy-MM-dd");
            query.Parameters[1].Value = dateTo.Date.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Fill();

            lbDate.Text = dateFrom.Date.ToString("d") + " - " + dateTo.Date.ToString("d");
        }
    }
}
