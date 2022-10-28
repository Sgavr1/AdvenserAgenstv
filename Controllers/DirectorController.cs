using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingAgency.Models;
using AdvertisingAgency.Models.CompositeModel;

namespace AdvertisingAgency.Controllers
{
    public class DirectorController : Controller
    {
        private const string postgres = "postgres";
        public static StaffModel staff;
        public static StaffPositionModel staffPosition;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToLogin(int staff_id)
        {
            staff = new StaffModel();
            staffPosition = new StaffPositionModel();
            staff.id = staffPosition.staff_id = staff_id;

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
    }
}
