using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManageSystem.DataBaseConnection;
using SalesManageSystem.Model;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesManageSystem.Dao
{
    class LoginDao
    {
        private DBConnection mDBConnection;

        public LoginDao()
        {
            mDBConnection = new DBConnection();
        }

        private User getUser(string userName)
        {
            User user = new User();

            MySqlConnection mySqlConnection = mDBConnection.GetConnection();
            mySqlConnection.Open();

            string sql = "select* from admin where userName="+"\""+userName+"\";";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        user.Name = reader.GetString(1);
                        user.Sex = reader.GetString(2);
                        user.UserName = reader.GetString(3);
                        user.Password = reader.GetString(4); 
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                mySqlConnection.Close();     
            }

            return user;
        }

        public bool Login(User user)
        {
            bool bSuccess = false;
            User u = getUser(user.UserName);
            if (u.Password!=null&&u.Password.Equals(user.Password)) { bSuccess = true; }
            return bSuccess;
        }
    }
}
