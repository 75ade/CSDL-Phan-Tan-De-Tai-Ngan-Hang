using FinalProjectNHPT.DTO;
using FinalProjectNHPT.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectNHPT.SimpleForm
{
    public partial class FormLogin : Form
    {
        private Action changeUserInfo;

        public Action ChangeUserInfo { get => changeUserInfo; set => changeUserInfo = value; }

        private SqlConnection conn = new SqlConnection();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {
            //Khi load form thi se mo ket noi
            if (ketNoiDB() == 0)
                return;

            //Lay ten chi nhanh do vao combobox
            //uv_GetSubscribers là view trong database
            layDanhSachTenChiNhanh("SELECT * FROM uv_GetSubcribers");
        }

        //Module thực hiện chức năng mở kết nối đến site chủ (CSDL gốc)
        private int ketNoiDB()
        {
            if (conn.State == ConnectionState.Open && conn != null)
                conn.Close();
            try
            {
                //Thiết lập connection string đến site chủ = Publisher
                conn.ConnectionString = Program.connstrPublisher;
                conn.Open();
                return 1;   //Tra ve 1 neu mo ket noi thanh cong
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;   //Tra ve 0 neu mo ket noi khong thanh cong
            }
        }

        //Module thực hiện chức năng lấy tên của các chi nhánh và bỏ vào combobox
        private void layDanhSachTenChiNhanh(String command)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command, conn);
            da.Fill(dt);

            conn.Close();

            Program.bindingSource.DataSource = dt;
            comboBoxServer.DataSource = Program.bindingSource;
            comboBoxServer.DisplayMember = "TENCN";
            comboBoxServer.ValueMember = "TENSERVER";

            DataRowView currentRow = (DataRowView)Program.bindingSource.Current;
            Console.WriteLine(currentRow["TENSERVER"]);

            Program.bindingSource.MoveNext();
            currentRow = (DataRowView)Program.bindingSource.Current;
            Console.WriteLine(currentRow["TENSERVER"]);
        }

        private void buttonExitNV_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLoginNV_Click_1(object sender, EventArgs e)
        {
            string loginName = textBoxUsernameNV.Text.Trim();
            if (string.IsNullOrEmpty(loginName))
            {
                MessageBox.Show("Username không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = textBoxPasswordNV.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string serverName = comboBoxServer.SelectedValue.ToString();
            Console.WriteLine("This is the name of the current server: " + serverName);
            Program.serverName = serverName;
            Program.setServerSubscriber(serverName, loginName, password);

            if (Program.checkConnection() == false)
            {
                MessageBox.Show("Không thể kết nối đến site phân mảnh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.MACNHT = Program.layChiNhanhHienTai().Trim();
            User user = Program.login(loginName);

            if (user != null)
            {
                user.LoginName = loginName;
                user.Password = password;
                user.BrandIndex = comboBoxServer.SelectedIndex;
                SecurityContext.User = user;    //Lưu thông tin vào 1 object tạm thời
                MessageBox.Show("Đăng nhập thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeUserInfo.Invoke();
                Close();
            }
            else
            {
                MessageBox.Show("Tài khoản login không tồn tại trong hệ thống hoặc nếu có thì không có quyền truy cập vào database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
