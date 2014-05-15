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
            this.player = new Player();
            this.player.setPseudo((string) msg.data[0]);
            this.player.setScore(0);

            msg.data[0] = this.player;
           
            //msg = cuc.callService(msg);

            return msg;
        }

        
    }
}
