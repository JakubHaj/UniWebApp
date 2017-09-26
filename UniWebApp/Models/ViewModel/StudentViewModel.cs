using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniWebApp.Models.ViewModel
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Course> Course { get; set; }
    }
}
