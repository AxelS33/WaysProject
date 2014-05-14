using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WaysGame : Service
    {
        public WaysGame()
        {

        }

        public override StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {
            return msg;
        }
    }

    /*enum GameFunctionalities
    {
        Next = "nextQuestion",
        Previous = "previousQuestion",
        Launch = "launch",
        Validate = "validate",
        Score = "showScore",
    }*/
}
