using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section05Namespace
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection Opened " + this.ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection Closed " + this.ConnectionString);
        }
    }
}
