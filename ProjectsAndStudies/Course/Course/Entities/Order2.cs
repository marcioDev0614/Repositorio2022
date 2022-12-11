using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;
using System.Globalization;

namespace Course.Entities
{
    class Order2
    {
        public DateTime Moment { get; set; }
        public OrderStatus2 Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order2() { }

        public Order2(DateTime moment, OrderStatus2 status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order item: ");
            foreach(OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        static void Main_()
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus2 status = Enum.Parse<OrderStatus2>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order2 order = new Order2(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product p = new Product(name, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem ordemItem = new OrderItem(quantity, price, p);

                order.AddItem(ordemItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order); ;


        }
    }
}
