using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section05Namespace
{
    internal class Exercises1
    {
        static void Main(string[] args)
        {
            // Exercise1();
            Exercise2();
        }

        public static void Exercise1()
        {
            DbConnection sql = new SqlConnection("sqlConnectionString", new TimeSpan(0, 0, 15));
            DbConnection oracle = new OracleConnection("oracleConnectionString", new TimeSpan(0, 0, 18));

            sql.Open();
            sql.Close();

            oracle.Open();
            oracle.Close();

            Console.ReadKey();
        }

        public static void Exercise2()
        {
            DbConnection sql = new SqlConnection("sqlConnectionString", new TimeSpan(0, 0, 15));
            DbConnection oracle = new OracleConnection("oracleConnectionString", new TimeSpan(0, 0, 18));

            DbCommand command1 = new DbCommand(sql, "Command 1");

            command1.Execute();

            command1.dbConnection = oracle;

            command1.Execute();

            DbCommand command2 = new DbCommand(oracle, "Command 2");

            command2.Execute();

            command2.dbConnection = sql;

            command2.Execute();

            Console.ReadKey();
        }
    }
}
