using Awarness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Awarness.Controllers
{
    public class IncidentsController : Controller
    {
        ApplicationDbContext context;

        public IncidentsController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Incidents
        public ActionResult Index()
        {
            return View();
        }

        // GET: Incidents/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Incidents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Incidents/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Incidents/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Incidents/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Incidents/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Incidents/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
