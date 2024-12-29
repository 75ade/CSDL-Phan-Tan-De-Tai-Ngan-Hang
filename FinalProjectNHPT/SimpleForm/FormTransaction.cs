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
    public partial class FormTransaction : Form
    {
        public FormTransaction()
        {
            InitializeComponent();
            pnChuyenTien.Enabled = pnGuiRut.Enabled = false;
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {

        }

        private void showTien()
        {
            String cmd = $"SELECT SODU FROM [DBO].[TAIKHOAN] WHERE SOTK = {edTaiKhoanGD.Text}";
            SqlDataReader dataReader = Program.ExecuteSqlDataReader(cmd);
            dataReader.Read();
            // . phân cách giữa các số
            String tien = dataReader.GetValue(0).ToString().Substring(0, dataReader.GetValue(0).ToString().IndexOf(","));
            edSoDuHT.Text = tien;
        }

        private void xacNhanChuyenGDBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSoTaiKhoanNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản nhận");
                edTaiKhoanGD.Focus();
                return;
            }
            if (!Regex.Match(edSoTaiKhoanNhan.Text.ToString(), @"\b\d{9}\b").Success)
                {
                    MessageBox.Show("Số tài khoản nhận phải là dạng kí số và đủ 9 chữ số");
                    edSoTaiKhoanNhan.Text = "";
                    edSoTaiKhoanNhan.Focus();
                    return;
                }
                if (edTaiKhoanGD.Text.ToString().Equals(edSoTaiKhoanNhan.Text.ToString()))
                {
                    MessageBox.Show("Số tài khoản nhận phải khác số tài khoản chuyển");
                    edSoTaiKhoanNhan.Text = "";
                    edSoTaiKhoanNhan.Focus();
                    return;
                }
                if (Program.ExecSqlCheck("SP_KIEMTRASOTK", edSoTaiKhoanNhan.Text.ToString()) == 0)
                {
                        MessageBox.Show("Số tài khoản nhận không tồn tại");
                        edSoTaiKhoanNhan.Text = "";
                        edSoTaiKhoanNhan.Focus();
                        return;
                }
                if (String.IsNullOrEmpty(edSoTienChuyen.Text.ToString()))
                {
                    MessageBox.Show("Số tiền chuyển không được để trống");
                    edSoTienChuyen.Text = "";
                    edSoTienChuyen.Focus();
                    return;
                }

                if (!Regex.Match(edSoTienChuyen.Text.ToString(), @"^\d+$").Success)
                {
                    MessageBox.Show("Số tiền chuyển phải là số");
                    edSoTienChuyen.Text = "";
                    edSoTienChuyen.Focus();
                    return;
                }

                if (Int64.Parse(edSoTienChuyen.Text) < 0)
                    {
                        MessageBox.Show("Số tiền chuyển phải số dương");
                        edSoTienChuyen.Text = "";
                        edSoTienChuyen.Focus();
                        return;
                    }

                if (Int64.Parse(edSoTienChuyen.Text) > Int64.Parse(edSoDuHT.Text))
                {
                    MessageBox.Show("Số tiền chuyển phải nhỏ hơn số tiền hiên tại");
                    edSoTienChuyen.Text = "";
                    edSoTienChuyen.Focus();
                    return;
                }

                try
                {
                    int ktThucthi = Program.ExecuteNonQuery(
                    "EXEC dbo.SP_GIAODICHCHUYENTIEN @SOTK_NHAN , @SOTK_CHUYEN , @SOTIEN , @MANV ", new object[] { edSoTaiKhoanNhan.Text, edTaiKhoanGD.Text.Trim(), edSoTienChuyen.Text, SecurityContext.User.UserName }
                     );

                    if (ktThucthi > 0)
                    {
                        MessageBox.Show("Giao dịch thành công");
                        showTien();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không thể chuyển tiền" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void xacNhanGuiGDBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền ");
                edTaiKhoanGD.Focus();
                return;
            }

            if (!Regex.Match(edSoTien.Text.ToString(), @"^\d+$").Success)
            {
                MessageBox.Show("Số tiền gửi phải là số");
                edSoTien.Text = "";
                edSoTien.Focus();
                return;
            }

            if (Int64.Parse(edSoTien.Text) < 100000)
            {
                MessageBox.Show("Số tiền gửi phải lớn hơn hoặc bằng 100,000");
                edSoTien.Text = "";
                edSoTien.Focus();
                return;
            }

            try
            {
                int ktThucthi = Program.ExecuteNonQuery(
                 "EXEC dbo.SP_GIAODICHGUIRUT  @TYPE , @SOTIEN , @SOTK , @MANV ",
                     new object[] { "GT", edSoTien.Text, edTaiKhoanGD.Text, SecurityContext.User.UserName }
                );

                if (ktThucthi > 0)
                {
                    MessageBox.Show("Giao dịch thành công");
                    showTien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể gửi tiền" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xacNhanRutGDBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền ");
                edTaiKhoanGD.Focus();
                return;
            }

            if (!Regex.Match(edSoTien.Text.ToString(), @"^\d+$").Success)
            {
                MessageBox.Show("Số tiền rút phải là số");
                edSoTien.Text = "";
                edSoTien.Focus();
                return;
            }

            if (Int64.Parse(edSoTien.Text) < 100000)
            {
                MessageBox.Show("Số tiền rút phải lớn hơn hoặc bằng 100000");
                edSoTien.Text = "";
                edSoTien.Focus();
                return;
            }
            if (Int64.Parse(edSoTien.Text) > Int64.Parse(edSoDuHT.Text))
            {
                MessageBox.Show("Số tiền rút phải bé hơn số tiền hiện tại");
                edSoTien.Text = "";
                edSoTien.Focus();
                return;
            }

            try
            {
                int ktThucthi = Program.ExecuteNonQuery(
                 "EXEC dbo.SP_GIAODICHGUIRUT @TYPE , @SOTIEN , @SOTK , @MANV ",
                     new object[] { "RT", edSoTien.Text, edTaiKhoanGD.Text, SecurityContext.User.UserName }
                );

                if (ktThucthi > 0)
                {
                    MessageBox.Show("Giao dịch thành công");
                    showTien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể rút tiền" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kiemTraBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTaiKhoanGD.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản ");
                edTaiKhoanGD.Focus();
                return;
            }

            if (Regex.IsMatch(edTaiKhoanGD.Text, @"\b\d{9}\b") == false)
            {
                MessageBox.Show("Số tài khoản phải là dạng kí số và đủ 9 chữ số");
                edTaiKhoanGD.Text = "";
                edTaiKhoanGD.Focus();
                return;
            }
            else
            {
                if (Program.ExecSqlCheck("SP_KIEMTRASOTK", edTaiKhoanGD.Text) == 0)
                {
                    MessageBox.Show("Số tài khoản không tồn tại, hãy thử lại");
                    edTaiKhoanGD.Text = "";
                    edTaiKhoanGD.Focus();
                    return;
                }
                // nếu tồn tại stk trong bảng thì hiển thị số dư 
                showTien();
                pnChuyenTien.Enabled = pnGuiRut.Enabled = true;
            }
        }
    }
}
