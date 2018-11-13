using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TillApi.Models;

namespace TillApi.DataAccessLayer.Interfaces
{
    public interface ISaleItemRepo
    {
        List<SaleItem> GetAllSaleItems();
        SaleItem GetSaleItem(int id);
        void CreateSaleItem(SaleItem item);
        void UpdateSaleItem(SaleItem item);
        void RemoveSaleItem(SaleItem id);
    }
}
