using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Questionnary
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
            listQuestion = new List<Question>();
            this.typeQuestionnary = type;
        }

        public List<Question> getListQuestion()
        {
            return this.listQuestion;
        }

        public void setListQuestion(List<Question> list) {
            this.listQuestion = list;
        }
    
    }
}
