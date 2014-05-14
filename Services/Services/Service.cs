using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Service
    {
        protected BAC.BAC bac;

        public Service()
        {

        }

        public virtual StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {

            return msg;
           
        }
    }


}
