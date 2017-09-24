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

    public ActionResult ChangeGame(int id = 0) {
      if (id == 0)
      {
      }
      else
      {
        var game = _context.Games.Single(g => g.Id == id);
        return View("LogForm", game);
      }
      return View("LogForm");
    }

    public ActionResult SaveGame(Game game) {
      if (game.Id == 0)
      {
        game.DateEntered = DateTime.Now;
        _context.Games.Add(game);
        _context.SaveChanges();
      }
      else {
       var editedGame =  _context.Games.Single(g => g.Id == game.Id);
        TryUpdateModel(editedGame);
      }
     
      return RedirectToAction("PreviousLogs");
    }
    }
}