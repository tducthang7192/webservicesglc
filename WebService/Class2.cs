using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WebService
{
    public class Class2
    {
        public static string connectstring = ConfigurationManager.ConnectionStrings["WMPRDConnectionString"].ConnectionString;
    }
}