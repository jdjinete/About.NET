using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.WCFServiceClient;

namespace UI.Controllers
{
    public class CrudClienteController : Controller
    {
        //
        // GET: /CrudCliente/
        ServiceClienteClient a = new ServiceClienteClient();
        public ActionResult Index()
        {

            var list = a.selectCliente().Select(c => 
                new ModeloDatos.tbCliente
              {
                  Sexo = c.Sexo,
                  FechaNacimiento=c.FechaNacimiento,
                  Nombre=c.Nombre
              });

            return View(list);
        }

        //
        // GET: /CrudCliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CrudCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CrudCliente/Create
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

        //
        // GET: /CrudCliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CrudCliente/Edit/5
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

        //
        // GET: /CrudCliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CrudCliente/Delete/5
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
