using System;
using System.Collections.Generic;
using System.Text;
using FixacaoEnumComp01.Entities.Enums;
using FixacaoEnumComp01.Entities;
using System.Globalization;

namespace FixacaoEnumComp01.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem product in Item)
            {
                sum = sum + product.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order momment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status : " + Status);
            sb.AppendLine("Cliente " + Client);
            sb.AppendLine("ORDER ITEMS: ");
            foreach (OrderItem prod in Item)
            {
                sb.AppendLine(prod.ToString());
                 

            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
    