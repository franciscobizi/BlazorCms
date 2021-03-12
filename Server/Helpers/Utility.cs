using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorCms.Server.Helpers
{
    public class Utility
    {
        public static string Encrypt(string password)
        {
            var provider = MD5.Create();
            string salt = "S0m3R@nd0mSalt";            
            byte[] bytes = provider.ComputeHash(Encoding.UTF32.GetBytes(salt + password));
            return BitConverter.ToString(bytes).Replace("-","").ToLower();
        }

        public static string ToUrlFriendly(string url)
        {

            return Regex.Replace(url, " ", "-").ToLower();
        }

        public static string Ucfirst(string s)  
        {    
            if (string.IsNullOrEmpty(s))  
            {  
                return string.Empty;  
            }   
            return char.ToUpper(s[0]) + s.Substring(1);  
        }  
    }
}
