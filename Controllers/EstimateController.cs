﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResrMvcApp.Controllers
{
    public class EstimateController : Controller
    {
        //
        // GET: /Estimate/

        public ActionResult CreateEstimate()
        {
            return View();
        }

    }
}
