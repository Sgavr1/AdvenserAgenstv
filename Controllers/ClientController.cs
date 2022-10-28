using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingAgency.Models;

namespace AdvertisingAgency.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {   
            return View();
        }
        public IActionResult ToLogin(int client_id)
        {
            return Redirect("/Client");
        }
    }
}
