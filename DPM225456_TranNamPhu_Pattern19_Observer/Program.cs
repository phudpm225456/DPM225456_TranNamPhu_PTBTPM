﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Pattern19_Observer
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            // Wait for user
            Console.ReadKey();
        }
    }
}
