using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace LapbaseAPI
{
    public class EnvironmentConfigBuilder
    {
        private string username;
        private string password;

        public EnvironmentConfigBuilder()
        {

             username = Environment.GetEnvironmentVariable("LBUSERNAME");
             password = Environment.GetEnvironmentVariable("LBPASSWORD");
            CreateAppSettings("LBUSERNAME", username);
            CreateAppSettings("LBPASSWORD", password);

        }
        public void CreateAppSettings( string key, string value)
        {
            try
            {
                Configuration config =
                 ConfigurationManager.OpenExeConfiguration
                                       (ConfigurationUserLevel.None);

                config.AppSettings.Settings.Add(key, value);
                config.Save();
                
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[CreateAppSettings: {0}]",
                                  e.ToString());
                Console.WriteLine();
            }
        }

       
        
    }
}