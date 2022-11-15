using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Buyer { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int ElectronicsId { get; set; }
        public Electronics electronics { get; set; }
    }
}
