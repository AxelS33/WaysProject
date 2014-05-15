using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL : IDAL
    {
        private string strConnection;
        public SqlConnection connection { get; set; }
        private SqlCommand cmd;

        public DAL()
        {
            try
            {
                this.strConnection = "Server=WIN-SOLOQ4BCPNR; Database=DataWays; User Id=Database_Owner ; Password=Admin2014;";
                this.connection = new SqlConnection(this.strConnection);
            }
            catch (Exception ConnectionFail)
            {
                throw ConnectionFail;
            }
        }
        public void OpenConnection()
        {
            this.connection.Open();
        }

        public SqlDataReader executeProcedure(String procedureName)
        {
            
            this.cmd = new SqlCommand();    
            this.cmd.Connection = this.connection;

            this.cmd.CommandText = procedureName;
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            
            return reader;
        }
        public void closeConnection()
        {
            this.connection.Close();
        }

        public void executeWithParameter(String procedureName, List<object[]> parameters)
        {
           
           
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.connection;

            this.cmd.CommandText = procedureName;
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            List<SqlParameter> listParameters = new List<SqlParameter>();
            foreach(object[] o in parameters)
            {
                SqlParameter param = new SqlParameter(o[0].ToString(), o[1].GetType());
                param.Direction = ParameterDirection.Input;
                param.Value = o[1];
                listParameters.Add(param);
            }

            foreach (SqlParameter param in listParameters)
            {
               this.cmd.ExecuteNonQuery();
            }
            this.connection.Close();
            
          
        }

        public SqlDataReader queryWithParameter(String procedureName, object[] parameters)
        {
            
            this.connection.Open();

            this.cmd = new SqlCommand();
            this.cmd.Connection = this.connection;

            this.cmd.CommandText = procedureName;
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDbType dbt = new SqlDbType();
            Type typeParam = parameters[1].GetType();
            switch (typeParam.FullName)
            {
                case "System.Int32": dbt = SqlDbType.Int;
                    break;
                case "System.Int16": dbt = SqlDbType.Int;
                    break;
                case "System.String": dbt = SqlDbType.NVarChar;
                    break;
                default: dbt = SqlDbType.NVarChar;
                    break;
            }
          
                SqlParameter param = new SqlParameter(parameters[0].ToString(), SqlDbType.NVarChar);
                param.Direction = ParameterDirection.Input;
                param.Value = parameters[1];
                cmd.Parameters.Add(param);
                SqlDataReader reader = this.cmd.ExecuteReader();
                return reader;
            

        }
    }
}
