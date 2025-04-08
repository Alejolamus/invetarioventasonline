using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;
namespace inv.reg.ped.online
{
    public class ConsultaPedParticular
    {
        public static void Ejecutar()
        {
            using (var context = new AppDbContext())
            {
                // Solicitar datos al usuario
                Console.Write("Ingrese el nombre del cliente: ");
                string Nombreclient = Console.ReadLine();

                Console.Write("Ingrese la fecha de venta con formato dd/MM/yyyy HH:mm:ss: ");
                string fechavenc = Console.ReadLine();

                DateTime Fechaventacon;
                if (!DateTime.TryParseExact(fechavenc, "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out Fechaventacon))
                {
                    Console.WriteLine("Formato de fecha incorrecto.");
                    return;
                }

                // Buscar ID de la venta
                var ventare = context.Ventas
                    .Where(p => p.Cliente == Nombreclient && p.Fechadeventa == Fechaventacon)
                    .FirstOrDefault();

                if (ventare == null)
                {
                    Console.WriteLine("No se encontró una venta con los datos ingresados.");
                    return;
                }
                int IdvenConsul = ventare.Id;
                var Pedidoconsul = context.Pedidos
                    .Where(h => h.IdVenta == IdvenConsul)
                    .FirstOrDefault();

                if (Pedidoconsul.Entregado == true)
                {
                    Console.WriteLine($"El pedido ha sido entregado el dia {Pedidoconsul.FechaEntrega} con los siguientes productos:");
                    
                }
            }
        }
    }
}
