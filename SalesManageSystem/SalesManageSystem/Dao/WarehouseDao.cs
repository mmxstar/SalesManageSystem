using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using SalesManageSystem.DataBaseConnection;
using SalesManageSystem.Model;

namespace SalesManageSystem.Dao
{
    class WarehouseDao
    {
        private DBConnection mDBConnection;

        public WarehouseDao()
        {
            mDBConnection = new DBConnection();
        }

        public List<Warehouse> SelectAll()
        {
            List<Warehouse> wareHouseList = new List<Warehouse>();

            MySqlConnection mySqlConnection = mDBConnection.GetConnection();
            mySqlConnection.Open();

            string sql = "select * from warehouse;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            try
            {
                while (reader.Read()) {
                    if (reader.HasRows) {
                        Warehouse warehouse = new Warehouse();
                        warehouse.Name = reader.GetString(1);
                        warehouse.Remark = reader.GetString(2);
                        warehouse.Code = reader.GetString(3);
                        wareHouseList.Add(warehouse);
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally {
                mySqlConnection.Close();
            }

            return wareHouseList;
        }

        public void AddWareHouse(Warehouse warehouse)
        {
            MySqlConnection mySqlConnection = mDBConnection.GetConnection();
            mySqlConnection.Open();

            StringBuilder sql = new StringBuilder("insert into warehouse(name,remark,warehouseCode) value(?name,?remark,?code);");
            MySqlParameter[] parameters = {
                new MySqlParameter("?name",MySqlDbType.String),
                new MySqlParameter("?remark",MySqlDbType.String),
                new MySqlParameter("?code",MySqlDbType.String)
            };
            parameters[0].Value = warehouse.Name;
            parameters[1].Value = warehouse.Remark;
            parameters[2].Value = warehouse.Code;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mySqlConnection;
            cmd.CommandText = sql.ToString();
            cmd.CommandType = System.Data.CommandType.Text;

            if (parameters != null)
            {
                foreach (MySqlParameter parameter in parameters)
                {
                    if ((parameter.Direction == System.Data.ParameterDirection.InputOutput || parameter.Direction == System.Data.ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
            cmd.ExecuteNonQuery();
        }
    }
}
