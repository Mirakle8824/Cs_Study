using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace SQL_Start
{
    class Program
    {
        private SQLiteConnection conn = null;

        static void Main(string[] args)
        {
            SQLiteConnection.CreateFile("c:/a.sqlite");

            conn = new SQLiteConnection("Data Source=c:/a.sqlite;Version=3;");
            conn.Open();

        }
    }
}
