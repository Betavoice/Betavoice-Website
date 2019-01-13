using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Betavoice.Models;

namespace Betavoice.Controllers
{
    public class TracksController : Controller
    {

        private ApplicationDbContext _context;

        public TracksController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Music
        public ViewResult Index()
        {
            


            return View("List");
        }
    }
}