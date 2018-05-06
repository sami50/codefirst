using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }

    }
}