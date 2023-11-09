using System;
using System.Collections.Generic;

namespace Tymakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 9.1: удалить методы заполнения полей. Вместо этих методов создать конструкторы.");
            Bank1 bank1 = new Bank1(100000);
            Bank1 bank2 = new Bank1(Type.savings);
            Bank1 bank3 = new Bank1(12321312, Type.savings);
            Console.WriteLine($"{bank1.AccountType} {bank1.AccountNumber}, баланс {bank1.AccountBalance} рублей");
            Console.WriteLine($"{bank2.AccountType} {bank2.AccountNumber}, баланс {bank2.AccountBalance} рублей");
            Console.WriteLine($"{bank3.AccountType} {bank3.AccountNumber}, баланс {bank3.AccountBalance} рублей");



            Console.WriteLine("Упр 9.2: Создать новый класс BankTransaction");
            Bank2 bank4 = new Bank2(312321, Type.savings);
            Queue<BankTransaction> transaction;
            int count;
            bank4.DepositMoney(1000);
            bank4.WithdrawMoney(578);
            transaction = bank4.Transactions;
            count = transaction.Count;

            for (int i = 0; i < count; i++)
            {
                BankTransaction transactions = transaction.Dequeue();
                if (transactions.AmountChange < 0)
                {
                    Console.WriteLine($"Снятие {transactions.TransactionDate}, {transactions.AmountChange} рублей");
                }
                else
                {
                    Console.WriteLine($"Пополнение {transactions.TransactionDate}, {transactions.AmountChange} рублей");
                }
            }
        }
    }
}
