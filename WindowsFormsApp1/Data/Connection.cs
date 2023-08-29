using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1.Data
{
    class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();
        static string server = "127.0.0.1";
        static string database = "policydb";
        static string Uid = "root;";
        static string password = "ASHF#183SDfgh;";


        public static MySqlConnection datasource()
        {
            connMaster = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return connMaster;
        }

        public void connOpen()
        {
            datasource();
            connMaster.Open();
        }


        public void connClose()
        {
            datasource();
            connMaster.Close();
        }
    }
}
