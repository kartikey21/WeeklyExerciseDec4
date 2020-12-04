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
                    SName="Rohit",
                    SContact="rohit.verma@gmail.com",
                    SDOB=new DateTime(day:17,month:11,year:2002)
                },
                new Student{
                    SId=135,
                    SName="Aditya",
                    SDOB=DateTime.Parse("12/05/1998"),
                    SContact="aditya54@outlook.com"
                },
                new Student
                {
                    SId=126,
                    SName="Lohit",
                    SContact="lohit.verma@gmail.com",
                    SDOB=new DateTime(day:21,month:07,year:1998)
                }
            };
            ViewBag.message = studentList.Count();
            return View(studentList);
        }
    }
}