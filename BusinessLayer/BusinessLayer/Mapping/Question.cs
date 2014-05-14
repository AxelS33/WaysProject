using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Question
    {
        private int id { get; set; }
        private string description { get; set; }
        public List<Answer> listAnswer { get; set; }
        private Feature feature { get; set; }
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
            throw new NotImplementedException();
        }

        internal object getId()
        {
            return this.id;
        }

        public List<Answer> getAnswers(DAL.DAL dal)
        {
            List<Answer> listAnswer = new List<Answer>();
            SqlDataReader answerReader = dal.executeProcedure("getAnswer");
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

