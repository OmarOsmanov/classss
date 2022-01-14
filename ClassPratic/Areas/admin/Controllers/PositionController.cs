using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPratic.Areas.admin.Controllers
{
    public class PositionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
