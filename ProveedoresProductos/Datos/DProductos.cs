using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProductos
    {
        private ProveedoresProductosEntities dbcontext = new ProveedoresProductosEntities();
        public List<Productos> Consultar(int id)
        {
            List<Productos> productosencontrados = dbcontext.Productos.Where(x => x.IdProveedor == id).ToList();
            return productosencontrados;
        }
        public void Altas(Productos productos)
        {
            dbcontext.Productos.Add(productos);
            dbcontext.SaveChanges();
        }
    }
}