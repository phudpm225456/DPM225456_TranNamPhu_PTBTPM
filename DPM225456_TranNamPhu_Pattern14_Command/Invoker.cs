﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Pattern14_Command
{
    class Invoker
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
