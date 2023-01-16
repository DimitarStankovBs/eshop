using System;
using System.Collections.Generic;
using System.Linq;

namespace eshop
{
    class Customer//Въвеждане на клиент
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    class Administrator//Въвеждане на администратор
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Administrator(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    class Item //Стока
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool OutOfStock { get; set; }

        public Item(string name, decimal price, int stock) //Въвеждане на нова стока
        {
            Name = name;
            Price = price;
            Stock = stock;
            OutOfStock = false;
        }

        public void UpdateStock(int newStock) //Промяна на наличност на стока
        {
            Stock = newStock;
            if (Stock == 0)
            {
                OutOfStock = true;
            }
        }
    }

    class Order // Поръчка
    {
        public Customer Customer { get; set; }
        public List <Item> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(Customer customer, List<Item> items) // Оформяне на поръчка
        {
            Customer = customer;
            Items = items;
            TotalPrice = items.Sum (x => x.Price);
            OrderDate = DateTime.Now;
        }
        Public Print (Customer, Items, TotalPrice, OrderDate) //Печатане на фактура
        {
            Console.WriteLine (""Your Invoice: " + Customer + Items + TotalPrice + OrderDate)
        }
    }

    class DeliveryGuy //Избор на доставчик
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public DeliveryGuy(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order) //Добавяне на поръчка за доставка
        {
            Orders.Add(order);
        } 
    }
    Clas Program
    {
        Static void Main()
        {
        Console WriteLine ("Please enter an option!")
        Console WriteLine ("1 - ")
        }
    }

}
