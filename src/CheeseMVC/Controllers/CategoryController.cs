using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Data;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {

        private readonly CheeseDbContext context;    //readonly allows for a one time write during init

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        //creates a private field context of type CheeseDbContext.
        //mechanism to interact with objects stored in the database
        //MVC framework creates an instance of CheeseDbContext and passes in into the constructor




        public IActionResult Index()
        {
            List<CheeseCategory> categories = context.Categories.ToList();
            return View(categories);
        }
    }
}