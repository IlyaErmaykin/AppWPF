using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Indusoft.Common.ConfigSQL.test
{
    class MsSqlDataBase : IDataBase_test
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public DbConnection DbConnection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Indusoft.OMSClient.My.MySettings.ConfigDbConnectionString"].ConnectionString);
                }
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

        public DbCommand DbCommand
        {
            get
            {
                if (_command == null)
                {
                    _command = new SqlCommand();
                    _command.Connection = DbConnection;
                }
                return _command;
            }
            set
            {
                _command = value;
            }
        }
    }
}
