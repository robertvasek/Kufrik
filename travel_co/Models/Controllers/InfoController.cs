using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace travel_co.Models.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult InformationCentre()
        {
            return View();
        }

        public IActionResult Complaints()
        {
            return View();
        }
    }
}

