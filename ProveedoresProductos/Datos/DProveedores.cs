using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Datos
{
    public class DProveedores
    {
        public ProveedoresProductosEntities dbcontext = new ProveedoresProductosEntities();
        
        public List<Proveedor> Consultar()
        {
            List<Proveedor> proveedor = dbcontext.Proveedor.ToList();
            return proveedor;
        }
        public Proveedor Consultar(int id)
        {
            Proveedor proveedorencontrado = dbcontext.Proveedor.Find(id);
            return proveedorencontrado;
        }
        public void Altas(Proveedor proveedor)
        {
            dbcontext.Proveedor.Add(proveedor);
            dbcontext.SaveChanges();
        }
        public void Cambios(Proveedor proveedor)
        {
            dbcontext.Entry(proveedor).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }
        public void Bajas(int id)
        {
            Proveedor proveedor = dbcontext.Proveedor.Find(id);
            List<Productos> productosencontrados = dbcontext.Productos.Where(x => x.IdProveedor == id).ToList();
            if(productosencontrados.Count() == 0)
            {
                dbcontext.Proveedor.Remove(proveedor);
                dbcontext.SaveChanges();
            }
            else
            {
            MessageBoxResult result = MessageBox.Show("¿Estás seguro de eliminar este proveedor?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        dbcontext.Proveedor.Remove(proveedor);;
                        foreach(var item in productosencontrados)
                        {
                            dbcontext.Productos.Remove(item);
                        }
                        dbcontext.SaveChanges();
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Está bien, no se eliminará", "Confirmación");
                        break;
                }
            }
            
        }
    }
}