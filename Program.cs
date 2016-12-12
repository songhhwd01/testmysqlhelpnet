using MySqlHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = "Server=localhost;UserId=root;Password=root;Database=test";
            MySqlQueryHelper helper = new MySqlHelper.MySqlQueryHelper(conn);

            var a = helper.Select("select * from log");
            helper.CloseConnection();
        }
    }
}
