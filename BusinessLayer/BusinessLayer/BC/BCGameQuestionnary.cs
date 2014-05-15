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
        Player player;

        public StgMsg.StgMsg setQuestionnary(DAL.DAL dal, StgMsg.StgMsg msg)
        {
            questionnary = new Questionnary("game");
            questionnary.setListQuestions(dal);

            msg.data[1] = questionnary;

            return msg;
        }

        public StgMsg.StgMsg validate(StgMsg.StgMsg msg, DAL.DAL dal)
        {
            player = (Player)msg.data[0];
            player.createPlayer(dal);
            
            return msg;
        }

    }
}
