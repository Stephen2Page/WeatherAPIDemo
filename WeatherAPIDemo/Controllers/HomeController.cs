using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherAPIDemo.Models;

namespace WeatherAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WeatherJS()
        {
            return View();
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }
        public ActionResult GetWeather()
        {
            Weather weath = new Weather();
            return Json(weath.getWeatherForcast(), JsonRequestBehavior.AllowGet);
            
        }
    }
}