using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;
namespace inv.reg.ped.online
{
    public class ConsultaVentas
    {
        public static void Ejecutar()
        {
            using (var context = new AppDbContext())
            {
                var ventas = context.Ventas.ToList();
                if (ventas.Count == 0)
                {
                    Console.WriteLine("No hay productos registrados.");
                    return;
                }

                Console.WriteLine("Lista de ventas realizadas:");
                foreach (var venta in ventas)
                {
                    Console.WriteLine($"- Venta al cliente {venta.Cliente} realizada el dia: {venta.Fechadeventa}, con un recaudo de {venta.Recaudo} registrado en la trasaccion {venta.CodTransaccion}");
                }
            }
           
        }
    }
}
