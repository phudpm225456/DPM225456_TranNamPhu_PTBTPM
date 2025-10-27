﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Real20_State
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Open a new account
            Account account = new Account("Jim Johnson");
            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            // Wait for user
            Console.ReadKey();
        }
    }
}
