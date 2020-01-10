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
            return View(context.Incidents.ToList());
        }

        // GET: Incidents/Details/5
        public ActionResult Details(int id)
        {
            Incident incident = context.Incidents.Where(i => i.IncidentReferenceNumber == id).SingleOrDefault();
            return View(incident);
        }

        // GET: Incidents/Create
        public ActionResult Create()
        {
            Incident newIncident = new Incident();
            return View(newIncident);
        }

        // POST: Incidents/Create
        [HttpPost]
        public ActionResult Create(Incident incident)
        {
            try
            {
                context.Incidents.Add(incident);
                context.SaveChanges();
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
            Incident incident = context.Incidents.Where(i => i.IncidentReferenceNumber == id).SingleOrDefault();
            return View(incident);
        }

        // POST: Incidents/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Incident incident)
        {
            try
            {
                Incident editedIncident = context.Incidents.Find(id);
                editedIncident.IncidentType = incident.IncidentType;
                editedIncident.IncidentTime = incident.IncidentTime;
                editedIncident.IncidentDate = incident.IncidentDate;
                editedIncident.IncidentLocation = incident.IncidentLocation;
                editedIncident.AdditionalDetails = incident.AdditionalDetails;
                context.SaveChanges();

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
            Incident incident = context.Incidents.Where(i => i.IncidentReferenceNumber == id).SingleOrDefault();
            return View(incident);
        }

        // POST: Incidents/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Incident incident)
        {
            try
            {
                context.Incidents.Remove(context.Incidents.Find(id));
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
