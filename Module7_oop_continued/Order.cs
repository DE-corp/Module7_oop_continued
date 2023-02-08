
using System;

namespace Module7_oop_continued
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery { get; set; }

        public Order(TDelivery delivery)
        {
            Delivery = delivery;
        }

        public void GetInfo(string Name)
        {
            Console.WriteLine($"\nУважаемый, {Name}");
            Delivery.ShowAddress();
        }

    }

}
