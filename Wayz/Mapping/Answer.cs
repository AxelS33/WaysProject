using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
   public class Answer
    {
        private int id;
        private int weight;
        private string description;
       
       public string getDescription() {
           return this.description;
       }

       public void setDescription(string desc)
       {
           this.description = desc;
       }

       public void setScore(int score)
       {
           this.weight = score;
       }

       public int getWeight()
       {
           return this.weight;
       }
    }
}
