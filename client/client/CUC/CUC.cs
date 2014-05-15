using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.CUC
{
    public class CUC
    {
        private string AppName;
        private string pSecurity;

        public CUC()
        {
            AppName = "Ways";
            pSecurity = "123";
        }

        public StgMsg.StgMsg callService(StgMsg.StgMsg msg){
            msg.appName = this.AppName;
            msg.pSecurity = this.pSecurity;

            return msg;
        }
    }
}
