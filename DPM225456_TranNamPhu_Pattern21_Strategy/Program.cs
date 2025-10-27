using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Pattern21_Strategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            Context context;
            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            // Wait for user
            Console.ReadKey();
        }
    }
}
