﻿using System;
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
        private int weight;

        public Feature()
        {
        }

        public Feature(string name)
        {
            this.name = name;
            this.weight = 0;
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
