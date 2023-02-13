using ElectronicsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectronicsStore.Repositories;

namespace ElectronicsStore.Controllers
{
    [ApiController]
    [Route("/order")]
    public class OrderController : ControllerBase
    {
        [HttpPut]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return order;
        }

        [HttpGet]
        public Order Read(int Id)
        {
            return Storage.OrderStorage.Read(Id);
        }

        [HttpPatch]
        public Order Update(int Id, Order newOrder)
        {
            return Storage.OrderStorage.Update(Id, newOrder);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.OrderStorage.Delete(Id);
        }
    }

}
