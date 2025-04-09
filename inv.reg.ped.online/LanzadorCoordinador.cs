using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inv.reg.ped.online
{
    public class LanzadorCoordinador
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar: (Producto, Venta y Entrega)");
            Console.WriteLine("2. Eliminar: (Producto, Venta y Producto en Venta)");
            Console.WriteLine("3. Consultas: (Empleados, Pedidos, Pedido individual, Productos y Ventas)");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("Seleccione lo que desea agregar:");
                Console.WriteLine("1. Producto");
                Console.WriteLine("2. Venta");
                Console.WriteLine("3. Entrega");
                int optiononet = int.Parse(Console.ReadLine());
                if (optiononet == 1)
                {
                    AddProducto.Ejecutar();
                }
                else if (optiononet == 2)
                {
                    AddVenta.Ejecutar();
                }
                else if (optiononet == 3)
                {
                    ActualizadorEstadoEntregas.Ejecutar();
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Seleccione lo que desea eliminar:");
                Console.WriteLine("1. Producto");
                Console.WriteLine("2. Venta");
                Console.WriteLine("3. Producto de una venta");
                int optiontwot = int.Parse(Console.ReadLine());
                if (optiontwot == 1)
                {
                    EliminarProducto.Ejecutar();
                }
                else if (optiontwot == 2)
                {
                    EliminarVentaTotal.Ejecutar();
                }
                else if (optiontwot == 3)
                {
                    EliminarVentaTotal.Ejecutar();
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Seleccione el tipo de consulta:");
                Console.WriteLine("1. Empleados");
                Console.WriteLine("2. Pedidos");
                Console.WriteLine("3. Pedido individual");
                Console.WriteLine("4. Productos");
                Console.WriteLine("5. Ventas");
                int optiotrhee = int.Parse(Console.ReadLine());
                if (optiotrhee == 1)
                {
                    ConsultaEmpleados.Ejecutar();
                }
                else if (optiotrhee == 2)
                {
                    ConsultaPedidos.Ejecutar();
                }
                else if (optiotrhee == 3)
                {
                    ConsultaPedParticular.Ejecutar();
                }
                else if (optiotrhee == 4)
                {
                    ConsultaProducto.Ejecutar();
                }
                else if (optiotrhee == 5)
                {
                    ConsultaVentas.Ejecutar();
                }
            }
        }
    }
}
