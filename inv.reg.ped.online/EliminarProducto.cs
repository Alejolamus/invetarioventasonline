using System;
using System.Linq;
using inv.reg.ped.online.models;

namespace inv.reg.ped.online
{
    class EliminarProducto
    {
        public static void Ejecutar()
        {
            using (var context = new AppDbContext())
            {
                var productos = context.Productos.ToList();

                if (productos.Count == 0)
                {
                    Console.WriteLine("No hay productos registrados.");
                    return;
                }

                Console.WriteLine("Lista de productos disponibles:");
                foreach (var producto in productos)
                {
                    Console.WriteLine($"- {producto.Nombre}");
                }

                Console.Write("Ingrese el nombre del producto a eliminar: ");
                string nombreProElim = Console.ReadLine();

                // Buscar y eliminar el producto
                var entidad = context.Productos.FirstOrDefault(e => e.Nombre == nombreProElim);

                if (entidad != null)
                {
                    context.Productos.Remove(entidad);
                    context.SaveChanges();
                    Console.WriteLine($"El producto '{nombreProElim}' ha sido eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine($"No se encontró un producto con el nombre '{nombreProElim}'.");
                }
            }
        }
    }
}
