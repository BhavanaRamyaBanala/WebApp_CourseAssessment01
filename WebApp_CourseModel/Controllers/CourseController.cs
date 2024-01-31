using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_CourseModel.Models;

namespace WebApp_CourseModel.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>() {
            new Course{ CId=1,CName="Data Science",CFee=6500,Technology="Artificial Intelligence",CStartDate=new DateTime(day:23,month:11,year:2022),CEndDate=new DateTime(day:23,month:11,year:2023)},
            new Course{ CId=2,CName="Programming",CFee=7500,Technology="Java",CStartDate=new DateTime(day:5,month:1,year:2023),CEndDate=new DateTime(day:5,month:1,year:2024)},
            new Course{ CId=3,CName="DataBase",CFee=5000,Technology="SQL",CStartDate=new DateTime(day:17,month:6,year:2020),CEndDate=new DateTime(day:17,month:6,year:2020)},
            new Course{ CId=4,CName="Web Development",CFee=8000,Technology="Javascript",CStartDate=new DateTime(day:8,month:3,year:2020),CEndDate=new DateTime(day:8,month:3,year:2021)}
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create() { 
        return View(new Course());  
        }
        [HttpPost]
        public ActionResult Create(Course c) {
            if (ModelState.IsValid) {
                courses.Add(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }

    }
}