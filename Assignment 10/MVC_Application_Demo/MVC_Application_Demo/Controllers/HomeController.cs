using Microsoft.AspNetCore.Mvc;
using MVC_Application_Demo.Models;
using System.Diagnostics;

namespace MVC_Application_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/GetData
        public ActionResult GetData()
        {
            // Perform some data retrieval logic here
            string data = "This is the retrieved data";
            return Content(data);
        }

        // POST: Home/SaveData
        [HttpPost]
        public ActionResult SaveData(string data)
        {
            // Perform some data saving logic here
            // You can access the posted data using 'data' parameter
            // For simplicity, we'll just return a success message
            return Content(data +"\nData saved successfully");
        }
    }
}