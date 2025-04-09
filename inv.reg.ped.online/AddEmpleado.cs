using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;

namespace inv.reg.ped.online
{
    public class AddEmpleado
    {
        public static void Ejecutar()
        {
            Console.Write("Nombre de empleado: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Cargo: ");
            string CargoEmpleado = Console.ReadLine();

            Console.Write("Contraseña: ");
            string Pass = Console.ReadLine();

            using (var context = new AppDbContext())
            {
                var User = new Users
                {
                    Nombre = nombreEmpleado,
                    Cargo = CargoEmpleado,
                    Contraseña = Pass,
                    EstadoVacacional = false
                };

                context.Users.Add(User);
                context.SaveChanges();

                Console.WriteLine("Se agregó nuevo empleado.");
            }
        }
    }
}