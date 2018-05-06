using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MyDBContext:DbContext
    {
        public MyDBContext():base("Defaultconnection")
        {

        }
        public DbSet<Course> Course { get; set; }
        public DbSet<lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}