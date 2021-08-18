using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities.Exceptions;
using System.Globalization;

namespace Primeiro.Entities
{
    class AccountBank
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public AccountBank()
        {

        }
        public AccountBank(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }


        public void Deposit(double valueDeposit)
        {
            Balance += valueDeposit;
        }

        public void WithDraw(double valueWhithDraw)
        {
            if (Balance <= 0.0)
            {
                throw new DomainException("Error! No balance in your Account!");
            }
            if (WithDrawLimit < valueWhithDraw)
            {
                throw new DomainException("Error! The amount exceeds withdraw limit!");
            }
            if (Balance < valueWhithDraw)
            {
                throw new DomainException("Not enough balance!");
            }

            Balance -= valueWhithDraw;

        }

    }
}
