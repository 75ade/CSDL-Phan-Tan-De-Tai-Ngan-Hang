using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectNHPT.DTO
{
    public class KhachHang
    {
        public readonly static string CMND_HEADER = "CMND";
        public readonly static string HO_HEADER = "HO";
        public readonly static string TEN_HEADER = "TEN";
        public readonly static string DIACHI_HEADER = "DIACHI";
        public readonly static string PHAI_HEADER = "PHAI";
        public readonly static string NGAYCAPKHACH_HEADER = "NGAYCAP";
        public readonly static string SODT_HEADER = "SODT";

        private string CMND;
        private string HO;
        private string TEN;
        private string DIACHI;
        private string PHAI;
        private DateTime NGAYCAP;
        private string SODT;

        //Các thuộc tính trong đăng nhập tài khoản
/*        private string LOGINNAME;
        private string PASSWORD;*/

        //Constructors:
        public KhachHang()
        {

        }

        public KhachHang(string CMND, string HO, string TEN, string DIACHI, string PHAI, DateTime NGAYCAP, string SODT)
        {
            this.CMND = CMND;
            this.HO = HO;
            this.TEN = TEN;
            this.DIACHI = DIACHI;
            this.PHAI = PHAI;
            this.NGAYCAP = NGAYCAP;
            this.SODT = SODT;
        }

        public KhachHang(DataRowView row)
        {
            this.CMND = (string)row["CMND"];
            this.HO = (string)row["HO"];
            this.TEN = (string)row["TEN"];
            this.DIACHI = (string)row["DIACHI"];
            this.PHAI = (string)row["PHAI"];
            this.NGAYCAP = (DateTime)row["NGAYCAP"];
            this.SODT = (string)row["SODT"];
        }

        //Getter and setter:
        public string Cmnd { get => CMND; set => CMND = value; }
        public string Ho { get => HO; set => HO = value; }
        public string Ten { get => TEN; set => TEN = value; }
        public string DiaChi { get => DIACHI; set => DIACHI = value; }
        public string Phai { get => PHAI; set => PHAI = value; }
        public DateTime NgayCap { get => NGAYCAP; set => NGAYCAP = value; }
        public string SoDT { get => SODT; set => SODT = value; }
    
/*        public string LoginName { get => LOGINNAME; set => LOGINNAME = value; }
        public string Password { get => PASSWORD; set => PASSWORD = value; }*/
    }
}
