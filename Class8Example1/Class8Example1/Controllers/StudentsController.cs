using Class8Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class8Example1.Controllers
{
    public class StudentsController : Controller
    {

        // GET: Students
        public ActionResult Index()
        {
            return View(MvcApplication.studentList);
        }

        // GET: Students/Edit/id
        public ActionResult Edit(int id)
        {
            var student = MvcApplication.studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(student);
        }

        // POST: Students/Edit
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //Update the students list for the specific student
           
            var student = MvcApplication.studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            student.StudentName = std.StudentName;
            student.Age = std.Age;

            return RedirectToAction("Index");
            //return View("Index", studentList);
        }
    }
}