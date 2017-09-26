using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UniWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public byte Age { get; set; }
        public List<Course> Courses { get; set; }
        public byte CoursesId { get; set; }
    }
}