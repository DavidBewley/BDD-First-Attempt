using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TillApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public List<int> ItemsSoldIds { get; set; }
        public int CustomerId { get; set; }
        public decimal TransactionPrice { get; set; }
    }
}
