using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProductos
    {
        private DProductos _dProductos;
        public NProductos()
        {
            _dProductos = new DProductos();
        }
        public void Altas(Productos productos) => _dProductos.Altas(productos);

        public List<Productos> Consultar(int id) => _dProductos.Consultar(id);
    }
}