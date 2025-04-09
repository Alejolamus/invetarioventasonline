using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;
namespace inv.reg.ped.online

{
    public class AddVacaciones
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Nombre de Empleado");
            string NombreEmpleado = Console.ReadLine();

            using (var context = new AppDbContext())
            {
                var usermod = context.Users
                    .Where(w => w.Nombre == NombreEmpleado)
                    .FirstOrDefault();
                if (usermod == null)
                {
                    Console.WriteLine("Empleado no encontrado");
                }
                else
                {
                    usermod.EstadoVacacional = true;
                    context.SaveChanges();
                }
            }

        }
    }
}
