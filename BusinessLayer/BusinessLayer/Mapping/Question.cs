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
        public Feature feature { get; set; }
        public Answer pickedAnswer { get; set; }
        private int order { get; set; }

        public Question( )
        {
           
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
            SqlDataReader answerReader = dal.executeProcedure("getAnswer") ;
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
    }
}
