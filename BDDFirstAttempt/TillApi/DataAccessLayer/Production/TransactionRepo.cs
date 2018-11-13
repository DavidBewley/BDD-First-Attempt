using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TillApi.DataAccessLayer.Interfaces;
using TillApi.Models;

namespace TillApi.DataAccessLayer.Production
{
    public class TransactionRepo : ITransactionRepo
    {
        public void CreateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
