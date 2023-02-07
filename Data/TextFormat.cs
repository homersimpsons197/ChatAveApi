using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chat_Avenue.Data
{
    internal class TextFormat
    {
        Regex a, b;
        
        public string[] UrlEncode(string[] arr)
        {
            a = new Regex(@"(@)");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Regex.Replace(arr[i], $@"{a}", "%40");
            }

            return arr;
        }

        public string UrlDecode(string user)
        {
            b = new Regex(@"(%40)");

            user = Regex.Replace(user, $@"{b}", "@");
            
            return user;
        }
    }
}
