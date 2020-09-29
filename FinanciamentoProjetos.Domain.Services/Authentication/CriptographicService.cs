using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FinanciamentoProjetos.Domain.Services.Authentication
{
    public static class CriptographicService
    {
        public static string EncriptPassword(string Password)
        {
            try
            {
                SHA512Managed hasher = new SHA512Managed();

                byte[] pwdBytes = new UTF8Encoding().GetBytes(Password);
                byte[] keyBytes = hasher.ComputeHash(pwdBytes);

                hasher.Dispose();
                return Convert.ToBase64String(keyBytes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
