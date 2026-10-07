using System.Web.Mvc;
using VehicleBookingSystem.Models;

namespace VehicleBookingSystem.Controllers
{
    public class BookingController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Booking booking)
        {
            return View("Payment", booking);
        }

        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}