using System;

namespace Module7_oop_continued
{

	class Program
	{
		static void Main(string[] args)
		{
			var (client, ProductItem, deliveryData) = ConsoleInterface.Start();

            if(deliveryData.DeliveryType == 1)
            {
                var order = new Order<ElectronicDelivery>(new ElectronicDelivery(deliveryData.Address, client.Email));
                order.GetInfo(client.Name);
                
            }
            else if (deliveryData.DeliveryType == 2)
            {
                if (ProductItem == "Каско")
                {
                    var order = new Order<СourierDelivery>(new СourierDelivery(deliveryData.Address, client.Phone));
                    order.GetInfo(client.Name);
                }
                else
                    Console.WriteLine("Доставка данного продукта временно не доступна, попробуйте позже..");
            }
            else
            {
                var order = new Order<OfficeDelivery>(new OfficeDelivery());
                order.GetInfo(client.Name);
            }

            Console.WriteLine("Спасибо за сотрудничество. Безаварийного года!");
            Console.ReadLine();
		}
	}

}