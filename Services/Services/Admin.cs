using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Admin : Service
    {

        public Admin()
        {

        }

        public override StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {
            return msg;
        }
    }

   /* enum AdminFunctionalities
    {
        Add = "addQuestion",
        Modify = "modifyQuestion",
        Delete = "deleteQuestion",
        Show = "showQuestion",
        Login = "login",
    }*/
}
