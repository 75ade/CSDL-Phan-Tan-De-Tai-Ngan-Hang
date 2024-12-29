using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinalProjectNHPT.Report
{
    public partial class Xrpt_SaoKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SaoKeTaiKhoan()
        {

        }

        public Xrpt_SaoKeTaiKhoan(string accountId, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectionStr;

            /*Console.WriteLine("Error report form 0");*/

            /*var query = this.sqlDataSource1.Queries[0];*/

            this.sqlDataSource1.Queries[0].Parameters[0].Value = accountId;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateFrom;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = dateTo;

/*            query.Parameters[0].Value = accountId;
            query.Parameters[1].Value = dateFrom;
            query.Parameters[2].Value = dateTo;*/

            /*Console.WriteLine("Error report form 1");*/

            this.sqlDataSource1.Fill();


            //Lấy số dư cuối cùng để thêm vào hàng cuối
            ITable src = (ITable)sqlDataSource1.Result["SP_SAOKETAIKHOAN"];

            DataTable table = new DataTable("SP_SAOKETAIKHOAN");

            foreach (IColumn column in src.Columns)
                table.Columns.Add(column.Name, column.Type);
            foreach (IRow row in src)
                table.Rows.Add(row.ToArray());

            DataRow lastRow = table.Rows[table.Rows.Count - 1];
            //-------------------------------------------------------------//

            lbAccountId.Text = accountId;
            lbDate.Text = dateFrom.Date.ToString("dd/MM/yyyy") + " - " + dateTo.Date.ToString("dd/MM/yyyy");
            lbEndDate.Text = dateTo.Date.ToString("dd/MM/yyyy") + ": ";
            try
            {
                lbSoDuKetThuc.Text = double.Parse(lastRow["SODUSAU"].ToString()).ToString("N0") + "đ";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
