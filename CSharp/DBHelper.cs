using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CSharp
{
    public class DBHelper
    {

        private const string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True";

        public IDbConnection GetNewConnection()
        {
            return new SqlConnection(connectionString);
        }

        public int executeNonQuery(string cmdText, params IDataParameter[] parameters)
        {
            using (IDbConnection connection = GetNewConnection())
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = cmdText;

                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.Add(parameters);

                }

                return command.ExecuteNonQuery();
            }

        }
        public int Delete(string cmdText, params IDataParameter[] parameters)
        {
            return executeNonQuery(cmdText, parameters);
        }

        public int Update(string cmdText)
        {
            return executeNonQuery(cmdText);
        }


    }
}
