using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WaysOriention : Service
    {
        public WaysOriention()
        {

        }

        public override StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {
            /*foreach (string value in Enum.GetValues(typeof(OrientationFunctionalities)))
            {
                if (value == msg.invoke)
                {
                    msg.invoke = msg.invoke + msg.servName;

                    this.bac = new BAC.BAC();
                    this.bac.redirect(msg);
                    return msg;
                }
            }*/

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
