using Class8MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class8MVC.Controllers
{
    public class StudentController : Controller
    {

        public static IList<Students> studentList = new List<Students>()
        {
            new Students() { StudentId=1, StudentName="Rob", Age=20},
            new Students() { StudentId=2, StudentName="Bill", Age=23},
            new Students() { StudentId=3, StudentName="Stef", Age=35},
            new Students() { StudentId=4, StudentName="Frank", Age=33},
            new Students() { StudentId=5, StudentName="Moe", Age=65}
        };
        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }
        // GET: Student/Edit
        public ActionResult Edit(int id)
        {
            var student = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(student);
        }
        // POST: Student/Edit
        [HttpPost]
        public ActionResult Edit(Students stu)
        {
            //UPDATE Student List
            var student = studentList.Where(s => s.StudentId == stu.StudentId).FirstOrDefault();
            student.StudentName = stu.StudentName;
            student.Age = stu.Age;

            /* Victoria
            int index = studentList.IndexOf(student);
            studentList[index] = stu;
            */
            return RedirectToAction("Index");
        }

    }
}