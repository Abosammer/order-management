using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managem.Controllers
{
    public class OrderController : Controller
    {
        private readonly IRpotStory<Order> Ordr;
        public  OrderController(IRpotStory<Order> _Ordr)
        {
            Ordr =_Ordr;
        } // GET: Order
            public ActionResult Index()
        {
            return View(Ordr.List());
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View(Ordr.Find(id));
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order collection)
        {
            try
            {
                // TODO: Add insert logic here
                Ordr.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Ordr.Find(id));
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order collection)
        {
            try
            {
                // TODO: Add update logic here
                Ordr.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Ordr.Find(id));
        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order collection)
        {
            try
            {
                // TODO: Add delete logic here
                Ordr.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}