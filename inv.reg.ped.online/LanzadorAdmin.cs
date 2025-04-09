using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inv.reg.ped.online
{
     public class LanzadorAdmin
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar: (Empleado, Producto, Vaciones, Venta y Entrega)");
            Console.WriteLine("2. Eliminar: (Empleado, Producto, Vaciones, Venta y Producto en Venta)");
            Console.WriteLine("3. Consultas: (Empleados, Pedidos, Pedido individual, Productos y Ventas)");
            Console.WriteLine("4. Modificar cargo de empleado");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("Seleccione lo que desea agregar:");
                Console.WriteLine("1. Empleado");
                Console.WriteLine("2. Producto");
                Console.WriteLine("3. Vacaciones");
                Console.WriteLine("4. Venta");
                Console.WriteLine("5. Entrega");
                int optionone = int.Parse(Console.ReadLine());
                if (optionone == 1)
                {
                    AddEmpleado.Ejecutar();
                }
                else if ( optionone == 2)
                    {
                    AddProducto.Ejecutar();
                }
                else if ( optionone == 3)
                {
                    AddVacaciones.Ejecutar();
                }
                else if ( optionone == 4)
                {
                    AddVenta.Ejecutar();
                }
                else if ( optionone == 5 )
                {
                    ActualizadorEstadoEntregas.Ejecutar();
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Seleccione lo que desea eliminar:");
                Console.WriteLine("1. Empleado");
                Console.WriteLine("2. Producto");
                Console.WriteLine("3. Vacaciones");
                Console.WriteLine("4. Venta");
                Console.WriteLine("5. Producto de una venta");
                int optiontwo = int.Parse(Console.ReadLine());
                if (optiontwo==1)
                {
                    EliminarEmpleado.Ejecutar();
                }
                else if ( optiontwo == 2)
                {
                    EliminarProducto.Ejecutar();
                }
                else if (optiontwo == 3)
                {
                    CancelarVacaciones.Ejecutar();
                }
                else if ( optiontwo == 4 )
                {
                    EliminarVentaTotal.Ejecutar();
                }
                else if ( optiontwo == 5)
                {
                    Eliminarunidadesven.Ejecutar();
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
            else if (opcion == "4")
            {
                ModCargo.Ejecutar();
            }
        }
    }
}
