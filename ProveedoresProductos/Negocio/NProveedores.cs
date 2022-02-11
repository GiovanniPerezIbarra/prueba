using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProveedores
    {
        private DProveedores _dProveedor;
        public NProveedores()
        {
            _dProveedor = new DProveedores();
        }
        public void Cambios(Proveedor proveedor) => _dProveedor.Cambios(proveedor);

        public void Altas(Proveedor proveedor) => _dProveedor.Altas(proveedor);

        public List<Proveedor> Consultar() => _dProveedor.Consultar();

        public Proveedor Consultar(int id) => _dProveedor.Consultar(id);

        public void Bajas(int id) => _dProveedor.Bajas(id);
    }
}