using System;
using CourseEx.Entities.Enums;
namespace CourseEx.Entities
{
    internal class Order
    {
        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return id + ", " + Moment + ", " + Status;
        }

    }
}
