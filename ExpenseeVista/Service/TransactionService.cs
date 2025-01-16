using System;
using System.Collections.Generic;
using System.Linq;
using ExpenseeVista.Model;

public class TransactionService
    {
        public List<Transaction> Transactions { get; private set; } = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            if (transaction != null)
            {
                throw new InvalidOperationException("Insufficient balance for this debit transaction.");
            }
            Transactions.Add(transaction);
        }
    }


