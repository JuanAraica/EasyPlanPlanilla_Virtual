using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EasyPlanv2.Models;

namespace EasyPlanv2.Controllers
{
    public class HistorialController : Controller
    {
        private easyPlanEntities db = new easyPlanEntities();

        // GET: Historial
        public ActionResult Index()
        {
            return View(db.Tbl_Historial.ToList());
        }
        public void RegistrarAccion(string registry)
        {
            Tbl_Historial data = new Tbl_Historial();
            data.Registro = registry;
            data.fecha = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            db.Tbl_Historial.Add(data);
            db.SaveChanges();
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
