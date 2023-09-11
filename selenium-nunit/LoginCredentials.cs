using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_nunit
{
    public static class LoginCredentials
    {
        // You need to have saved login credentials in this file in format:
        // name
        // password
        private static string configLocation = "../../../config.env";
        public static string GetLogin()
        {
            return File.ReadAllLines(configLocation)[0];
        }

        public static string GetPassword()
        {

            return File.ReadAllLines(configLocation)[1];
        }
    }
}
