using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managem.Controllers
{
    public class StockController : Controller
    {
        private readonly IRpotStory<Stock> Stck;
        public StockController(IRpotStory<Stock> _Stck)
        {
            Stck = _Stck;


        }
            // GET: Stock
            public ActionResult Index()
        {
            return View(Stck.List());
        }

        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {

            return View(Stck.Find(id));
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stock collection)
        {
            try
            {
                // TODO: Add insert logic here
                Stck.Add(collection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Stck.Find(id));
        }

        // POST: Stock/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Stock collection)
        {
            try
            {
                // TODO: Add update logic here
                Stck.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Stck.Find(id));
        }

        // POST: Stock/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Stock collection)
        {
            try
            {
                // TODO: Add delete logic here
                Stck.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}