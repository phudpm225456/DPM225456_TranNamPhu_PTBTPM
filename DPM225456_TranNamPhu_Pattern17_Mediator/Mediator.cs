using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Pattern17_Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message,
            Colleague colleague);
    }
}
