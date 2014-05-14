using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BC;
using BusinessLayer.Mapping;


namespace BusinessLayer.WC
{
    class WCQuestionnary : abstractWC
    {
        private DAL.DAL dal;

        /*** défini un profil par défaut, et choisi la premiére question ***/
        public StgMsg.StgMsg setProfile(StgMsg.StgMsg oMsg)
        {
            this.dal = new DAL.DAL();
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



        public void weightProfile(StgMsg.StgMsg oMsg)
        {

            Player curentProfile = (Player) oMsg.data[0];
            Question curentQuestion = curentProfile.currentQuestion;
            Answer answer = (Answer)oMsg.data[1];


        }

        /*** appelle les fonction qui choisissent la prochaine question en fonction du poid des features du profil courant***/
        public Question getNextQuestion(StgMsg.StgMsg oMsg)
        {
            object[] ArrayProfile = oMsg.data;
            Player profile = (Player)ArrayProfile.GetValue(0);
            BCQuestionnary oQuestionnary = new BCQuestionnary();
            Question questionPicked = oQuestionnary.chooseQuestion(profile, this.dal);
           
            return questionPicked;


        }
    }
}
