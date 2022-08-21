using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.OleDb;
using Dapper;
using System.Linq;
using FbAutomatedTests.Properties;

namespace FbAutomatedTests.TestDataAccess
{
    class ExcelDataAccess
    {
        public static string TestDataFileConnection()
        {
            var TestData = Resources.TestDataSheetPath;
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", TestData);
            return con;
        }

        public static UserData GetTestData(string FbTest)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var Loginquery = string.Format("select * from [DataSet$] where key='{0}'", FbTest);
                


                var value = connection.Query<UserData>(Loginquery).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

        
    }
}
