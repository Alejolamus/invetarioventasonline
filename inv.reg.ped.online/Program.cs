﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;
namespace inv.reg.ped.online
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nombre de usuario");
            string nombreuser = Console.ReadLine();
            Console.WriteLine("Contraseña");
            string password = Console.ReadLine();
            string v1 = "Admin";
            string v2 = "Coordinador";
            string v3 = "Vendedor";
            string v4 = "Repartidor";

            using (var context = new AppDbContext())
            {
                var identificador = context.Users
                    .Where(h => h.Nombre == nombreuser && h.Contraseña == password)
                    .FirstOrDefault();
                if (identificador != null)
                {
                    if (identificador.Cargo == v1)
                    {
                        LanzadorAdmin.Ejecutar();
                    }
                    else
                    {
                        if (identificador.Cargo == v2)
                        {
                            LanzadorCoordinador.Ejecutar();
                        }
                        else
                        {
                            if (identificador.Cargo == v3)
                            {
                                LanzadorVendedor.Ejecutar();
                            }
                            else
                            {
                                if (identificador.Cargo == v4)
                                {
                                    LanzadorRepartidor.Ejecutar();
                                }
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrecto");
                }
            }

        }
    }
}
