using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniWebApp.Models;
using UniWebApp.Models.ViewModel;

namespace UniWebApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController()
        {
            _context = new AppDbContext();
        }
        public ActionResult Index()
        {
            var studenci = _context.Students.Include(c => c.Courses).ToList();

            return View(studenci);
        }

        public ActionResult LoginAs()
        {
            var listaStudentow = _context.Students.ToList();

            var listaStudentowModel = new StudentDropDownListModel
            {
                Students = listaStudentow
            };

            return View(listaStudentowModel);
        }
    }
}
