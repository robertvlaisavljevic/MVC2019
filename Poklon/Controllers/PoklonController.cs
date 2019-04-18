﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Poklon.Models;

namespace Poklon.Controllers
{
    public class PoklonController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Poklon
        public ActionResult Index()
        {
            List<Models.Poklon> listaPoklona = (from p in _db.Pokloni select p).ToList();
            return View(listaPoklona);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                _db.Pokloni.Add(poklon);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}