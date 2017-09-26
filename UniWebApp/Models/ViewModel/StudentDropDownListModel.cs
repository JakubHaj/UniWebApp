using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniWebApp.Models.ViewModel
{
    public class StudentDropDownListModel
    {
        public IEnumerable<Student> Students { get; set; }
        public int MyStudentsId { get; set; }
    }
}