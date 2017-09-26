using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniWebApp.Models;
using System.Data.Entity;

namespace UniWebApp.Controllers
{
    public class CourseController : Controller
    {

        private AppDbContext _context;

        public CourseController()
        {
            _context = new AppDbContext();
        }

        public ActionResult Remove(int kursId)
        {
            var kurs = _context.Courses.SingleOrDefault(c => c.Id == kursId);
            _context.Courses.Remove(kurs);
            _context.SaveChanges();

            return RedirectToAction("ListaKursow", "Admin");
        }

        public ActionResult Delete(int kursId, int stId)
        {
            var student = _context.Students.Include(c => c.Courses).SingleOrDefault(s => s.Id == stId);
            var kurs = student.Courses.SingleOrDefault(c => c.Id == kursId);

            student.Courses.Remove(kurs);
            _context.SaveChanges();

            return RedirectToAction("ListaKursowStudenta", "Admin", new { studentId = stId });
        }


        public ActionResult Save(IEnumerable<int> zajeciaId, int studentId)
        {
            var student = _context.Students.Include(c => c.Courses).SingleOrDefault(s => s.Id == studentId);

            foreach (var zmiennaId in zajeciaId)
            {
                var kurs = _context.Courses.SingleOrDefault(c => c.Id == zmiennaId);
                if (!student.Courses.Contains(kurs))
                {
                    student.Courses.Add(kurs);
                }
            }

            _context.SaveChanges();
            return RedirectToAction("ListaZajec", "Student", new { id = studentId });
        }


        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
    }
}