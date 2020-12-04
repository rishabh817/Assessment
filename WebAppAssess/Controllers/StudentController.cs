using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppAssess.Models;

namespace WebAppAssess.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Student> students = new List<Student>
         {
             new Student{SId=1,SName="Aditya",SDob=DateTime.Parse("12/05/1998"),SContact="9878988797"},
              new Student{SId=2,SName="Shruti",SDob=DateTime.Parse("12/06/1998"),SContact="9878458797"},
               new Student{SId=3,SName="Pragya",SDob=DateTime.Parse("12/04/1998"),SContact="9834988797"},
                new Student{SId=4,SName="Jaya",SDob=DateTime.Parse("12/07/1998"),SContact="9873488797"},
                 new Student{SId=5,SName="Rahul",SDob=DateTime.Parse("11/05/1998"),SContact="9128988797"},
         };
            ViewBag.message = students.Count();
            return View(students);
        }
    }
}
