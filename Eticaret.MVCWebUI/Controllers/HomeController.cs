using Eticaret.MVCWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();



        // GET: Home
        public ActionResult Index()
        {
  
            return View(_context.Urunler.Where( x=>x.Aktif && x.iseAnasayfa).ToList());
        }


        public ActionResult Detay(int id)
        {
            return View(_context.Urunler.Where(x => x.Id == id).FirstOrDefault());
        }



        public ActionResult Liste()
        {
            return View(_context.Urunler.Where(x => x.Aktif).ToList());
        }

    }
}