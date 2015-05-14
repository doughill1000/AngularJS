using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularJS.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View("Index", "", GetSerializedCourseVms());
        }
        public string GetSerializedCourseVms()
        {
            var courses = new[]
            {
                new CourseVm{Number = "1", Name = "History", Instructor = "Mike"},
                new CourseVm{Number = "2", Name = "Math", Instructor = "John"},
                new CourseVm{Number = "3", Name = "Grammar", Instructor = "Thomas"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }
    }
    public class CourseVm
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }    
    }
}