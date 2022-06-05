using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRpotStory<Customer> cust;
        public  CustomerController(IRpotStory<Customer> _cust)
        {
            cust = _cust;
        }
            // GET: Customer
            public ActionResult Index()
        {
            return View(cust.List());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(cust.Find(id));
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer collection)
        {
            try
            {
                // TODO: Add insert logic here
                cust.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View(cust.Find(id));
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer collection)
        {
            try
            {
                // TODO: Add update logic here
                cust.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View(cust.Find(id));
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer collection)
        {
            try
            {
                // TODO: Add delete logic here
                cust.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}