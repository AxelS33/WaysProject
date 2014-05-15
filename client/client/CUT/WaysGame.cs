using Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace client.CUT
{
    public class WaysGame
    {
        //StgMsg.StgMsg msg;
        private CUC.CUC cuc;
        private Player player;

        public StgMsg.StgMsg launch(StgMsg.StgMsg msg)
        {
            //msg = new StgMsg.StgMsg();
            msg.servName = "WaysGame";
            msg.invoke = "launch";

            cuc = new CUC.CUC();
            player = new Player();
            player.setPseudo((string) msg.data[0]);
            player.setScore(0);

            msg.data[0] = player;
           
            //msg = cuc.callService(msg);

            return msg;
        }
    }
}
