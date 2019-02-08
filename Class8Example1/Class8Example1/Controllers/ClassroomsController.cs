using Class8Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class8Example1.Controllers
{
    public class ClassroomsController : Controller
    {
        // GET: Classrooms
        public ActionResult Index()
        {
            //ViewBag.ClassroomList = MvcApplication.classroomList;
            
            //HttpContext.Application["ClassroomList"] = MvcApplication.classroomList;
            //Session["ClassroomList"] = MvcApplication.classroomList;

            return View(MvcApplication.classroomList);
        }

        // GET: Classrooms/Details/5
        public ActionResult Details(int id)
        {
            var classRoom = MvcApplication.classroomList.Where(s => s.ClassroomId == id).FirstOrDefault();
            return View(classRoom);
        }

        // GET: Classrooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Classrooms/Create
        [HttpPost]
        public ActionResult Create(Classroom cr)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    cr.ClassroomId = ++ MvcApplication.classroomsIdCount;
                    MvcApplication.classroomList.Add(cr);

                    return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Classrooms/Edit/5
        public ActionResult Edit(int id)
        {
            var classRoom = MvcApplication.classroomList.Where(s => s.ClassroomId == id).FirstOrDefault();
            return View(classRoom);
        }

        // POST: Classrooms/Edit/5
        [HttpPost]
        public ActionResult Edit(Classroom cr)
        {
            try
            {

                // TODO: Add update logic here
                var classroom = MvcApplication.classroomList.Where(s => s.ClassroomId == cr.ClassroomId).FirstOrDefault();
                classroom.Name = cr.Name;
                classroom.Number = cr.Number;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Classrooms/Delete/5
        public ActionResult Delete(int id)
        {
            var classRoom = MvcApplication.classroomList.Where(s => s.ClassroomId == id).FirstOrDefault();
            return View(classRoom);
        }

        // POST: Classrooms/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var classroom = MvcApplication.classroomList.Where(s => s.ClassroomId == id).FirstOrDefault();
                MvcApplication.classroomList.Remove(classroom);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
