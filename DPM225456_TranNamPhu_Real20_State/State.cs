﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Real20_State
{
    abstract class State
    {
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        // Properties
        public Account Account
        {
            get { return account; }
            set { account = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}
