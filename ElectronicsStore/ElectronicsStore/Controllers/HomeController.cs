using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ElectronicsStore.Models;

namespace ElectronicsStore.Controllers
{
    public class HomeController : Controller
    {
        ElectronicsContext db;
        public HomeController(ElectronicsContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Electronics.ToList());
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ElectronicsId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.Buyer + " , Благодарим за покупку!";
        }
    }
}