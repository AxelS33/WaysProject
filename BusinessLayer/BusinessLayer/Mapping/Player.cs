using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
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

        public void setFeature(DAL.DAL dal)
        {
            dal.OpenConnection();
           SqlDataReader reader = dal.executeProcedure("AllFeatures");

           reader.Read();
            while (reader.Read())
            {
                Feature feature = new Feature();
                feature.setId((int)reader["IDFEATURE"]);
                feature.setName((String)reader["FEATURENAME"]);
                feature.setWeight(0);

                this.listFeature.Add(feature);
            }

            reader.Close();
            dal.closeConnection();
          

            
        }

        internal List<Feature> getListFeature()
        {
            return this.listFeature;

        }

        internal List<Question> getAskedQuestion()
        {
         return   this.askedQuestion;
        }
    }
}
