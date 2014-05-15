using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.CUC
{
    class CUC
    {
        private string AppName;
        private string pSecurity;
        StgMsg.StgMsg msg;


        public CUC()
        {
            AppName = "Ways";
            pSecurity = "123";
        }

        public void callService(){
            msg = new StgMsg.StgMsg();
            msg.appName = this.AppName;
            msg.pSecurity = this.pSecurity;
        }
    }
}
