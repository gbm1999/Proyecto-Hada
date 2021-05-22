using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Security.Cryptography;
using System.Text;

namespace HadaPopWeb
{
    public class Global : System.Web.HttpApplication
    {
        public static string ADMINPASS { set; get; }
        private static readonly UTF8Encoding Encoder = new UTF8Encoding();

        protected void Application_Start(object sender, EventArgs e)
        {
            ADMINPASS = "HadaMola123";
        }

        public static string Encrypt(string unencrypted)
        {
            try
            {
                var encryptedBytes = MachineKey.Protect(Encoder.GetBytes(unencrypted));

                if (encryptedBytes != null && encryptedBytes.Length > 0)
                    return HttpServerUtility.UrlTokenEncode(encryptedBytes);
            }
            catch (Exception)
            {
                return string.Empty;
            }

            return string.Empty;
        }

        public static string Decrypt(string encrypted)
        {
            if (string.IsNullOrEmpty(encrypted))
                return string.Empty;

            try
            {
                var bytes = HttpServerUtility.UrlTokenDecode(encrypted);
                if (bytes != null && bytes.Length > 0)
                {
                    var decryptedBytes = MachineKey.Unprotect(bytes);
                    if (decryptedBytes != null && decryptedBytes.Length > 0)
                        return Encoder.GetString(decryptedBytes);
                }

            }
            catch (Exception)
            {
                return string.Empty;
            }

            return string.Empty;
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}