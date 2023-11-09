using System;

namespace Tymakov
{
    internal class BankTransaction
    {
        private DateTime transactionDate;
        private double amountChange;
        public DateTime TransactionDate
        {
            get
            {
                return transactionDate;
            }
        }
        public double AmountChange
        {
            get
            {
                return amountChange;
            }
        }

        public BankTransaction(double amountChange)
        {
            this.amountChange = amountChange;
            transactionDate = DateTime.Now;
        }
    }
}
