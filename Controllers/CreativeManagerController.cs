﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingAgency.Controllers
{
    public class CreativeManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToLogin(int staff_id)
        {
            return Redirect("/CreativeManager");
        }
    }
}
