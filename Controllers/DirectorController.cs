using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AdvertisingAgency.Models;
using AdvertisingAgency.Models.CompositeModel;

namespace AdvertisingAgency.Controllers
{
    public class DirectorController : Controller
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

            return Redirect("/Director/Staff");
        }

        public IActionResult Staff()
        {
            List<Staff_StaffPosition_Position> staff_staffPositions = DaoMode.GetFullStaffInfo(postgres);

            ViewBag.Staffs = staff_staffPositions;

            return View();
        }



        public IActionResult UpStaff()
        {
            return Redirect("/Director/Staff");
        }

        public IActionResult Out()
        {
            staff = null;
            staffPosition = null;

            return Redirect("/Login");
        }
    }
}
