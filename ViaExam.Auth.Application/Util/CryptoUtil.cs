using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ViaExam.Auth.Application.Util
{
    public static class CryptoUtil
    {
        public static string EncryptSHA1(string plain)
        {
            string hash;
            byte[] temp;

            SHA1 sha = new SHA1CryptoServiceProvider();
            temp = sha.ComputeHash(Encoding.UTF8.GetBytes(plain));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
                sb.Append(temp[i].ToString("x2"));

            hash = sb.ToString();
            return hash;
        }
        
    }
}
