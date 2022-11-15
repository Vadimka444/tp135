using System.Linq;
using ElectronicsStore.Models;

namespace ElectronicsStore
{
    public static class DBData
    {
        public static void Initialize(ElectronicsContext context)
        {
            if (!context.Electronics.Any())
            {
                context.Electronics.AddRange(
                    new Electronics
                    {
                        
                        Name = "iPhone 11",
                        Company = "Apple",
                        Class = "Phone",
                        Price =900
                    },
                    new Electronics
                    {
                       
                        Name = "Ipad Air",
                        Company = "Apple",
                        Class = "Tablet",
                        Price = 1200
                    },
                    new Electronics
                    {
                       
                        Name = "AirPods",
                        Company = "Apple",
                        Class = "HeadPhones",
                        Price = 250
                    },
                     new Electronics
                     {
                       
                         Name = "KB272HLHbi",
                         Company = "Acer",
                         Class = "Screen",
                         Price = 200
                     },
                      new Electronics
                      {
                          
                          Name = "Mi TV E55X",
                          Company = "Xiaomi",
                          Class = "TV",
                          Price = 800
                      }
                );
                context.SaveChanges();
            }
        }
    }
}