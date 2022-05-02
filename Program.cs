using System;

namespace ConsoleApp5
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
			// Выбор товара в корзину
			Order order = new Order();

			Product product = new Product(Name:"TV", Brand:"Samsung", Price: 25000);
			
			order.baseProducts.AddProduct(product);

			Product product2 = new Product(Name: "Fun", Brand: "LG", Price: 2000);
			
			order.baseProducts.AddProduct(product2);

			// Cделать заказ
			order.MadeOrder();

			// Выбрать способ доставки
			Console.WriteLine("Выберете способ доставки:\n" + "1. Доставка курьером\n" + "2. Доставка через PickPoint\n" + "3. Забрать товар через пункт самовывоза\n");

			int num = int.Parse(Console.ReadLine());

			Delivery delivery = order.GetDelivery(num);

			if (delivery is HomeDelivery) 
			{ 
				delivery.SelectionCourierCompany();
				delivery.IndicateAddress(); 
			}
			if (delivery is PickPointDelivery)
				delivery.IndicateAddress();

			if (delivery is ShopDelivery )
				delivery.IndicateAddress();
		}
	}
}
