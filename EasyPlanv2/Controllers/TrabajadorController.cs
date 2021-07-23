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
    public class TrabajadorController : Controller
    {
        private easyPlanEntities db = new easyPlanEntities();
        private HistorialController historial = new HistorialController();
        // GET: Trabajador
        public ActionResult Index()
        {
            historial.RegistrarAccion("Se ha consultado el registro de los trabajadores");
            return View(db.Tbl_Trabajador.ToList());
        }

        // GET: Trabajador/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Trabajador tbl_Trabajador = db.Tbl_Trabajador.Find(id);
            if (tbl_Trabajador == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Trabajador);
        }

        // GET: Trabajador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabajador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CedulaTra,Nombre,Apellido,Puesto,Edad,Telefono,Correo,FechaNacimiento,Nacionalidad,NumEmpleado,Ciudad,Direccion,FechaEmpleo,Empleador,FechaDespido,InicioIncapacidad,FinalIncapacidad,Padecimientos,Estado,Observacion")] Tbl_Trabajador tbl_Trabajador)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Trabajador.Add(tbl_Trabajador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Trabajador);
        }

        // GET: Trabajador/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Trabajador tbl_Trabajador = db.Tbl_Trabajador.Find(id);
            if (tbl_Trabajador == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Trabajador);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CedulaTra,Nombre,Apellido,Puesto,Edad,Telefono,Correo,FechaNacimiento,Nacionalidad,NumEmpleado,Ciudad,Direccion,FechaEmpleo,Empleador,FechaDespido,InicioIncapacidad,FinalIncapacidad,Padecimientos,Estado,Observacion")] Tbl_Trabajador tbl_Trabajador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Trabajador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Trabajador);
        }

        // GET: Trabajador/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Trabajador tbl_Trabajador = db.Tbl_Trabajador.Find(id);
            if (tbl_Trabajador == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Trabajador);
        }

        // POST: Trabajador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tbl_Trabajador tbl_Trabajador = db.Tbl_Trabajador.Find(id);
            db.Tbl_Trabajador.Remove(tbl_Trabajador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string CedulaTra,string Correo)
        {
            if (ModelState.IsValid)
            {
                Tbl_Trabajador tra=db.Tbl_Trabajador.Find(CedulaTra);
                if (tra!=null)
                {
                    if (tra.Correo==Correo)
                    {
                        Session["Usuario"] = tra.Nombre + " "+tra.Apellido;
                        return RedirectToAction("Index");
                    }                   
                }                
            }
            return View();
        }
    }
}
