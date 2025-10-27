using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Real15_Interpreter
{
    class Context
    {
        string input;
        int output;
        // Constructor
        public Context(string input)
        {
            this.input = input;
        }
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        public int Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
