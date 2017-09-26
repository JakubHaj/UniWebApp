using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniWebApp.Models.ViewModel
{
    public class CoursesForStudentViewModel
    {
        public Student student { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public int CoursesId { get; set; }
    }
}