using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;
namespace inv.reg.ped.online
{
    public class ConsultaEmpleados
    {
        public static void Ejecutar()
        {
            using (var context = new AppDbContext())
            {
                var users = context.Users.ToList();
                if (users.Count == 0)
                {
                    Console.WriteLine("No hay Empleados registrados.");
                    return;
                }
                foreach ( var user in users )
                {
                    if (user.EstadoVacacional == 0)
                    {
                        Console.WriteLine($"Empleado:{user.nombre} con cargo: {user.Cargo} no se encuentra en vaciones");    
                    }
                    Console.WriteLine($"Empleado:{user.nombre} con cargo: {user.Cargo} se encuentra en vaciones");
                }
                
            }

        }
    }
}