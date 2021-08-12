using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSignosVitales.Controllers
{
    public class ExpedientesController : Controller
    {
        // GET: Expedientes
        public ActionResult Index()
        {
            return View();
        }

        // POS: pacinetes 
        public ActionResult Pacientes()
        {
            return View();
        }

        public ActionResult signosVitales() 
        {
            return View();
        }

        public ActionResult Peso() 
        {
            return View();
        }

        public ActionResult Talla() 
        {
            return View();
        }

        public ActionResult saturacionOxigeno() 
        {
            return View();
        }

        public ActionResult Detalles() 
        {
            return View();
        }

        public ActionResult presionArterial() 
        {
            return View();
        }

        public ActionResult temperaturaCorporal() 
        {
            return View();
        }

        // GET: Expedientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Expedientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expedientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Expedientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Expedientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Expedientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Expedientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
