using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;
namespace inv.reg.ped.online
{
    public class ConsultaPedidos
    {
        public static void Ejecutar()
        {
            Boolean Conparaentrega = true;
            using (var context = new AppDbContext())
            {
                var idsventas = context.Ventas
                    .Select(uv => { uv.Id })
                    .ToList();
                foreach ( var iddeventa in idsventas)
                {//revisar la coomparacion entre idventa y iddeventa
                    var domicilios = context.Pedidos
                        .Where(v => v.IdVenta == iddeventa & v.Entregado == Conparaentrega )
                        .ToList();
                    
                    if (domicilios.count == 0)
                       {
                        Console.WriteLine("No se encontraron pedidos por entregar");
                    }
                    {
                        Console.WriteLine("Lista de entregas pendientes");
                        foreach (var domici in domicilios)
                        {
                            Console.WriteLine($"El cliente: {domici.Cliente} tiene un pedido para entregar el {domici.FechaEntrega} a la direccion: {domici.Direccion}");
                        }
                    }

                }
            }

        }
    }
}