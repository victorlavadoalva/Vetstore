using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vetstore.Entities;
using Vetstore.Persistence;
using Vetstore.Persistence.Repositories;

namespace VetStore.MVC.Controllers
{
    public class AtencionesController : Controller
    {
        //private VetStoreContext db = new VetStoreContext();
        private UnityOfWork unityOfWork = UnityOfWork.Instance;

        // GET: Atenciones
        public ActionResult Index()
        {

            //var atenciones = db.Atenciones.Include(a => a.Cliente).Include(a => a.Mascota);
            
            //return View(atenciones.ToList());
            return View(unityOfWork.Atenciones.GetAll());        }

        // GET: Atenciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Atencion atencion = db.Atenciones.Find(id);
            Atencion atencion = unityOfWork.Atenciones.Get(id);

            if (atencion == null)
            {
                return HttpNotFound();
            }
            return View(atencion);
        }

        // GET: Atenciones/Create
        public ActionResult Create()
        {
          //  ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "ClienteId");
          // ViewBag.MascotaId = new SelectList(db.Mascotas, "MascotaId", "MascotaId");
            return View();
        }

        // POST: Atenciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AtencionId,ClienteId,MascotaId")] Atencion atencion)
        {
            if (ModelState.IsValid)
            {
                // db.Atenciones.Add(atencion);
                unityOfWork.Atenciones.Add(atencion);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");

            }

            //ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "ClienteId", atencion.ClienteId);
           // ViewBag.MascotaId = new SelectList(db.Mascotas, "MascotaId", "MascotaId", atencion.MascotaId);
            return View(atencion);
        }

        // GET: Atenciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Atencion atencion = db.Atenciones.Find(id);
            Atencion atencion = unityOfWork.Atenciones.Get(id);

            if (atencion == null)
            {
                return HttpNotFound();
            }
            //ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "ClienteId", atencion.ClienteId);
            //ViewBag.MascotaId = new SelectList(db.Mascotas, "MascotaId", "MascotaId", atencion.MascotaId);
            return View(atencion);
        }

        // POST: Atenciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AtencionId,ClienteId,MascotaId")] Atencion atencion)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(atencion).State = EntityState.Modified;
                unityOfWork.StateModified(atencion);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
          //  ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "ClienteId", atencion.ClienteId);
           // ViewBag.MascotaId = new SelectList(db.Mascotas, "MascotaId", "MascotaId", atencion.MascotaId);
            return View(atencion);
        }

        // GET: Atenciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Atencion atencion = db.Atenciones.Find(id);
            Atencion atencion = unityOfWork.Atenciones.Get(id);

            if (atencion == null)
            {
                return HttpNotFound();
            }
            return View(atencion);
        }

        // POST: Atenciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Atencion atencion = db.Atenciones.Find(id);
            Atencion atencion = unityOfWork.Atenciones.Get(id);
            //db.Atenciones.Remove(atencion);
            unityOfWork.Atenciones.Delete(atencion);
            //db.SaveChanges();
            unityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // db.Dispose();
                unityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
