using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JS_LearnApp
{
    public class SQLConnector
    {
        public static string GetSqlConnectionPath()
        {
            string pathToDatabase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JS_TST.mdb");
            return ConfigurationSettings.AppSettings["sqlConnectionToDb"];

            
        }
    }
}
