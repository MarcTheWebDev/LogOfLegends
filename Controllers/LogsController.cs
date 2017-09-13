using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogOfLegends.Models;

namespace LogOfLegends.Controllers
{
    public class LogsController : Controller
    {
        // GET: Logs
        public ActionResult PreviousLogs()
        {
            return View();
        }

    public ActionResult Add() {
      return View();
    }

    public ActionResult SaveGame(Game addedGame) {
      return RedirectToAction("PreviousLogs");
    }
    }
}