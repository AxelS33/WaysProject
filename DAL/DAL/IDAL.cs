using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDAL
    {
          SqlDataReader executeProcedure(String procedureName);
          SqlDataReader executeWithParameter(String procedureName, List<Object> parameters);
    }
}
