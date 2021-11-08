using System;

namespace Class
{
    class MyClass
    {
        public MyClass()
        {
            counter++;
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();
            MyClass myClass3 = new MyClass();
            MyClass myClass4 = new MyClass();

            Console.WriteLine(MyClass.Counter);
        }
    }
}
