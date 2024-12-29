using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectNHPT.DTO
{
    public class TaiKhoanNganHang
    {
        public readonly static string SOTK_HEADER = "SOTK";
        public readonly static string CMND_HEADER = "CMND";
        public readonly static string SODU_HEADER = "SODU";
        public readonly static string MACN_HEADER = "MACN";
        public readonly static string NGAYMOTK_HEADER = "NGAYMOTK";

        private string SOTK;
        private string CMND;
        private double SODU;
        private string MACN;
        private DateTime NGAYMOTK;

        public TaiKhoanNganHang() { }

        public TaiKhoanNganHang(DataRowView row)
        {
            this.SOTK = (string)row[SOTK_HEADER];
            this.CMND = (string)row[CMND_HEADER];
            this.SODU = double.Parse(row[SODU_HEADER].ToString());
            this.MACN = (string)row[MACN_HEADER];
            this.NGAYMOTK = (DateTime)row[NGAYMOTK_HEADER];
        }

        public string SoTK { get => SOTK; set => SOTK = value; }
        public string Cmnd { get => CMND; set => CMND = value; }
        public double SoDu { get => SODU; set => SODU = value; }
        public string MaCN { get => MACN; set => MACN = value; }
        public DateTime NgayMoTK { get => NGAYMOTK; set => NGAYMOTK = value; }
    }
}
