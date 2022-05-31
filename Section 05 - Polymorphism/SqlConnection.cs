using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section05Namespace
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }
        
        public override void Open()
        {
            Console.WriteLine("SqlConnection Opened using " + this.ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("SqlConnection Closed using " + this.ConnectionString);
        }
    }
}
