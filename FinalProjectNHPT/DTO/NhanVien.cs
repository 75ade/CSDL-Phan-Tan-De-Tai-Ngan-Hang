using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectNHPT.DTO
{
    public class NhanVien
    {
        public readonly static string MANV_HEADER = "MANV";
        public readonly static string HO_HEADER = "HO";
        public readonly static string TEN_HEADER = "TEN";
        public readonly static string DIACHI_HEADER = "DIACHI";
        public readonly static string PHAI_HEADER = "PHAI";
        public readonly static string SODT_HEADER = "SODT";
        public readonly static string CMND_HEADER = "CMND";

        private string MANV;
        private string HO;
        private string TEN;
        private string DIACHI;
        private string PHAI;
        private string SODT;
        private string CMND;

        public NhanVien() { }

        public NhanVien(string MANV, string HO, string TEN, string DIACHI, string PHAI, string SODT, string CMND)
        {
            this.MANV = MANV;
            this.HO = HO;
            this.TEN = TEN;
            this.DIACHI = DIACHI;
            this.PHAI = PHAI;
            this.SODT = SODT;
            this.CMND = CMND;
        }

        public NhanVien(DataRowView row)
        {
            MANV = (string)row[MANV_HEADER];
            HO = (string)row[HO_HEADER];
            TEN = (string)row[TEN_HEADER];
            DIACHI = (string)row[DIACHI_HEADER];
            PHAI = (string)row[PHAI_HEADER];
            SODT = (string)row[SODT_HEADER];
            CMND = (string)row[CMND_HEADER];
        }

        public string MaNV { get => MANV; set => MANV = value; }
        public string Ho { get => HO; set => HO = value; }
        public string Ten { get => TEN; set => TEN = value; }
        public string DiaChi { get => DIACHI; set => DIACHI = value; }
        public string Phai { get => PHAI; set => PHAI = value; }
        public string SoDT { get => SODT; set => SODT = value; }

        public string Cmnd { get => CMND; set => CMND = value; }

    }
}
