﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Spotinize.Web.Controllers
{
    public class PrivacidadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PoliticaPrivacidade()
        {
            return View();
        }
    }
}