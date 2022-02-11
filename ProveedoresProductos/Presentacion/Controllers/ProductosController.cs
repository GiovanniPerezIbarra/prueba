using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class ProductosController : Controller
    {
        private NProductos nProducto = new NProductos();
        // GET: Productos
        public ActionResult IndexProductos(int id)
        {
            List<Productos> productos = nProducto.Consultar(id);
            return View(productos);
        }

        // GET: Productos/Create
        public ActionResult Create(int id)
        {
            Productos productos = new Productos()
            {
                IdProveedor = id
            };
            return View(productos);
        }

        // POST: Productos/Create
        [HttpPost]
        public ActionResult Create(Productos producto)
        {
            try
            {
                // TODO: Add insert logic here
                nProducto.Altas(producto);
                return Redirect("../../Proveedor/IndexProveedor");
            }
            catch (Exception ex)
            {
                return ViewBag.Message = ex.Message;
            }
        }
    }
}