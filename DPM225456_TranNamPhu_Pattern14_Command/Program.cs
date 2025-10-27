using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Pattern14_Command
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create receiver, command, and invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            // Wait for user
            Console.ReadKey();
        }
    }
}
