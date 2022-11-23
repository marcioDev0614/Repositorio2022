using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Pedido: " + Id + ", Data: " + Moment + ", Status: " + Status;
        }

        static void Main_()
        {
            Order pedido = new Order { Id = 25, Moment = DateTime.Now, Status = OrderStatus.Processing };

            Console.WriteLine(pedido);

            // Convertendo enum para string
            string txt = OrderStatus.Processing.ToString();

            // Convertendo string enum para int
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

            

        }
    }
}
