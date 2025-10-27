using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Pattern21_Strategy
{
    class Context
    {
        Strategy strategy;
        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
