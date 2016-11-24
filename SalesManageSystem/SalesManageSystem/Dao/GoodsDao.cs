using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManageSystem.Model;
using SalesManageSystem.DataBaseConnection;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesManageSystem.Dao
{
    class GoodsDao
    {
        private DBConnection mDBConnection;
        public GoodsDao()
        {
            mDBConnection = new DBConnection();
        }

        public List<Goods> SelectAll()
        {
            List<Goods> goodsList = new List<Goods>();

            MySqlConnection mySqlConnection = mDBConnection.GetConnection();
            mySqlConnection.Open();

            string sql = "select * from merchandise";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.HasRows) {
                        Goods goods = new Goods();
                        goods.GoodsNumber = reader.GetString(1);
                        goods.Category = reader.GetString(2);
                        goods.Name = reader.GetString(3);
                        goods.BarCode = reader.GetString(4);
                        goods.Unit = reader.GetString(5);
                        goods.Specification = reader.GetString(6);
                        goods.ProductionPlace = reader.GetString(7);
                        goods.Version = reader.GetString(8);
                        goods.Remark = reader.GetString(9);

                        goodsList.Add(goods);
                    }
                }
            }
            catch (MySqlException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return goodsList;
        }

        public  bool AddNewGoods(Goods goods)
        {
            bool bSuccess = false;

            MySqlConnection mySqlConnection = mDBConnection.GetConnection();
            mySqlConnection.Open();

            StringBuilder sql = new StringBuilder("insert into merchamndise(goodsNumber,category,name,barCode,unit,specification,productionPlace,version,remark) value(?goodsNumber,?category,?name,?barCode,?unit,?specification,?productionPlace,?version,?remark);");
            MySqlParameter[] parameters = {
                new MySqlParameter("?goodsNumber",MySqlDbType.String),
                new MySqlParameter("?category",MySqlDbType.String),
                new MySqlParameter("?name",MySqlDbType.String),
                new MySqlParameter("?barCode",MySqlDbType.String),
                new MySqlParameter("?unit",MySqlDbType.String),
                new MySqlParameter("?spcification",MySqlDbType.String),
                new MySqlParameter("?productionPlace",MySqlDbType.String),
                new MySqlParameter("?version",MySqlDbType.String),
                new MySqlParameter("?remark",MySqlDbType.String)
            };
            parameters[0].Value = goods.GoodsNumber;
            parameters[1].Value = goods.Category;
            parameters[2].Value = goods.Name;
            parameters[3].Value = goods.BarCode;
            parameters[4].Value = goods.Unit;
            parameters[5].Value = goods.Specification;
            parameters[6].Value = goods.ProductionPlace;
            parameters[7].Value = goods.Version;
            parameters[8].Value = goods.Remark;

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
      
            if (cmd.ExecuteNonQuery() == 1) { bSuccess = true; }

            return bSuccess;
        }
    }
}
