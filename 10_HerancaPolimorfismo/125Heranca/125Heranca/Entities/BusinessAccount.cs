using System;
using System.Collections.Generic;
using System.Text;

namespace _125Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        

        public BusinessAccount()
        {

        }

        public BusinessAccount(int numnber, string holder, double balance, double loanLimit) : base(numnber, holder, balance)
        {            
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }       
    }
}
