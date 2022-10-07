﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASP.MVC.Lab.Models;

namespace ITMO.ASP.MVC.Lab.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" :
         "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View(); 
        }

        //public string Index(string hel)
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = ITMO.ASP.MVC.Lab.Models.ModelClass.ModelHello() + ", " + hel; ; 
        //    return Greeting;
        //}

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }

        private static PersonRepository db = new PersonRepository();

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }
    }
}