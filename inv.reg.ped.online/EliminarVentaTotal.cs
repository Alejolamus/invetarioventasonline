using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;


namespace inv.reg.ped.online
{
    class EliminarVentaTotal
    {
        public static void Ejecutar()
        {
            using (var context = new AppDbContext())
            {
                // Solicitar datos al usuario
                Console.Write("Ingrese el nombre del cliente: ");
                string nombreclient = Console.ReadLine();

                Console.Write("Ingrese la fecha de venta con formato dd/MM/yyyy HH:mm:ss: ");
                string fechav = Console.ReadLine();

                DateTime fechaventa;
                if (!DateTime.TryParseExact(fechav, "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out fechaventa))
                {
                    Console.WriteLine("Formato de fecha incorrecto.");
                    return;
                }

                // Buscar ID de la venta
                var venta = context.Ventas
                    .Where(p => p.Cliente == nombreclient && p.Fechadeventa == fechaventa)
                    .FirstOrDefault();

                if (venta == null)
                {
                    Console.WriteLine("No se encontró una venta con los datos ingresados.");
                    return;
                }

                int Idvendelete = venta.Id;

                // Eliminar la venta
                context.Ventas.Remove(venta);
                context.SaveChanges();
                Console.WriteLine($"Venta con ID {Idvendelete} eliminada correctamente.");

                // Eliminar registros de UnidadesVendidas asociados
                var unidadesVendidas = context.UnidadesVendidas.Where(uv => uv.IdVenta == Idvendelete).ToList();
                if (unidadesVendidas.Any())
                {
                    context.UnidadesVendidas.RemoveRange(unidadesVendidas);
                    context.SaveChanges();
                    Console.WriteLine("Se eliminaron las unidades vendidas asociadas a la venta.");
                }

                // Eliminar registros de Pedidos asociados
                var pedidos = context.Pedidos.Where(p => p.IdVenta == Idvendelete).ToList();
                if (pedidos.Any())
                {
                    context.Pedidos.RemoveRange(pedidos);
                    context.SaveChanges();
                    Console.WriteLine("Se eliminaron los pedidos asociados a la venta.");
                }
            }
        }
    }
}
