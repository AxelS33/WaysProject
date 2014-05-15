using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Player : User
    {
        private int score { get; set; }
        public List<Feature> listFeature{get; set;}
        public List<Question> askedQuestion{get; set;}
        public Question currentQuestion { get; set; }
        public Question nextQuestion {get; set;}

        public Player()
        {
            listFeature = new List<Feature>();
            askedQuestion = new List<Question>();
            this.score = 0;
        }

        internal List<Feature> getListFeature()
        {
            return this.listFeature;

        }

        internal List<Question> getAskedQuestion()
        {
         return   this.askedQuestion;
        }

        public void setScore(int score)
        {
            this.score = score;
        }
    }
}
