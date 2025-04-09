using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv.reg.ped.online.models;

namespace inv.reg.ped.online
{
    class AddVenta
    {
        public static void Ejecutar()
        {
            Console.Write("Nombre del cliente: ");
            string nombrecliente = Console.ReadLine();

            Console.Write("Recaudo: ");
            int recaudo = int.Parse(Console.ReadLine());

            Console.Write("Código de transacción: ");
            int Codigotransaccion = int.Parse(Console.ReadLine());

            int iddeventa;

            using (var context = new AppDbContext())
            {
                var venta = new Ventas
                {
                    Cliente = nombrecliente,
                    Recaudo = recaudo,
                    CodTransaccion = Codigotransaccion
                };

                context.Ventas.Add(venta);
                context.SaveChanges();
                iddeventa = venta.Id;

                Console.WriteLine("Se agregó la venta.");
            }

            using (var context = new AppDbContext())
            {
                var productos = context.Productos.ToList();

                if (productos.Count == 0)
                {
                    Console.WriteLine("No hay productos registrados.");
                    return;
                }

                Console.WriteLine("Lista de productos disponibles:");
                foreach (var producto in productos)
                {
                    Console.WriteLine($"{producto.Nombre}");
                }

                Console.Write("Cantidad de tipos de productos diferentes: ");
                int cantidadpp = int.Parse(Console.ReadLine());

                for (int i = 0; i < cantidadpp; i++)
                {
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombreProductob = Console.ReadLine();

                    var productob = context.Productos
                        .Where(p => p.Nombre == nombreProductob)
                        .Select(p => p.Id)
                        .FirstOrDefault();

                    if (productob == 0)
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                    else
                    {
                        int idproductov = productob;
                        Console.Write("Cantidad por producto: ");
                        int Cantidadporproducto = int.Parse(Console.ReadLine());

                        var Cantidadesvendida = new UnidadesVendidas
                        {
                            IdVenta = iddeventa,
                            IdProducto = idproductov,
                            nProducto = nombreProductob,
                            CantidadVendida = Cantidadporproducto
                        };

                        context.UnidadesVendidas.Add(Cantidadesvendida);
                        context.SaveChanges();

                        Console.WriteLine("Se agregaron las unidades vendidas por producto.");
                    }
                }

                var productosVendidos = context.UnidadesVendidas
                    .Where(uv => uv.IdVenta == iddeventa)
                    .ToList();

                decimal totalPedido = 0;

                foreach (var item in productosVendidos)
                {
                    var precio = context.Productos
                        .Where(p => p.Id == item.IdProducto)
                        .Select(p => p.Precio)
                        .FirstOrDefault();

                    totalPedido += item.CantidadVendida * precio;
                }

                int saldofal = (int)totalPedido - recaudo;

                Console.Write("Correo: ");
                string correo = Console.ReadLine();

                Console.Write("Teléfono: ");
                string tel = Console.ReadLine();

                Console.Write("Dirección: ");
                string direccion = Console.ReadLine();

                Console.Write("Ingrese la fecha de entrega (formato: dd/MM/yyyy): ");
                string input = Console.ReadLine();
                DateTime fechadeentrega;

                while (!DateTime.TryParse(input, out fechadeentrega))
                {
                    Console.Write("Formato incorrecto. Intente nuevamente (dd/MM/yyyy): ");
                    input = Console.ReadLine();
                }

                var pedido = new Pedidos
                {
                    IdVenta = iddeventa,
                    Direccion = direccion,
                    Cliente = nombrecliente,
                    SaldoFaltante = saldofal,
                    Correo = correo,
                    FechaEntrega = fechadeentrega,
                    Entregado = false
                };

                context.Pedidos.Add(pedido);
                context.SaveChanges();

                Console.WriteLine("Se agregó el pedido correctamente.");
            }
        }
    }
}
