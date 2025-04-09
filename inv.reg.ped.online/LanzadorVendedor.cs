using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inv.reg.ped.online
{
    public class LanzadorVendedor
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar: (Venta y Entrega)");
            Console.WriteLine("2. Eliminar: (Venta y Producto en Venta)");
            Console.WriteLine("3. Consultas: (Pedidos, Pedido individual, Productos y Ventas)");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("Seleccione lo que desea agregar:");
                Console.WriteLine("1. Venta");
                Console.WriteLine("2. Entrega");
                int optiononey = int.Parse(Console.ReadLine());
                if (optiononey == 1)
                {
                    AddVenta.Ejecutar();
                }
                else if (optiononey == 2)
                {
                    ActualizadorEstadoEntregas.Ejecutar();
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Seleccione lo que desea eliminar:");
                Console.WriteLine("1. Venta");
                Console.WriteLine("2. Producto de una venta");
                int optiontwoy = int.Parse(Console.ReadLine());
                if (optiontwoy == 1)
                {
                    EliminarProducto.Ejecutar();
                }
                else if (optiontwoy == 2)
                {
                    EliminarVentaTotal.Ejecutar();
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Seleccione el tipo de consulta:");
                Console.WriteLine("1. Pedidos");
                Console.WriteLine("2. Pedido individual");
                Console.WriteLine("3. Productos");
                Console.WriteLine("4. Ventas");
                int optiotrheey = int.Parse(Console.ReadLine());
                
                if (optiotrheey == 1)
                {
                    ConsultaPedidos.Ejecutar();
                }
                else if (optiotrheey == 2)
                {
                    ConsultaPedParticular.Ejecutar();
                }
                else if (optiotrheey == 3)
                {
                    ConsultaProducto.Ejecutar();
                }
                else if (optiotrheey == 4)
                {
                    ConsultaVentas.Ejecutar();
                }
            }
        }
    }
}
