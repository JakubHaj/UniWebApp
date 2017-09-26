using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniWebApp.Models;
using System.Data.Entity;
using UniWebApp.Models.ViewModel;

namespace UniWebApp.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContext _context;

        public AdminController()
        {
            _context = new AppDbContext();
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {

            return View();
        }

        public ActionResult DodajStudenta()
        {
            return View();
        }

        public ActionResult DodajKurs()
        {
            return View();
        }

        public ActionResult Save(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("ListaStudentow");
        }

        public ActionResult ListaStudentow()
        {
            var studenci = _context.Students.ToList();

            return View(studenci);
        }

        public ActionResult SaveCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();

            return RedirectToAction("ListaKursow");
        }

        public ActionResult ListaKursow()
        {
            var kursy = _context.Courses.ToList();

            return View(kursy);
        }

        public ActionResult ListaKursowStudenta(int studentId)
        {
            var student = _context.Students.Include(c => c.Courses).SingleOrDefault(s => s.Id == studentId);

            return View(student);
        }
    }
}