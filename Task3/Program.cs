using System;

namespace ConsoleApp1
{
    class Worker
    {
        public float Salary { get; set; }

        public static float operator +(Worker w1, float val)
        {
            return w1.Salary + (w1.Salary * val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float prize;
            Console.WriteLine("Enter prize");
            prize = float.Parse(Console.ReadLine());
            Worker worker = new Worker { Salary = 6000f };
            Console.WriteLine(worker + prize);
        }
    }
}
