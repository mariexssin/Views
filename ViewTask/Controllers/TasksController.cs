using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ViewTask.Controllers
{
    public class TasksController : Controller
    {

        public IActionResult SprintTasks()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult ProductInfo()
        {
            return View();
        }

        public IActionResult SuperMarkets()
        {
            ViewBag.Supermarkets = new List<string>
            {
                "WellMart",
                "Silpo",
                "ATB",
                "Furshet",
                "Metro"
            };
            return View();
        }

        public IActionResult ShoppingList()
        {
            var shoppingList = new Dictionary<string, int>
            {
                { "Milk", 2 },
                { "Bread", 2 },
                { "Cake", 1 },
                { "Ice Cream", 5 },
                { "Cola", 10 }
            };

            return View(shoppingList);
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(string fullname, string address)
        {
            ViewBag.Message = $"Your products will be shipped at: {address}. Bon appetite, {fullname}!";
            return View();
        }
    }
}