using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_OOP
{
    class encapsulation_account_nnr
    {
        private int AccountNumber;
        private int PersonalNumber;
        private int personID;
        private int balance;

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int anount)
        {
            balance -= anount;
        }

        public int GetBalance()
        {
            return balance;
        }

        public void GetPersonID(int id)
        {
            personID = id;
        }
    }

}
