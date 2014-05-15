using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Job
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Feature> listFeature { get; set; }
        public int ecart { get; set; }

        public void addFeature(string featureName, int weight)
        {
            this.listFeature.Add(new Feature(featureName, weight));
        }

        public Job()
        {

        }

        public Job(List<Feature> listFeature)
        {
            this.listFeature = listFeature;
        }
    }
}
