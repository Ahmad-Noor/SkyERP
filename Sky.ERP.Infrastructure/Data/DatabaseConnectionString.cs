using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sky.ERP.Infrastructure.Data
{
    public class DatabaseConnectionString : IDatabaseConnectionString
    {
        public string ConnectionString { get; }

        public DatabaseConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
