using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Real14_Command
{
    abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
