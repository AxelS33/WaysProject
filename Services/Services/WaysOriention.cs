using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WaysOriention : Service
    {

        public List<String> listeInvoke;
        public WaysOriention()
        {
            this.listeInvoke = new List<string>();
            listeInvoke.Add("nextQuestion");
            listeInvoke.Add("launch");
            listeInvoke.Add("validate");
            listeInvoke.Add("sendMail");

        }

        public override StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {
            foreach (string value in this.listeInvoke)
            {
                if (value == msg.invoke)
                {
                    msg.invoke = msg.invoke + msg.servName;

                    this.bac = new BAC.BAC();
                    this.bac.redirect(msg);
                    return msg;
                }
            }

            msg.statut = false;
            return msg;
        }

       
    }

    /*enum OrientationFunctionalities
    {
        Next = "nextQuestion",
        Launch = "launch",
        Validate = "validate",
        Send = "sendMail",
    }*/
}
