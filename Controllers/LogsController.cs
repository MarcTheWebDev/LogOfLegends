using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogOfLegends.Models;
using System.Data.Entity;
namespace LogOfLegends.Controllers
{
    public class LogsController : Controller
    {
    private ApplicationDbContext _context;

    public LogsController() {
      _context = new ApplicationDbContext();
    }

    protected override void Dispose(bool disposing)
    {
      _context.Dispose();
    }
    // GET: Logs
    public ActionResult PreviousLogs()
        {

      return View(_context.Games.Where(c => c.Id != 0));
        }

    public ActionResult Add() {
      return View();
    }

    public ActionResult SaveGame(Game addedGame) {
      addedGame.DateEntered = DateTime.Now;
      _context.Games.Add(addedGame);
      _context.SaveChanges();
      return RedirectToAction("PreviousLogs");
    }
    }
}