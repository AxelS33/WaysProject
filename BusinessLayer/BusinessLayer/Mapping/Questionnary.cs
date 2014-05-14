﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Questionnary
    {
        private List<Question> listQuestion;
        private string typeQuestionnary;

        public Questionnary()
        {
            this.typeQuestionnary = "";
            listQuestion = new List<Question>();
        }

        public Questionnary(string type)
        {
            this.typeQuestionnary = type;
        }

        public void setListQuestions(DAL.DAL dal)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(this.typeQuestionnary);
            SqlDataReader reader = dal.executeWithParameter("getAllQuestions", parameters);

            while (reader.Read())
            {
                Question question = new Question((int)reader["IdQuestion"], (string)reader["QuestionDescription"]);
                question.setFeature(new Feature(this.typeQuestionnary));
                question.setOrder((int)reader["QuestionOrder"]);
                question.getAnswers(dal);

                listQuestion.Add(question);
            }
        }
    }
}
