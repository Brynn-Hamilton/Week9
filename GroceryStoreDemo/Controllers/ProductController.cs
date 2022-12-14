using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using GroceryStoreDemo.Models;

namespace GroceryStoreDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Copy this line from another app you built
            // and change the database to grocerystore

            var db = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=ReasonsILoveYou");
            List<Product> products = db.GetAll<Product>().ToList();
            return View(products);
        }
    }
}
