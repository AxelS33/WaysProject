using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BC;
using BusinessLayer.Mapping;


namespace BusinessLayer.WC
{
  public class WCQuestionnary : abstractWC
    {
        private DAL.DAL dal;

        /*** défini un profil par défaut, et choisi la premiére question ***/
        public StgMsg.StgMsg setProfile(StgMsg.StgMsg oMsg)
        {
           // this.dal = new DAL.DAL(); //COMMENTE POUR LES TEST 
            BCQuestionnary oQuestionnary = new BCQuestionnary();
            Player profile = oQuestionnary.setFeature(dal);

            /***choix de la premiére question a poser***/
            Question questionPicked  = this.getNextQuestion(oMsg);
            profile.currentQuestion = questionPicked;
            profile.askedQuestion.Add(questionPicked);
            
            object[] ArrayProfile = new object[1];
            ArrayProfile.SetValue(profile, 0);
            oMsg.data = ArrayProfile;

            return oMsg;
        }



        public StgMsg.StgMsg weightProfile(StgMsg.StgMsg oMsg)
        {

            Player curentProfile = (Player) oMsg.data[0];
            Question curentQuestion = curentProfile.currentQuestion;
            Answer answer = curentQuestion.pickedAnswer;
            BCQuestionnary questionnary = new BCQuestionnary();
            oMsg = questionnary.weightProfileFeature(oMsg);

            Question questionPicked = this.getNextQuestion(oMsg);
            curentProfile.currentQuestion = questionPicked;
            curentProfile.askedQuestion.Add(questionPicked);
            oMsg.data.SetValue(curentProfile, 0);

            return oMsg;

        }

        /*** appelle les fonction qui choisissent la prochaine question en fonction du poid des features du profil courant***/
        private Question getNextQuestion(StgMsg.StgMsg oMsg)
        {
            object[] ArrayProfile = oMsg.data;
            Player profile = (Player)ArrayProfile.GetValue(0);
            BCQuestionnary oQuestionnary = new BCQuestionnary();
            Question questionPicked = oQuestionnary.chooseQuestion(profile, this.dal);
           
            return questionPicked;


        }

        public StgMsg.StgMsg compareFeature(StgMsg.StgMsg oMsg)
        {
            BCQuestionnary questionnary = new BCQuestionnary();
            List<BCComparison> listComparaison = questionnary.compareProfile(oMsg);
            listComparaison = questionnary.sortJob(listComparaison);

            object[] listJob = new object[listComparaison.Count];
            int cpt= 0;
                foreach(BCComparison compare in listComparaison)
                {
                    listJob.SetValue(compare.job, cpt);
                    cpt++;
                }
                oMsg.data = listJob;

                return oMsg;
        }
    }
}
