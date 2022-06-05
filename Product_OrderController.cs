using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Managem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managem.Controllers
{
    public class Product_OrderController : Controller
    {
        private readonly IRpotStory<Product_Order> Produt_Order;
        public  Product_OrderController(IRpotStory<Product_Order> _Produt_Order)
        {
            Produt_Order = _Produt_Order;
        }

            // GET: Product_Order
            public ActionResult Index()
        {
            return View(Produt_Order.List());
        }

        // GET: Product_Order/Details/5
        public ActionResult Details(int id)
        {
            return View(Produt_Order.Find(id));
        }

        // GET: Product_Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product_Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product_Order collection)
        {
            try
            {
                // TODO: Add insert logic here
                Produt_Order.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product_Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Produt_Order.Find(id));
        }

        // POST: Product_Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product_Order collection)
        {
            try
            {
                // TODO: Add update logic here
                Produt_Order.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product_Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Produt_Order.Find(id));
        }

        // POST: Product_Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product_Order collection)
        {
            try
            {
                // TODO: Add delete logic here
                Produt_Order.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}