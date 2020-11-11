using Book_StoreV10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_StoreV10.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
    }
}
