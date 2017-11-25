using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ddf.Models;

namespace ddf.Controllers
{
    public class AcademicController : Controller
    {
        public IActionResult Education()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult BookChapters()
        {
            return View();
        }

        public IActionResult ReviewedWhitePapers()
        {
            return View();
        }

        public IActionResult ReferenceWork()
        {
            return View();
        }

        public IActionResult Articles()
        {
            return View();
        }
        
        public IActionResult UnpublishedWork()
        {
            return View();
        }

        
        public IActionResult CourseOutlines()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
