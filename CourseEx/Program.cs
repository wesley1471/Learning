using System;
using System.Globalization;
using CourseEx.Entities;
using CourseEx.Entities.Enums;
namespace CourseEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(order);
            Console.WriteLine(txt);
        }
    }
}