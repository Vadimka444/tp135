using ElectronicsStore.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElectronicsStore.Repositories
{
    public class OrderStorage
    {
        private Dictionary<int, Order> Orders { get; } = new Dictionary<int, Order>();

        public void Create(Order order)
        {
            Orders.Add(order.Id, order);
        }

        public Order Read(int Id)
        {
            return Orders[Id];
        }
        
        public Order Update(int Id, Order newOrder)
        {
            Orders[Id] = newOrder;
            return Orders[Id];
        }

        public bool Delete(int Id)
        {
            return Orders.Remove(Id);
        }
    }
}