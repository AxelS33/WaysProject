using BusinessLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BC
{
    class BCComparison : abstractBC
    {
        public Job job { get; set; }
        public int globalEcart{ get; set; }

        public BCComparison(Job job)
        {
            this.job = job;
            this.globalEcart = 0;
        }

        public void compareFeature(Feature featureToCompare)
        {
            List<Feature> featuresOfThisJob = this.job.listFeature;
            

            foreach (Feature aFeature in featuresOfThisJob)
            {
                int localEcart = 0;
                if (aFeature == featureToCompare)
                {
                    localEcart = aFeature.getWeight() - featureToCompare.getWeight();
                    if (localEcart < 0){
                        localEcart = localEcart * (-1);
                    }
                    this.globalEcart += localEcart;
                }
            }
        }
    }
}
