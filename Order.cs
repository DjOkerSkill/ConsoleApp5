using System;


namespace ConsoleApp5
{
    class Order
    {
        public static int Size { get; set; }

        // Ассоциация классов
        public BaseProducts baseProducts { get; set; } = new BaseProducts();
        public Product product { get; set; } = new Product();

        public Delivery[] delivery = { new HomeDelivery(), new PickPointDelivery(), new ShopDelivery() };
        
        // Сделать заказ товара
        public void MadeOrder() 
        {
            bool Ischeck = true;
            do
            {
                Console.WriteLine("Введите название товара из Вашей корзины");
                string NameProduct = Console.ReadLine();

                Console.WriteLine("Введите название брендa, выбранного товара");
                string BrandProduct = Console.ReadLine();

                for (int i = 0; i < Size; i++)
                {
                     product = baseProducts.GetProduct(i);

                    if (NameProduct == product.Name && BrandProduct == product.Brand)
                    {
                        Ischeck = false;
                        break;
                    }
                }
            } while (Ischeck);
        }
        // Выбор типа доставки
        public Delivery GetDelivery(int index) 
        { 
            if(index == 1) return new HomeDelivery();
            if(index == 2) return new PickPointDelivery();
            else return new ShopDelivery();
        }
    }
}
