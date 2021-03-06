﻿using Awarness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Awarness.Controllers
{
    public class RegisteredUsersController : Controller
    {
        ApplicationDbContext context;

        public RegisteredUsersController()
        {
            context = new ApplicationDbContext();
        }

        // GET: RegisteredUsers
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: RegisteredUsers/Details/5
        public ActionResult Details(int RegisteredUserId)
        {
            return View("Details");
        }

        // GET: RegisteredUsers/Create
        public ActionResult Create()
        {
            RegisteredUser regUser = new RegisteredUser();
            return View(regUser);
        }

        // POST: RegisteredUsers/Create
        [HttpPost]
        public ActionResult Create(RegisteredUser regUser)
        {
            try
            {
                // TODO: Add insert logic here
                context.RegisteredUsers.Add(regUser);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisteredUsers/Edit/5
        public ActionResult Edit(int RegisteredUserId)
        {
            return View("Edit");
        }

        // POST: RegisteredUsers/Edit/5
        [HttpPost]
        public ActionResult Edit(int RegisteredUserId, FormCollection collection)
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

        public ActionResult CrimeVisual()
        {
            ViewBag.Message = "Display Crime Data";

            return View();
        }
    }
}
