using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectNHPT.DTO
{
    public class User
    {
        public readonly static string GROUP_NAME_NGANHANG = "NganHang";
        public readonly static string GROUP_NAME_CHINHANH = "ChiNhanh";
        public readonly static string GROUP_NAME_KHACHHANG = "KhachHang";

        //Attributes
        private string loginName;
        private string password;
        private string userName;
        private int brandIndex;
        private GroupENM group;
        private string fullName;

        //Enum
        public enum GroupENM
        {
            NganHang,
            ChiNhanh,
            KhachHang
        }

        //Constructor:
        public User(string loginName, string password, string userName, int brandIndex, string group, string fullName)
        {
            this.loginName = loginName;
            this.password = password;
            this.userName = userName;
            this.brandIndex = brandIndex;
            this.fullName = fullName;
            setGroup(group);
        }

        public User(SqlDataReader myReader)
        {
            userName = myReader["USERNAME"].ToString();
            fullName = myReader["HOTEN"].ToString();
            setGroup(myReader["TENNHOM"].ToString());
        }


        //Getter and setter:
        public string LoginName { get => loginName; set => loginName = value; }
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
        public int BrandIndex { get => brandIndex; set => brandIndex = value; }
        public string FullName { get => fullName; set => fullName = value; }
        
        public GroupENM Group { get => group; set => group = value; }
        public void setGroup(string groupName)
        {
            if (groupName.Equals(GROUP_NAME_NGANHANG))
                this.group = GroupENM.NganHang;
            else if (groupName.Equals(GROUP_NAME_CHINHANH))
                this.group = GroupENM.ChiNhanh;
            else if (groupName.Equals(GROUP_NAME_KHACHHANG))
                this.group = GroupENM.KhachHang;
            else
                throw new Exception("Group's name is illegal");
        }

        public string getGroup()
        {
            switch (this.group)
            {
                case GroupENM.NganHang:
                    return GROUP_NAME_NGANHANG;
                case GroupENM.ChiNhanh:
                    return GROUP_NAME_CHINHANH;
                case GroupENM.KhachHang:
                    return GROUP_NAME_KHACHHANG;
                default:
                    throw new Exception();
            }
        }
    }
}
