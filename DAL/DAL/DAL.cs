using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL : IDAL
    {
        private string strConnection;
        private SqlConnection connection;
        private SqlCommand cmd;

        public DAL()
        {
            try
            {
                this.strConnection = "chaine cryptee qui vient de xml !!";
                this.connection = new SqlConnection(this.strConnection);
            }
            catch (Exception ConnectionFail)
            {
                throw ConnectionFail;
            }
        }

        public SqlDataReader executeProcedure(String procedureName)
        {
            connection.Open();
            this.cmd = new SqlCommand();    
            this.cmd.Connection = this.connection;

            this.cmd.CommandText = procedureName;
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
            return reader;
        }

        public SqlDataReader executeWithParameter(String procedureName)
        {
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
    }
}
