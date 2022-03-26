using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySQLFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {
        private RecipesDbContext _context { get; set; }
        //Constructor
        public HomeController(RecipesDbContext temp)
        {
            _context = temp;
        }
        //Index view
        public IActionResult Index()
        {
            var blah = _context.Recipes
                .FromSqlRaw("Select * FROM Recipes ORDER BY RecipeTitle")
                .ToList();
            return View(blah);
        }
    }
}

