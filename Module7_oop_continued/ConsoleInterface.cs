using System;


namespace Module7_oop_continued
{
    public static class ConsoleInterface
    {
        public static (Client client, string ProductItem, DeliveryData deliveryData) Start()
        {
            (Client client, string ProductItem, DeliveryData deliveryData) Data = (new Client(), null, new DeliveryData());

            Console.WriteLine("Вас приветствует страховая компания!");

            // Получаем Имя, Фамилию, Отчество клиента
            while (true)
            {
                try
                {
                    Console.Write("\nВведите Ваше ФИО: ");
                    string ClientFullName = Console.ReadLine();
                    Data.client.Name = ClientFullName.Split(' ')[1];
                    Data.client.Surname = ClientFullName.Split(' ')[0];
                    Data.client.Middlename = ClientFullName.Split(' ')[2];
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите ФИО в формате: Иванов Иван Иванович!");
                }
            }

            // Предлагаем товары
            var Products = new string[] { "Каско", "Осаго" };
            Console.WriteLine("Какой вид страхования Вас интересует: ");

            for (var i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {Products[i]}");
            }

            Console.WriteLine();
            int ProductItem;
            while (!int.TryParse(Console.ReadLine(), out ProductItem) || ProductItem < 0 || ProductItem > 2)
            {
                Console.WriteLine("Такой продукт не существует! Выберите номер из предложенных..");
            }

            Data.ProductItem = Products[ProductItem - 1];

            // Выбираем способ получения полиса
            var DeliveryMethods = new string[] { "Электронный", "Доставка курьером", "Получение в офисе" };
            Console.WriteLine("Как Вам будет удобно получить полис: ");

            for (var i = 0; i < DeliveryMethods.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {DeliveryMethods[i]}");
            }

            Console.WriteLine();
            int DeliveryItem;
            while (!int.TryParse(Console.ReadLine(), out DeliveryItem) || DeliveryItem < 0 || DeliveryItem > 3)
            {
                Console.WriteLine("Такой способ получения не существует! Выберите номер из предложенных..");
            }

            Data.deliveryData.DeliveryType = DeliveryItem;

           
            if (Data.deliveryData.DeliveryType == 2)
            {
                Console.Write("Куда доставить: ");
                Data.deliveryData.Address = Console.ReadLine();
                Console.Write("Введите номер для связи: ");
                Data.client.Phone = Console.ReadLine();
            }
            else if(Data.deliveryData.DeliveryType == 1)
            {
                Console.Write("Введите адрес электронной почты, куда отправить полис: ");
                Data.client.Email = Console.ReadLine();
            }

            return Data;
        }
    }
}
