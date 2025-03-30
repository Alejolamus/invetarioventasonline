using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;

namespace inv.reg.ped.online
{
    class AddProducto
    {
        public static void Ejecutar()
        {
            Console.Write("Nombre de producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Número en Bodega: ");
            int nuBodega = int.Parse(Console.ReadLine());

            Console.Write("Número mínimo: ");
            int nuMin = int.Parse(Console.ReadLine());
            Console.Write("Precio: ");
            int Valor  = int.Parse(Console.ReadLine());

            using (var context = new AppDbContext())
            {
                var producto = new Productos 
                {
                    Nombre = nombreProducto,
                    CantidadEnB = nuBodega,
                    CantidadMin = nuMin,
                    Precio = Valor
                };

                context.Productos.Add(producto);
                context.SaveChanges();

                Console.WriteLine("Se agregó el producto correctamente.");
            }
        }
    }
}
