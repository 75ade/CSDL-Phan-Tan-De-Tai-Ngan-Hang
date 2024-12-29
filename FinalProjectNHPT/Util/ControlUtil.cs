using FinalProjectNHPT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectNHPT.Util
{
    public static class ControlUtil
    {
        public readonly static int MAX_RECORD_STACK = 50;

        public static Form checkFormExists(Form parent, Type fType)
        {
            foreach (Form f in parent.MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        
        public static string RemoveDuplicateSpace(string str)
        {
            return Regex.Replace(str, @"\s+", " ");
        }

        public static string CapitalizeFirstLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException();

            string res = "";
            string[] words = Regex.Split(str, @"\s+");

            foreach(string word in words)
            {
                //Phải chừa khoảng trắng ở cuối để nối chữ
                res += $"{word.First().ToString().ToUpper()}{word.Substring(1).ToLower()} ";
            }

            //Trả về thì ta cắt bỏ khoảng trắng ở cuối
            return res.TrimEnd();
        }

        public static void ResolveStackStorage(LinkedList<UserEventData> stack)
        {
            if (stack.Count == MAX_RECORD_STACK)
                stack.RemoveFirst();
        }
    }
}
