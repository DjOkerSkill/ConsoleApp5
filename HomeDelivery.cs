using System;

namespace ConsoleApp5
{
    class HomeDelivery : Delivery
    {
        bool Iscourier { get; set; } = true;

        string[] CourierCompany = new string[3];

        void BaseCourierCompany()
        {
            CourierCompany[0] = "Аист Экспресс";
            CourierCompany[1] = "Сокол Экспресс";
            CourierCompany[2] = "Беркут Экспресс";

            Console.WriteLine("Выберите компанию из списка 1, 2, 3 соответственно:\t" + CourierCompany[0] + "\t" + CourierCompany[1] + "\t" + CourierCompany[2]);
        }
        public override void SelectionCourierCompany()
        {
            BaseCourierCompany();
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Вы выбрали компанию {0}", CourierCompany[0]);
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали компанию {0}", CourierCompany[1]);
                    break;

                case 3:
                    Console.WriteLine("Вы выбрали компанию {0}", CourierCompany[2]);
                    break;
            }
        }
        public override string IndicateAddress()
        {
            if (Iscourier)
            {
                Console.WriteLine("Введите адрес доставки");
                Adress = Console.ReadLine();
                Console.WriteLine("Спасибо за заказ. Ожидайте звонка курьера");
                return Adress;
            }
            else
                Console.WriteLine("Извините все курьеры заняты");
            return null;
        }
    }
}
