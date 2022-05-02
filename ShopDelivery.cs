using System;


namespace ConsoleApp5
{
    class ShopDelivery : Delivery
    {
        public override string IndicateAddress()
        {
            Adress = "г.Москва, ул Патриотов, д. 102";
            Console.WriteLine("Товар находится на складе по адресу {0}", Adress);
            return Adress;
        }
    }
}
