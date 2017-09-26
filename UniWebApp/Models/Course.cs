using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UniWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}