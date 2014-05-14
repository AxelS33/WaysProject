using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Mapping;
using System.Data.SqlClient;

namespace BusinessLayer.BC
{
    class BCQuestionnary : abstractBC
    {

        public Player setFeature(DAL.DAL dal)
        {
            Player player = new Player();
            player.setFeature(dal);
            return player;
        }

        

        public StgMsg.StgMsg weightProfileFeature(StgMsg.StgMsg msg)
        {
            Player currentProfile = (Player) msg.data[0];
            Feature featureToWeight = currentProfile.currentQuestion.feature;
            int weightToAdd = featureToWeight.weight;

            foreach(Feature curentFeature in currentProfile.listFeature)
            {
                if (curentFeature == featureToWeight)
                {
                    curentFeature.weight = weightToAdd;
                }
            }
            msg.data.SetValue(currentProfile, 0);
            return msg;

        }

        public Question chooseQuestion(Player player , DAL.DAL dal)
        {
            Question questionPicked = new Question();
            List<Question> listQuestion = questionPicked.getAllQuestion(dal);
            bool found = false;

            foreach (Question curQuestion in listQuestion)
            {
                foreach (Feature eachfeature in player.getListFeature())
                {
                    if ((curQuestion.getFeature() == eachfeature) && (eachfeature.getWeight() > 5) && (this.questionAsked(curQuestion, player.getAskedQuestion())))
                    {
                        found = true;
                    }
                }

                if (found == true)
                {
                    questionPicked = curQuestion;
                    break;
                }
            }
            questionPicked.listAnswer = questionPicked.getAnswers(dal);
            return questionPicked;
            
        }

        private bool questionAsked(Question question, List<Question> askedQuestion)
        {
            bool found = false;
            foreach (Question eachQuestion in askedQuestion)
            {
                if (question.getId() == eachQuestion.getId())
                {
                    found = true;
                }
            }
            return found;
        }



        internal void compareProfile(StgMsg.StgMsg oMsg)
        {
            DAL.DAL dal = new DAL.DAL();
            SqlDataReader AllJobReader = dal.executeProcedure("getAllJob");
            List<Job> listAllJob = new List<Job>();

            while (AllJobReader.Read())
            {
                Job job = new Job();
                this.getFeatureOfJob(dal);
            }

         
        }

        private void getFeatureOfJob(DAL.DAL dal)
        {
           // SqlDataReader featureReader = dal.executeWithParameter(
        }
    }
}
