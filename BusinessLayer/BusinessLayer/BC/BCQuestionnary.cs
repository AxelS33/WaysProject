﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Mapping;
using System.Data.SqlClient;
using System.Collections;

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
            questionPicked.listAnswer = questionPicked.getAnswers(dal, questionPicked.id);
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



        internal List<BCComparison> compareProfile(StgMsg.StgMsg oMsg)
        {
            List<Job> listJob = this.getJobs();
            Player profil = (Player) oMsg.data[0];
            List<Feature> listFeatureProfile = profil.listFeature;
            List<BCComparison> listComparaison = new List<BCComparison>();

            foreach (Job eachJob in listJob)
            {
                BCComparison compare = new BCComparison(eachJob);

                foreach(Feature featureToCompare in listFeatureProfile)
                {
                    compare.compareFeature(featureToCompare); 
                }
                listComparaison.Add(compare);
            }
            return listComparaison;
        }

      

        public List<Job> getJobs()
        {
            DAL.DAL dal = new DAL.DAL();
            SqlDataReader allJobReader = dal.executeProcedure("getAllJob");
            List<Job> listAllJob = new List<Job>();

            while (allJobReader.Read())
            {
                Job job = new Job();
                job.id = (int)allJobReader["idJob"];
                List<Feature> featuresOfTheJob = this.getFeatureOfJob(dal, job.id);
                job.listFeature = featuresOfTheJob;
                job.name = (string)allJobReader["nameJob"];
                job.description = (string)allJobReader["descriptionJob"];
                listAllJob.Add(job);
            }

            allJobReader.Close();
            return listAllJob;
        }
        private List<Feature> getFeatureOfJob(DAL.DAL dal, int idJob)
        {
            object[] param = new object[2];
            param[0] = "@IdProfession";
            param[1] = idJob;

            SqlDataReader featureReader = dal.queryWithParameter("Features_Profession", param);
            List<Feature> listFeatures = new List<Feature>();

            while (featureReader.Read())
            {
                Feature feature = new Feature();
                feature.id = (int) featureReader["idFeature"];
                feature.name = (string)featureReader["nameFeature"];
                feature.weight = (int)featureReader["weightFeature"];

                listFeatures.Add(feature);
            }
            featureReader.Close();
            return listFeatures;
        }

        internal List<BCComparison> sortJob(List<BCComparison> listComparaison)
        {
            IEnumerable<BCComparison> sortJob = from compare in listComparaison
                                          orderby compare.globalEcart
                                          select compare;
            return listComparaison;

        }
    }
}
