using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using FinalProjectNHPT.DTO;
using FinalProjectNHPT.SimpleForm;

namespace FinalProjectNHPT
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static string serverName = "";
        public static string connectionStr;
        public static string MACNHT;
        public static FormMain frmChinh;

        public static string DISTRIBUTOR_NAME = "MSI";
        public static string REMOTE_LOGIN = "HT_KN";
        public static string REMOTE_PASS = "123456";
        public static string connstrPublisher = "Data Source=MSI;Initial Catalog=NGANHANG;Integrated Security=True";
        public static string CONNECTION_STR_TEMPLATE = "Data Source={0}; Initial Catalog=NGANHANG;{1}";

        public static BindingSource bindingSource = new BindingSource();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static User login(string loginName)
        {
            SqlDataReader myReader = Program.ExecuteSqlDataReader($"EXEC dbo.SP_LAYTHONGTINNV '{loginName}'");
            //Du lieu co the bi loi va chuyen sang null
            if (myReader == null)
                return null;

            //Ko co du lieu trong DB
            if (!myReader.Read())
            {
                MessageBox.Show("Login của bạn không có quyền truy cập dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
/*                Console.WriteLine("Error 1");*/
                return null;
            }
            //Dang nhap voi tu cach la khach hang
            else if (myReader.IsDBNull(1) == true)
            {
                myReader = Program.ExecuteSqlDataReader($"EXEC dbo.SP_LAYTHONGTINKH '{loginName}'");

                if (myReader == null)
                    return null;

                //Ko co du lieu trong DB
                if (!myReader.Read())
                {
                    MessageBox.Show("Login của bạn không có quyền truy cập dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
/*                    Console.WriteLine("Error 2");*/
                    return null;
                }
            }

            User user = new User(myReader);
            myReader.Close();
            return user;
        }

        //
        public static bool checkConnection()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                Program.conn.ConnectionString = connectionStr;
                Program.conn.Open();
                return true;    //Ket noi den site phan manh tuong ung thanh cong
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;   //Kết nối không thành công đến phân mảnh tương ứng
            }
        }

        public static void setServerToDistributor(string subcriber)
        {
            serverName = subcriber; // side phân mảnh
            connectionStr = string.Format(CONNECTION_STR_TEMPLATE, serverName, "Integrated Security=True");
        }

        public static string layChiNhanhHienTai()
        {
            try
            {
                SqlDataReader dataReader = Program.ExecuteSqlDataReader("EXEC SP_LAYCHINHANHHIENTAI");
                /*SqlDataReader dataReader = Program.ExecuteSqlDataReader("SELECT MACN FROM ChiNhanh");*/
                dataReader.Read();
                return dataReader.GetValue(0).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tài khoản không tồn tại trong hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static SqlDataReader ExecuteSqlDataReader(string query)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                Connection = new SqlConnection(connectionStr),
                CommandText = query,
 /*               CommandType = CommandType.Text*/
            };

            SqlDataReader myReader;
            try
            {
                if (sqlCommand.Connection.State == ConnectionState.Closed)
                    sqlCommand.Connection.Open();
/*                Console.WriteLine("Error 1");*/
                myReader = sqlCommand.ExecuteReader();
/*                Console.WriteLine("Error 2");*/
                return myReader;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int rowAffected = -1;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection)
                {
                    //Thời gian tối đa cho phép chạy câu truy vấn
                    CommandTimeout = 600    //10 phút
                };

                if(parameters != null)
                {
                    int i = 0;
                    //Thực hiện tách chuỗi dựa trên @ + Ký tự space + [nhiều_ký_tự_space]
                    foreach(string item in Regex.Split(query, @"\s+"))
                    {
                        if (item.Contains("@"))
                        {
                            //Biến id dùng để lưu index của ký tự ","
                            //Dựa vào biến id ta  sẽ loại bỏ ký tự "," trong chuỗi
                            int id = item.IndexOf(",");
                            if (id > 0)
                                command.Parameters.AddWithValue(item.Remove(id), parameters[i]);
                            else
                                command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                try
                {
                    connection.Open();
                    rowAffected = command.ExecuteNonQuery();
                    Console.WriteLine(rowAffected);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rowAffected = -2;
                }
            }
            return rowAffected;
        }

        public static int ExecuteNonQuery2(string query, object[] parameters = null)
        {


            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandTimeout = 600, // 10 mins
                };

                if (parameters != null)
                {
                    int i = 0;
                    foreach (string item in Regex.Split(query, @"\s+")) // chia phần tử theo khoảng trắng, kiểm tra từng phần tử 
                    {
                        if (item.Contains("@"))
                        {
                            int id = item.IndexOf(',');
                            if (id > 0)
                                command.Parameters.AddWithValue(item.Remove(id), parameters[i]);
                            else
                                command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

            return -1;
        }

        public static int ExecSqlCheck(string tenSP, string para)
        {
            string sql = $"DECLARE @return_value int EXEC @return_value = [dbo].[{tenSP}] @a SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sqlCommand.Parameters.AddWithValue("@a", para);
            SqlDataReader dataReader = null;

            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return -1;
            }
        }

        public static int ExecSqlCheck1(string tenSP, string para1, string para2, string para3, string para4, string para5, string para6)
        {
            string sql = $"DECLARE @return_value int EXEC @return_value = [dbo].[{tenSP}] @a1, @a2, @a3, @a4, @a5, @a6 SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            sqlCommand.Parameters.AddWithValue("@a1", para1);
            sqlCommand.Parameters.AddWithValue("@a2", para2);
            sqlCommand.Parameters.AddWithValue("@a3", para3);
            sqlCommand.Parameters.AddWithValue("@a4", para4);
            sqlCommand.Parameters.AddWithValue("@a5", para5);
            sqlCommand.Parameters.AddWithValue("@a6", para6);
            SqlDataReader dataReader = null;

            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return -1;
            }
        }

        public static void setServerToRemote(string subscriber)
        {
            //subscriber ở đây có thể là:
            //MSI\MSSQLSERVER01 -> Mở kết nối đến site Bến Thành (Site 1)
            //MSI\MSSQLSERVER02 -> Mở kết nối đền site Tân Định (Site 2)
            serverName = subscriber;
            connectionStr = string.Format(CONNECTION_STR_TEMPLATE, serverName, $"User ID ={REMOTE_LOGIN};password={REMOTE_PASS}");
        }

        public static void setServerSubscriber(string subscriber, string loginName, string pass)
        {
            //subscriber ở đây có thể là:
            //MSI\MSSQLSERVER01 -> Mở kết nối đến site Bến Thành (Site 1)
            //MSI\MSSQLSERVER02 -> Mở kết nối đền site Tân Định (Site 2)
            serverName = subscriber;
            connectionStr = string.Format(CONNECTION_STR_TEMPLATE, serverName, $"User ID = {loginName};password={pass}");
        }

        public static int kiemTraKhachHangTonTai(string CMND)
        {
            return Program.ExecSqlCheck("SP_KIEMTRAKH", CMND);
        }

        public static int kiemTraCMNDNhanVienTonTai(string cmnd)
        {
            return (int)Program.ExecSqlCheck("SP_KIEMTRACMNDNV", cmnd);

        }

        public static int kiemTraCMNDNhanVienTonTai2(string cmnd)
        {
            return (int)Program.ExecSqlCheck("SP_KIEMTRACMNDNV2", cmnd);
        }

        public static int kiemTraNhanVienTonTai(string NhanVienID)
        {
            return (int)Program.ExecSqlCheck("SP_KIEMTRANHANVIEN", NhanVienID);

        }

        public static int kiemTraNhanVienTonTai2(string HO, string TEN, string CMND, string DIACHI, string PHAI, string SODT)
        {
            return (int)Program.ExecSqlCheck1("SP_KIEMTRANHANVIEN2", HO, TEN, DIACHI, PHAI, SODT, CMND);

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.frmChinh = new FormMain();
            Application.Run(frmChinh);
            /*Application.Run(new Form1());*/
        }
    }
}
