using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule.DBHelper
{
    public class DBConnection
    {
        private static MySqlConnection _conn;

        public static MySqlConnection Conn
        {
            get
            {
                if (_conn == null)
                {
                    MySqlConnection connection = new MySqlConnection(ConstValue.DBConnectionString);
                    _conn = connection;
                }
                return _conn;
            }
        }
        
        public static MySqlConnection CreateConnection()
        {
            return Conn;
        }
    }
}
