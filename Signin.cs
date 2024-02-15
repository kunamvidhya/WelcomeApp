using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class Signin
    {
        public static string Authenticate(String userName, string password)
        {
            string msg;

            if ((string.IsNullOrEmpty(userName)) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password required";
            }
            else
            {
                if ((userName == "admin") && (password == "admin12345"))
                {
                    msg = "Authentication Fail";
                }
                else
                {
                    msg = "Authentication Pass";
                }
            }
            return msg;
        }
    }
}

