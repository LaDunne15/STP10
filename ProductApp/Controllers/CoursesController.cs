using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductApp.Controllers
{
    public class CoursesController : ApiController
    {
        static List<Course> courses = Course.CoursesDB();

        [HttpGet]
        public IHttpActionResult Get()
        {
            if (courses.Count == 0)
                return StatusCode(HttpStatusCode.NoContent);

            return Json(courses);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            Course book = courses.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound();

            return Json(book);
        }
    }
}
