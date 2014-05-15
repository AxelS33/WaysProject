using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
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
            this.listAnswer = new List<Answer>();
        }

        public Question(int id, string description)
        {
            this.listAnswer = new List<Answer>();
            this.id = id;
            this.description = description;
        }

        internal Feature getFeature()
        {
            return this.feature;
        }

        internal object getId()
        {
            return this.id;
        }

        internal void setFeature(Feature feature)
        {
            this.feature = feature;
        }

        public void setOrder(int order)
        {
            this.order = order;
        }

        public void setDescription(string desc)
        {
            this.description = desc;
        }

        public int getOrder()
        {
            return this.order;
        }

        public string getDescription()
        {
            return this.description;
        }

        public List<Answer> getListAnswer()
        {
            return this.listAnswer;
        }
    }
}

