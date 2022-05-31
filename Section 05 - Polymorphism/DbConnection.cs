using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section05Namespace
{
    internal abstract class DbConnection
    {
        private string _ConnectionString;
        
        public string ConnectionString 
        {
            get 
            { 
                return _ConnectionString; 
            }
            set 
            { 
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentNullException("value");
                }    
                _ConnectionString = value; 
            }
        }

        private TimeSpan _Timeout;

        public TimeSpan Timeout 
        {
            get 
            {
                return _Timeout;
            }
            set 
            {
                if (value == null || value.TotalSeconds <= 0)
                _Timeout = value;
            } 
        }

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            this.ConnectionString = connectionString;
            this.Timeout = timeout;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
