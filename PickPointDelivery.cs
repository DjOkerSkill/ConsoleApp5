using System;


namespace ConsoleApp5
{
    class PickPointDelivery : Delivery
    {
        string[] pointDelivery = new string[2]
        {
            "г. Москва ул. Селезнева д. 24",
            "г. Москва ул. Новаторов д. 2 стр. 5"
        };
        public override string IndicateAddress()
        {
            Console.WriteLine("Выберете адрес доставки в пункт выдачи");

            for (int i = 0; i < pointDelivery.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + pointDelivery[i]);
            }
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Вы сможете забрать товар по адресу {0}", pointDelivery[num - 1]);

            return pointDelivery[num - 1];
        }
    }
}
