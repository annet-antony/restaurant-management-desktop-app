using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DbConnection

{
    class DB_Connection_class : DB_Connection_classBase
    {
        string myconnectionstring = "server=localhost;user id=root;database=restaurant";
        MySqlConnection con;
        MySqlCommand cmd;

        public void OpenConnection()
        {
            con = new MySqlConnection(myconnectionstring);
            con.Open();
        }
        public void ExecuteQueries(string query)
        {  
            cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }
        public MySqlDataReader DataReader(string query)
        {
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string query)
        {
            OpenConnection();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, con);
            CloseConnection();
            return adapt;
        }
        public int CountData(string query)
        {
            OpenConnection();
            int count = 0;
            cmd = new MySqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            CloseConnection();
            return count;

        }
        public string Max_No(string query)
        {
            OpenConnection();
            string max = null;
            cmd = new MySqlCommand(query, con);
            max = (string)cmd.ExecuteScalar();
            CloseConnection();
            return max;
        }
        public int discount_No(string query)
        {
            OpenConnection();
            int dis_id = 0;
            cmd = new MySqlCommand(query, con);
            dis_id = (int)cmd.ExecuteScalar();
            CloseConnection();
            return dis_id;
        }
        public bool checkExistence(string query)
        {
            bool exists = false;
            OpenConnection();
            cmd = new MySqlCommand(query, con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                exists = true;
            }
            CloseConnection();

                return exists;
        }
        public decimal unit_price(string query)
        {
            OpenConnection();
            decimal price = 0;
            cmd = new MySqlCommand(query, con);
            price = (decimal)cmd.ExecuteScalar();
            CloseConnection();
            return price;
        }
        public void CloseConnection()
        {
            con.Close();
        }
       

        
    }
}

