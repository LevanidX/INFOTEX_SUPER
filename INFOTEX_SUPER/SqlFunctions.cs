using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOTEX_SUPER
{
    internal class SqlFunctions
    {
        private string GetConnection()
        {
            return "Data Source =LEVANIDPC;Initial Catalog=OOO_INFOTEX;Integrated Security=True;Encrypt=False";
        }

        public DataTable ExecuteSqlCommand(string commandText)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(GetConnection()))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = commandText;
                    
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        sqlDataAdapter.SelectCommand = command;
                        sqlDataAdapter.Fill(dt);
                    }
                }

                connection.Close();
            }

            return dt;
        }
    }
}
