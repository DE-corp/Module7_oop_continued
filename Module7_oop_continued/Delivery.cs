using System;

namespace Module7_oop_continued
{
    abstract class Delivery
    {
        public string Address { get; set; }
        public Delivery(string Address){ this.Address = Address; }
        public abstract void ShowAddress();
        
    }

    class СourierDelivery : Delivery
    {
        private readonly string Phone;
        public СourierDelivery(string address, string Phone) : base(address) 
        {
            this.Phone = Phone;
        }

        public override void ShowAddress()
        {
            Console.WriteLine($"Полис доставим по адресу: {Address}. Курьер позвонит по номеру: {Phone}");
        }
    }

    class OfficeDelivery : Delivery
    {

        public OfficeDelivery() : base("Москва, ул. Илимская, д. 2") { }

        public override void ShowAddress()
        {
            Console.WriteLine($"Полис можно получить по адресу: {Address}");
        }
    }

    class ElectronicDelivery: Delivery
    {
        private readonly string Email;
        public ElectronicDelivery(string address, string Email) : base(address)
        {
            this.Email = Email;
        }

        public override void ShowAddress()
        {
            Console.WriteLine($"На вашу почту {Email} направленна ссылка для оплаты!");
        }
  
    }

    public class DeliveryData
    {
        private string Adress;
        public int DeliveryType { get; set; }
        public string Address
        {
            get
            {
                return Adress;
            }
            set
            {
                if (DeliveryType == 2)
                {
                    Adress = value;
                }
                else
                {
                    Adress = null;
                }
            }
        }
    }
    }
