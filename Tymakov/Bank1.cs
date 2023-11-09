using System;

namespace Tymakov
{
    enum Type
    {
        savings,
        current
    }
    internal class Bank1
    {
        private static int generationnumber = 1;
        private int account_number;
        private double account_balance;
        private Type account_type;
        public int AccountNumber
        {
            get { return account_number; }
        }
        public double AccountBalance
        {
            get { return account_balance; }
        }
        public Type AccountType
        {
            get { return account_type; }
        }
        private void GenerationNumber()
        {
            generationnumber++;
        }
        public void DepositMoney(double amount)
        {
            if (amount > 0)
            {
                account_balance += amount;
                Console.WriteLine($"Счет пополнен на - {amount} , текущий баланс -{account_balance} ");
            }
            else
            {
                Console.WriteLine("Введите число больше 0");
            }

        }
        public bool WithdrawMoney(double amount)
        {
            if (amount > 0)
            {
                if (amount <= account_balance)
                {
                    account_balance -= amount;
                    Console.WriteLine($"Со счета было снято - {amount} , текущий баланс - {account_balance}");
                    return true;
                }
                else
                {
                    Console.WriteLine("На балансе недостаточно средств");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Введите число больше 0");
                return false;
            }

        }
        public void Transfer(Bank1 bank, double amount)
        {
            if (WithdrawMoney(amount))
            {
                bank.DepositMoney(amount);
                Console.WriteLine("Перевод был успешно проведен");
            }
            else { Console.WriteLine("Не удалось провести перевод"); }
        }
        public Bank1(double account_balance)
        {
            this.account_balance = account_balance;
            account_type = Type.current;
            account_number = generationnumber;
            GenerationNumber();
        }
        public Bank1(Type account_type)
        {
            this.account_type = account_type;
            account_balance = 0;
            account_number = generationnumber;
            GenerationNumber();
        }
        public Bank1(double account_balance, Type account_type)
        {
            this.account_balance = account_balance;
            this.account_type = account_type;
            account_number = generationnumber;
            GenerationNumber();
        }
    }
}







