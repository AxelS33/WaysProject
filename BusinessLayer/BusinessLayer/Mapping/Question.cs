using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
   public class Question
    {
        private int id { get; set; }
        private string description { get; set; }
        public List<Answer> listAnswer { get; set; }
        public Feature feature { get; set; }
        public Answer pickedAnswer { get; set; }
        private int order { get; set; }

        public Question()
        {

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



        internal List<Question> getAllQuestion(DAL.DAL dal)
        {
            //***REAL CODE***//
            List<Question> listQuestion= new List<Question>();
            SqlDataReader readerQuestion = dal.executeProcedure("getAllQuestion");

            while (readerQuestion.Read())
            {
                Question question = new Question();
                question.id = (int)readerQuestion["idQuestion"];
                question.listAnswer = this.getAnswers(dal, question.id);
                
            }
            //**TEST CODE**//
            int cpt = 0;
            while (cpt < 10)
            {
                Question a = new Question();
                a.description = "testDescription";
                a.id = 1;
                listQuestion.Add(a);
                cpt++;
            }
            return listQuestion;
        }

        internal object getId()
        {
            return this.id;
        }

        public List<Answer> getAnswers(DAL.DAL dal, int idQuestion)
        {
            List<Answer> listAnswer = new List<Answer>();
            List<object> parameter = new List<object>();
            parameter.Add(idQuestion);

            SqlDataReader answerReader = dal.executeWithParameter("GetAnswerByIdQuestion", parameter);
            while (answerReader.Read())
            {
                Answer answer = new Answer();
                answer.id = (int)answerReader["idAnswer"];
                answer.description = (string)answerReader["descriptionAnswer"];
                answer.weight = (int)answerReader["weightAnswer"];
                listAnswer.Add(answer);
            }
            answerReader.Close();
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

