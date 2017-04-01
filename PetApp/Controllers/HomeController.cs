using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetApp.Controllers
{
    public class HomeController : Controller
    {
            public IActionResult Index()
            {
                return View();
            }

            public ActionResult Search()
            {
                ViewBag.Message = "Search for a specific pet.";

                return View();
            }

            public ActionResult Add()
            {
                ViewBag.Message = "Add a new pet identification chip.";

                return View();
            }
        }
    }