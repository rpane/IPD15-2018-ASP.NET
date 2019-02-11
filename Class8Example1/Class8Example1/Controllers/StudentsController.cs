using Class8Example1.Models;
using System;
using System.Collections;
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

        // GET: Students/Create
        public ActionResult Create()
        {
            ViewBag.ClassList = MvcApplication.classroomList;
            ViewBag.AddressList = MvcApplication.addressList;
            return View();
        }

        // POST: Students/Create    
        [HttpPost]
        public ActionResult Create(Student stu)
        {
            try
            {
                var classroom = MvcApplication.classroomList.Where(c => c.ClassroomId == stu.StudentClassroom.ClassroomId).FirstOrDefault();
                stu.StudentClassroom.Name = classroom.Name;
                stu.StudentClassroom.Number = classroom.Number;

                var address = MvcApplication.addressList.Where(c => c.AddressId == stu.StudentAddress.AddressId).FirstOrDefault();
                stu.StudentAddress.Street = address.Street;
                stu.StudentAddress.City = address.City;
                stu.StudentAddress.PostalCode = address.PostalCode;

               
                    // TODO: Add insert logic here
                    stu.StudentId = ++MvcApplication.studentsIdCount;
                    MvcApplication.studentList.Add(stu);

                    /*
                    ad.AddressId = ++MvcApplication.addressesIdCount;
                    MvcApplication.addressList.Add(ad);

                    cls.ClassroomId = ++MvcApplication.classroomsIdCount;
                    MvcApplication.classroomList.Add(cls);*/

                    return RedirectToAction("Index");
                             
                

            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Details/id
        public ActionResult Details(int id)
        {
            var studentroom = MvcApplication.studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(studentroom);
        }

        // GET: Students/Delete/id
        public ActionResult Delete(int id)
        {
            var studentRoom = MvcApplication.studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(studentRoom);
        }

        // POST: Students/Delete/id
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var studentRoom = MvcApplication.studentList.Where(s => s.StudentId == id).FirstOrDefault();
                MvcApplication.studentList.Remove(studentRoom);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}