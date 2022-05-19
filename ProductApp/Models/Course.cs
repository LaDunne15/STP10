using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string DateStart { get; set; }

        public static int counter = 0;
        public Course()
        {
            this.Id = ++counter;
        }

        public static List<Course> CoursesDB()
        {
            var res = new List<Course>();
            res.Add(new Course { Name = "Course 1", Price = 1000, DateStart = "2022, 12, 19" });
            res.Add(new Course { Name = "Course 2", Price = 900, DateStart = "2022, 11, 1" });
            res.Add(new Course { Name = "Course 3", Price = 850, DateStart = "2022, 6, 7" });
            res.Add(new Course { Name = "Course 4", Price = 1100, DateStart = "2022, 8, 23" });
            res.Add(new Course { Name = "Course 5", Price = 950, DateStart = "2022, 10, 1" });

            return res;
        }
    }
}