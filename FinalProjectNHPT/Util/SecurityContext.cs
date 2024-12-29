using FinalProjectNHPT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectNHPT.Util
{
    public class SecurityContext
    {
        private static User user;

        public static User User { get => user; set => user = value; }

        public static void clearUser()
        {
            user = null;
        }
        private SecurityContext() { }
    }
}
