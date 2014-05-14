using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Feature
    {
        private int id;
        private string name;
        public int weight { get; set; }

        public Feature()
        {
        }

        public Feature(string name)
        {
            this.name = name;
        }

        public Feature(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }


        internal void setId(int id)
        {
            this.id = id;
        }

        internal void setName(string name)
        {
            this.name = name;
        }

        internal void setWeight(int weight)
        {
            this.weight = weight;
        }

        public int getWeight()
        {
            return this.weight;
        }
    }
}
