using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Id.Mvc4.Sample.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Models.LibraryEntities libraryDB = new Models.LibraryEntities();

            var formats = libraryDB.Formats.OrderBy(f => f.Name).ToList();
            ViewBag.FormatId = new SelectList(formats, "FormatId", "Name");

            var subjects = libraryDB.Subjects.OrderBy(s => s.Name).ToList();
            ViewBag.SubjectId = new SelectList(subjects, "SubjectId", "Name");

            return View();
        }
    }
}
