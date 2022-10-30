using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingAgency.Controllers
{
    public class ManagerController : Controller
    {
        private const string postgres = "postgres";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToLogin(int staff_id)
        {
            return Redirect("/Manager");
        }
    }
}
