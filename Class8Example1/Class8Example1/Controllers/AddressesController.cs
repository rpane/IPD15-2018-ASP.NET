using Class8Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class8Example1.Controllers
{
    public class AddressesController : Controller
    {
        // GET: Addresses
        public ActionResult Index()
        {
            return View(MvcApplication.addressList);
        }

        // GET: Addresses/Details/5
        public ActionResult Details(int id)
        {
            var address = MvcApplication.addressList.Where(s => s.AddressId == id).FirstOrDefault();
            return View(address);
        }

        // GET: Addresses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Addresses/Create
        [HttpPost]
        public ActionResult Create(Address ad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    ad.AddressId = ++MvcApplication.addressesIdCount;
                    MvcApplication.addressList.Add(ad);

                    return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Addresses/Edit/5
        public ActionResult Edit(int id)
        {
            var address = MvcApplication.addressList.Where(s => s.AddressId == id).FirstOrDefault();
            return View(address);
        }

        // POST: Addresses/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Address ad)
        {
            try
            {

                // TODO: Add update logic here
                var address = MvcApplication.addressList.Where(s => s.AddressId == ad.AddressId).FirstOrDefault();
                address.City = ad.City;
                address.PostalCode = ad.PostalCode;
                address.Street = ad.Street;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Addresses/Delete/5
        public ActionResult Delete(int id)
        {
            var address = MvcApplication.addressList.Where(s => s.AddressId == id).FirstOrDefault();
            return View(address);
        }

        // POST: Addresses/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Address ad)
        {
            try
            {
                // TODO: Add delete logic here
                var address = MvcApplication.addressList.Where(s => s.AddressId == id).FirstOrDefault();
                MvcApplication.addressList.Remove(address);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
