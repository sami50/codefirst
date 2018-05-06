using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class lecture
    {
        [Key]
        public int LectureID { get; set; }

        public string LectureName { get; set; }

        public IList <Course> Courses { get; set; }

        

    }
}