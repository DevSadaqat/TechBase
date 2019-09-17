using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LapbaseEntityFramework
{
    public class EnvironmentConfigBuilder
    {
       private string username;
      private string password;

        public EnvironmentConfigBuilder()
        {
             username = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["LBUSERNAME"]);
             password = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["LBPASSWORD"]);

        }
       
        public string getLBCS()
        {
       
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Lapbase"];
        string connectString = settings.ConnectionString.ToString();
   
       string cs = Regex.Replace(connectString, @"user id=[^;]*", "user id=" + username);
       string cs1 = Regex.Replace(cs, "password=[^;]*", "password=" + password);
        return cs1;
        }

        public string getDemoCS()
        {

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["LbDemo"];
            string connectString = settings.ConnectionString.ToString();

            string cs = Regex.Replace(connectString, @"user id=[^;]*", "user id=" + username);
            string cs1 = Regex.Replace(cs, "password=[^;]*", "password=" + password);
            return cs1;
        }



    }



}
