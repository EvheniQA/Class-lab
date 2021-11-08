using System;


namespace ConsoleApp1
{
    class Users
    {
        private int age = 18;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        private string name = "evhenii";

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Users users1 = new Users();
            users1.ShowInfo();
        }
    }
}
