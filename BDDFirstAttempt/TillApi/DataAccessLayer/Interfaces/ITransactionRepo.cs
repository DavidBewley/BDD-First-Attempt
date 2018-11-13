using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TillApi.Models;

namespace TillApi.DataAccessLayer.Interfaces
{
    public interface ITransactionRepo
    {
        List<Transaction> GetAllTransactions();
        Transaction GetTransaction(int id);
        void CreateTransaction(Transaction transaction);
        void UpdateTransaction(Transaction transaction);
        void RemoveTransaction(int id);
    }
}
