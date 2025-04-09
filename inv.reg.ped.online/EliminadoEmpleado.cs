using System;
using System.Linq;
using inv.reg.ped.online.models;

namespace inv.reg.ped.online
{
    class EliminarEmpleado
    {
        public static void Ejecutar()
        {
            using (var context = new AppDbContext())
            {
                var Empleados = context.Users.ToList();

                if (Empleados.Count == 0)
                {
                    Console.WriteLine("No hay Empleados registrados.");
                    return;
                }

                Console.WriteLine("Lista de productos disponibles:");
                foreach (var Empleado in Empleados)
                {
                    Console.WriteLine($"- {Empleado.Nombre} con cargo {Empleado.Cargo}");
                }

                Console.Write("Ingrese el nombre del producto a eliminar: ");
                string DelEmpleado = Console.ReadLine();
                Console.Write("Tipo de documento");
                string TD = Console.ReadLine();
                Console.Write("Numero de documento");
                int NumDoc = int.Parse(Console.ReadLine());
                // Buscar y eliminar el producto
                var NoEmpleado = context.Users.FirstOrDefault(e => e.Nombre == DelEmpleado && e.TipoDeDoc == TD && e.NumeroDeDocumento == NumDoc);

                if (NoEmpleado != null)
                {
                    context.Users.Remove(NoEmpleado);
                    context.SaveChanges();
                    Console.WriteLine($"El Empleado '{DelEmpleado}' ha sido eliminado correctamente de la BD.");
                }
                else
                {
                    Console.WriteLine($"No se encontró un empleado con los datos suministrados.");
                }
            }
        }
    }
}