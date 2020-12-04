using D50WeeklyExercise.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D50WeeklyExercise.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Student> studentList = new List<Student>
            {
                new Student
                {
                    SId=101,
                    SName="Mohit",
                    SContact="mohit.verma@gmail.com",
                    SDOB=new DateTime(day:11,month:01,year:2002)
                },
                new Student
                {
                    SId=109,
                    SName="Taneesha",
                    SContact="dheer.taneesha@gmail.com",
                    SDOB=new DateTime(day:21,month:11,year:2001)
                },
                new Student
                {
                    SId=126,
                    SName="Ankita",
                    SContact="ankita.pandey@gmail.com",
                    SDOB=new DateTime(day:25,month:07,year:1998)
                }
            };
            ViewBag.message = studentList.Count();
            return View(studentList);
        }
    }
}
