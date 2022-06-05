using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managem.Controllers
{
    public class ProdectController : Controller
    {
        private readonly IRpotStory<Product> Pro;

        public  ProdectController(IRpotStory<Product> _Pro)
        {
            Pro=_Pro;
        }
            // GET: Prodect
            public ActionResult Index()
        {
            return View(Pro.List());
        }

        // GET: Prodect/Details/5
        public ActionResult Details(int id)
        {
            return View(Pro.Find(id));
        }

        // GET: Prodect/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prodect/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product collection)
        {
            try
            {
                // TODO: Add insert logic here
                Pro.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prodect/Edit/5
        public ActionResult Edit(int id)
        {

            return View(Pro.Find(id));
        }

        // POST: Prodect/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product collection)
        {
            try
            {
                // TODO: Add update logic here
                Pro.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prodect/Delete/5
        public ActionResult Delete(int id)
        {

            return View(Pro.Find(id));
        }

        // POST: Prodect/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product collection)
        {
            try
            {
                // TODO: Add delete logic here
                Pro.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}