using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BC;

namespace BusinessLayer.WC
{
    class WCGameQuestionnary : abstractWC
    {
        private BCGameQuestionnary BCquestionnary;
        private DAL.DAL dal;

        public StgMsg.StgMsg launchGame(StgMsg.StgMsg msg)
        {
            BCquestionnary = new BCGameQuestionnary();
            dal = new DAL.DAL();
            BCquestionnary.setQuestionnary(dal, msg);

            return msg;
        }

        public StgMsg.StgMsg validate(StgMsg.StgMsg msg)
        {
            BCquestionnary = new BCGameQuestionnary();
            BCquestionnary.validate(msg, dal);

            return msg;
        }
    }
}
