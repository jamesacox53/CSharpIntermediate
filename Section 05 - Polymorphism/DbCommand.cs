using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section05Namespace
{
    internal class DbCommand
    {
        private DbConnection _dbConnection;
        
        public DbConnection dbConnection
        {
            get
            {
                return _dbConnection;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                _dbConnection = value;
            }
        }

        private string __dbcommand;

        private string _dbcommand
        {
            get 
            { 
                return __dbcommand; 
            }
            set
            {
                if(value == null || value.Trim() == "") throw new ArgumentNullException("value");
                __dbcommand = value;
            }
        }

        public string dbCommand
        {
            get 
            {
                return _dbcommand; 
            }
        }

        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            this.dbConnection = dbConnection;
            this._dbcommand = dbCommand;
        }

        public void Execute()
        {
            dbConnection.Open();

            Console.WriteLine(this.dbCommand);

            dbConnection.Close();
        }
    }
}
