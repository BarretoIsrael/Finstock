﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finstock_Barreto.Controllers
{
    public class GraficoController : Controller
    {
      
        public ActionResult PerdaMes()
        {
            return View();
        }
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}