using System;
using System.Collections;
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
          void executeWithParameter(String procedureName, List<object[]> parameters);
          SqlDataReader queryWithParameter(String procedureName, object[] parameters);

    }
}
