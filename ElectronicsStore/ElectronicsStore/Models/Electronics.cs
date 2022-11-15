using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsStore.Models
{
    public class Electronics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Class { get; set; }
        public int Price { get; set; }
    }
}
