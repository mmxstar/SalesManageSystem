using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesManageSystem.DataBaseConnection
{
    class DBConnection
    {
        private string mysqlString = "Database=salesmanageSystem;DataSource=localhost;User Id =root;Password=123456;pooling=false;Charset=utf8;port=3306";
        private MySqlConnection mMySqlConnection;

        public DBConnection()
        {

        }

        public MySqlConnection GetConnection()
        {
            mMySqlConnection = new MySqlConnection(mysqlString);
            return mMySqlConnection;
        }

        public void Close()
        {
            mMySqlConnection.Close();
        }

    }
}
