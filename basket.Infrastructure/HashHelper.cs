using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace basket.Infrastructure
{
    public class HashHelper
    {
        public string Hash(string plainText)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }
    }
}
