using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using K_PBL_test1.Data;
using K_PBL_test1.Models;


namespace K_PBL_test1.Controllers
{
    public class AcceptableCenterController : Controller
    {
        private readonly AcceptableContext _context;
        public AcceptableCenterController(AcceptableContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            AcceptableCenterViewModel myview = new AcceptableCenterViewModel();
            myview.Centers = _context.Centers;
            myview.AcceptableLevels = _context.AcceptableLevels;
            return View(myview);
        }

    }
}