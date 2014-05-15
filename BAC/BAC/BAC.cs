using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.WC;


namespace BAC
{
    public class BAC : Ibac
    {


        private WCQuestionnary workflowControler;

        public StgMsg.StgMsg redirect(StgMsg.StgMsg msg)
        {
            
            switch (msg.invoke)
            {
                case "nextQuestionWaysOriention":
                    this.workflowControler = new WCQuestionnary();
                    this.workflowControler.weightProfile(msg);
                    break;
                case "launchWaysOriention":
                    this.workflowControler = new WCQuestionnary();
                    this.workflowControler.setProfile(msg);
                   
                    break;
                case "validateWaysOriention":
                    this.workflowControler = new WCQuestionnary();
                    this.workflowControler.compareFeature(msg);
                    break;
                case "nextQuestionWaysGame":
                    break;
                case "launchWaysGame":
                    break;
                case "validateWaysGame":
                    break;
                case "previousQuestionWaysGame":
                    break;
                case "sendMailWaysOrientation":
                    break;
                case "showScoreWaysGame":
                    break;
                case "addQuestionAdmin":
                    break;
                case "modifyQuestionAdmin":
                    break;
                case "deleteQuestionAdmin":
                    break;
                case "showQuestionAdmin":
                    break;
                case "loginAdmin":
                    break;
                default:
                    return msg;
            }

            return msg;
        }
    }
}
