using System;
using System.Linq;
using inv.reg.ped.online.models;

namespace inv.reg.ped.online
{
    class ConsultaProducto
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
                    Console.WriteLine($"- Nombre: {producto.Nombre}, Precio: {producto.Precio}, se cuenta con un total de {producto.CantidadEnB} unidades para venta");
                }
            }

        }
    }
}
