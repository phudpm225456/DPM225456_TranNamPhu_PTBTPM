using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Pattern17_Mediator
{
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        {
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: "
                + message);
        }
    }
}
