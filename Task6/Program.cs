using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Buyer
    {
        private string name;
        private string soname;
        private int cardNumber;
        private double orderCost;

        public string Name { get { return name; } }
        public string Sonmae { get { return soname; } }

        public double OrderCost
        {
            get { return orderCost; }
            set { orderCost = value; }
        }

        public static List<Buyer> buyers = new List<Buyer> { };

        Random rnd = new Random(buyers.Count);

        public Buyer(string name, string soname)
        {
            this.name = name;
            this.soname = soname;
            cardNumber = buyers.Count;
            orderCost = Math.Round(rnd.NextDouble() * 10000, 2);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"------Information about buyer------\n" +
                $"\nName - {name}\nSoname - {soname}\nCard number - {cardNumber}\nOrder cosr - {orderCost}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CreateBuyer("evhenii", "tymoshenko");
            CreateBuyer("vovik", "zhdanov");
            CreateBuyer("taras", "yakybovich");

            Buyer.buyers[2].ShowInfo();

            OrderDiscount(Buyer.buyers[1], 0.25);
        }
        static void OrderDiscount(Buyer buyer, double discount)
        {
            Console.WriteLine($"Order cost {buyer.Name} {buyer.Sonmae}: {buyer.OrderCost}\n");
            buyer.OrderCost = buyer.OrderCost - (buyer.OrderCost * discount);
            Console.WriteLine($"New cost {buyer.OrderCost}");
        }
        static void CreateBuyer(string name, string soname)
        {
            Buyer.buyers.Add(new Buyer(name, soname));
        }
    }
}
