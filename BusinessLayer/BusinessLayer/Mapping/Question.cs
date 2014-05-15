using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
   public class Question
    {
        public int id { get; set; }
        private string description { get; set; }
        public List<Answer> listAnswer { get; set; }
        public Feature feature { get; set; }
        public Answer pickedAnswer { get; set; }
        private int order { get; set; }

        public Question()
        {
            this.listAnswer = new List<Answer>();
            this.feature = new Feature();
            this.pickedAnswer = new Answer();
        }

        public Question(int id, string description)
        {
            this.id = id;
            this.description = description;
        }


        internal Feature getFeature()
        {
            return this.feature;
        }


       //***récupére la liste de toutes les questions dans la base***//
        internal List<Question> getAllQuestion(DAL.DAL dal)
        {
            //***REAL CODE***//
           List<Question> listQuestion= new List<Question>();
           object[] param = new object[2]; 
           param[0] = "@TypeName";
           param[1] = "Orientation";
           SqlDataReader readerQuestion = dal.queryWithParameter("AllQuestions",param);

           dal.OpenConnection();
           readerQuestion.Read();
             while(readerQuestion.Read())
            {
                Question question = new Question();
                question.id = (int)readerQuestion["idQuestion"];
                question.listAnswer = this.getAnswers(dal, question.id);
                question.description = (string)readerQuestion["descriptionQuestion"];
                question.feature = this.getFeatureOfQuestion(dal, question.id);
                question.order = (int)readerQuestion["orderQuestion"];
                listQuestion.Add(question);
            }
             readerQuestion.Close();
             dal.closeConnection();
             
            
          

            //**TEST CODE**//
           /* int cpt = 0;
            while (cpt < 10)
            {
                Question a = new Question();
                a.description = "testDescription";
                a.id = 1;
                listQuestion.Add(a);
                cpt++;
            }*/
            return listQuestion;
        }

        private Feature getFeatureOfQuestion(DAL.DAL dal, int idQuestion)
        {
           /* Hashtable parameter = new Hashtable();
            parameter.Add("@IdQuestion", idQuestion);
            SqlDataReader readerFeature = dal.queryWithParameter("GetAnswers", parameter);

           Feature featureofQuestion = new Feature();
           while (readerFeature.Read())
           {
               featureofQuestion.id = (int) readerFeature["idFeature"];
               featureofQuestion.name = (string)readerFeature["nameFeature"];
               featureofQuestion.weight = 0;
           }
           
           return featureofQuestion; */
            return null;
        }

        internal object getId()
        {
            return this.id;
        }

        public List<Answer> getAnswers(DAL.DAL dal, int idQuestion)
        {
            List<Answer> listAnswer = new List<Answer>();

           object[] parameter = new object[2];
           parameter[0] = "@IdQuestion";
           parameter[1] = idQuestion;

           dal.OpenConnection();
            SqlDataReader answerReader = dal.queryWithParameter("GetAnswers", parameter);
            answerReader.Read();
            while (answerReader.Read())
            {
                Answer answer = new Answer();
                answer.id = (int)answerReader["idAnswer"];
                answer.description = (string)answerReader["descriptionAnswer"];
                answer.weight = (int)answerReader["weightAnswer"];
                listAnswer.Add(answer);
            }
            answerReader.Close();
            dal.closeConnection();

            return listAnswer;
        }

        internal void setFeature(Feature feature)
        {
            this.feature = feature;
        }

        internal void setOrder(int order)
        {
            this.order = order;
        }


    }
}

