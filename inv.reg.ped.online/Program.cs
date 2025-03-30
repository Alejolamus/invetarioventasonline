using System;

namespace inv.reg.ped.online
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Agregar venta y pedido");
            Console.WriteLine("3. Eliminar Producto");
            Console.WriteLine("4. Eliminar venta total (incluye borrado de pedido)");
            Console.WriteLine("5. Eliminar unidades en una venta");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                AddProducto.Ejecutar(); 
            }
            else if (opcion == "2")
            {
                AddVenta.Ejecutar(); 
            }
            else if (opcion == "3")
                {
                EliminarProducto.Ejecutar();
            }
            else if (opcion == "4")
            {
                EliminarVentaTotal.Ejecutar();
            }
           
            
        }
    }
}
