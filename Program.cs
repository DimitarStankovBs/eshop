using System;
using System.Collections.Generic;
using System.Linq;

namespace eshop
{
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    class Administrator
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Administrator(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool OutOfStock { get; set; }

        public Item(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
            OutOfStock = false;
        }

        public void UpdateStock(int newStock)
        {
            Stock = newStock;
            if (Stock == 0)
            {
                OutOfStock = true;
            }
        }
    }

    class Order
    {
        public Customer Customer { get; set; }
        public List <Item> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(Customer customer, List<Item> items)
        {
            Customer = customer;
            Items = items;
            TotalPrice = items.Sum (x => x.Price);
            OrderDate = DateTime.Now;
        }
    }

    class DeliveryGuy
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public DeliveryGuy(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }

}
