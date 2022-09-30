using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using CoffeeShop8._3.Models;

namespace CoffeeShop8._3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=ReasonsILoveYou");
            List<Product> products = db.GetAll<Product>().ToList();
            return View(products);
        }
        public IActionResult Detail(string name)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=ReasonsILoveYou");
            Product product = db.GetAll<Product>().Where(p => p.Name == name).First();
            return View(product);
        }
    }
}
