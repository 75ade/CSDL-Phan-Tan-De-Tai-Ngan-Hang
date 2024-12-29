using FinalProjectNHPT.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectNHPT.SimpleForm
{
    public partial class FormNhapCMND : Form
    {
        private string maCN;
        public FormNhapCMND()
        {

        }

        public FormNhapCMND(string maCN)
        {
            InitializeComponent();
            this.maCN = maCN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CMND = txbCMND.Text.Trim();

            //Kiểm tra CMND có rỗng hay không
            if (string.IsNullOrEmpty(CMND))
            {
                MessageBox.Show("Mã khách hàng (CMND) không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCMND.Focus();
                return;
            }

            //Kiểm tra CMND có hợp lệ hay không
            if (CMND.Contains(" ") || !Regex.Match(CMND, @"\b\d{10}\b").Success)
            {
                MessageBox.Show("Mã khách hàng (CMND) không hợp lệ hoặc chưa đủ 10 chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCMND.Focus();
                return;
            }

   
            string query = $"EXEC SP_KIEMTRATKTHEOCMND '{CMND}'";
            SqlDataReader myReader = Program.ExecuteSqlDataReader(query);
            
            //Không tìm thấy CMND của khách hàng trong bất kỳ chi nhánh nào
            if (myReader == null)
            {
                return;
            }
            //Tìm thấy CMND của khách hàng
            else
            {
                Form form = ControlUtil.checkFormExists(this, typeof(FormAccount));
                if (form != null)
                    form.Activate();
                else
                {
                    FormAccount f = new FormAccount(CMND, maCN)
                    {

                    };
                    f.Show();
                }
                Close();
            }

        }

        private void FormNhapCMND_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Reach");
        }
    }
}
