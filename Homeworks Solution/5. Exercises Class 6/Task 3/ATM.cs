using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ATM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CardNumber { get; set; }
        protected int Pin { get; set; }
        protected int Balance { get; set; }

        public ATM() { }
        public ATM (string firstName, string lastName,  string cardNumber, int pin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }

        public int getPin()
        {
            return Pin;
        }
        public int getBalance()
        {
            return Balance;
        }

        public string CheckBalance()
        {
            return $"Avaliable Balance on your account: {Balance}$";
        }

        public void CashWithdrawal (int inputWithdrawCash)
        {
            if (inputWithdrawCash > Balance)
            {
                Console.WriteLine($"Insufficient funds, your balance is {Balance}$");
            }
            else
            {
                int remainedBalance = Balance - inputWithdrawCash;
                Console.WriteLine($"You just withdrawn {inputWithdrawCash}$ and the remained balance of your account is {remainedBalance}$");
            }
             
        }
        public void CashDeposit (int inputDepositCash)
        {
            Balance += inputDepositCash;
            Console.WriteLine($"You just Deposited {inputDepositCash}$ and the new Balance is: {Balance}$");
        }
    }
}
