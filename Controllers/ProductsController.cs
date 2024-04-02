using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KhumaloCraft.Controllers
{
  
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Products(string name, int price = 1     )
            //Simulate fetching products from a database
            
        {
            
            
            return View();
        }
    }
}

