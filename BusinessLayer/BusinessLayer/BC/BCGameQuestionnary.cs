using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Mapping;

namespace BusinessLayer.BC
{
    class BCGameQuestionnary : abstractBC
    {
        Questionnary questionnary;

        public StgMsg.StgMsg setQuestionnary(DAL.DAL dal)
        {
            questionnary = new Questionnary("game");
            return null;
        }


    }
}
