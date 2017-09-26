using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using UniWebApp.Models;
using UniWebApp.Models.ViewModel;

namespace UniWebApp.Controllers
{
    public class StudentController : Controller
    {
        private AppDbContext _context;

        public StudentController()
        {
            _context = new AppDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult NewCoursesForStudent(Student studentIdt)
        {
            //var student = _context.Students.Include(c => c.Courses).SingleOrDefault(s => s.Id == studentId);
            var kursy = _context.Courses.ToList();

            var CoursesForStudent = new CoursesForStudentViewModel()
            {
                student = studentIdt,
                Courses = kursy
            };

            return View(CoursesForStudent);
        }

        public ActionResult HomeStudent(StudentDropDownListModel studentModel)
        {
            var student = _context.Students.Include(c => c.Courses).SingleOrDefault(s => s.Id == studentModel.MyStudentsId);

            return View(student);
        }

        public ActionResult _NavStudentBar(Student student)
        {
            return View(student);
        }


        public ActionResult ListaZajec(int Id)
        {
            var student = _context.Students.Include(c => c.Courses).SingleOrDefault(s => s.Id == Id);

            return View(student);
        }

        public ActionResult Delete(int studentId)
        {
            var student = _context.Students.Include(c => c.Courses).SingleOrDefault(s => s.Id == studentId);
            var liczbaKursow = student.Courses.Count();
            if (liczbaKursow > 0)
            {
                student.Courses.RemoveRange(0, liczbaKursow - 1);
            }
            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("ListaStudentow", "Admin", new { studentId = studentId });
        }

    }
}
