using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class ProveedorController : Controller
    {
        private NProveedores nProveedor = new NProveedores();
        // GET: Proveedor
        public ActionResult IndexProveedor()
        {
            List<Proveedor> proveedor = nProveedor.Consultar();
            return View(proveedor);
        }
        // GET: Proveedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proveedor/Create
        [HttpPost]
        public ActionResult Create(Proveedor proveedor)
        {
            try
            {
                // TODO: Add insert logic here
                    nProveedor.Altas(proveedor);
                    return RedirectToAction("IndexProveedor");
            }
            catch (Exception ex)
            {
                return ViewBag.Message = ex.Message;
            }
        }

        // GET: Proveedor/Edit/5
        public ActionResult Edit(int id)
        {
            Proveedor proveedor = nProveedor.Consultar(id);
            return View(proveedor);
        }

        // POST: Proveedor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Proveedor proveedor)
        {
            try
            {
                // TODO: Add update logic here
                nProveedor.Cambios(proveedor);
                return RedirectToAction("IndexProveedor");
            }
            catch (Exception ex)
            {
                return ViewBag.Message = ex.Message;
            }
        }

        // GET: Proveedor/Delete/5
        public ActionResult Delete(int id)
        {
            Proveedor proveedor = nProveedor.Consultar(id);
            return View(proveedor);
        }

        // POST: Proveedor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                nProveedor.Bajas(id);
                return RedirectToAction("IndexProveedor");
            }
            catch (Exception ex)
            {
                return ViewBag.Message = ex.Message;
            }
        }
    }
}