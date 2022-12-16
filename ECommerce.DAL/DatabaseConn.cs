using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ECommerce.DAL
{
    public class DatabaseConn
    {
        SqlConnection sqlConnection;
        public DatabaseConn()
        {
            sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog =ECommerce; Integrated Security = True");
        }
        /// <summary>
        /// It executes insert,update and delete query and returns number of rows affected.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int ExecuteQuery(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            try
            {
                sqlCommand.Connection.Open();
                return sqlCommand.ExecuteNonQuery();
               /// sqlCommand.Connection.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally  ///Jaile pani aauxa 
            {
                sqlCommand.Connection.Close();
            }
        }

        public DataTable GetData(string query)
        {

        }
    }
}
