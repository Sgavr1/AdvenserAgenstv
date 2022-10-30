using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingAgency.Models;
using AdvertisingAgency.Models.CompositeModel;

namespace AdvertisingAgency.Controllers
{
    public class ManagerController : Controller
    {
        private const string postgres = "postgres";
        private static StaffModel staff;
        private static StaffPositionModel staffPosition;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToLogin(int id)
        {
            staff = new StaffModel();
            staffPosition = new StaffPositionModel();
            staff.id = staffPosition.staff_id = id;

            DaoMode.GetStaffById(staff, postgres);
            DaoMode.GetStaffPositionByStaffId(staffPosition, postgres);

            return Redirect("/Manager");
        }

        public IActionResult Preference()
        {
            return View();
        }

        public IActionResult Out()
        {
            staff = null;
            staffPosition = null;
            return Redirect("/Login");
        }
    }
}
