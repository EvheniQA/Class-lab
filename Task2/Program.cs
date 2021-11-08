using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    class User
    {
        private string _name;
        private string _soname;
        private Guid _id;
        private int _age;

        public string Name { get { return _name; } }
        public string Soname { get { return _soname; } }
        public Guid Id { get { return _id; } }
        public int Age { get { return _age; } }

        public User(string name, string soname, int age)
        {
            _name = name;
            _soname = soname;
            _age = age;
            _id = Guid.NewGuid();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"name = {_name}\nsurname =  {_soname}\nID = {_id}\nAge = {_age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5] { "Evhenii", "dima", "olena", "taras", "yehor" };
            string[] soname = new string[5] { "tymoshenko", "Kolesnyk", "birina", "yakybovich", "marnolog" };
            int[] age = Enumerable.Range(18, 23).ToArray();

            List<User> Users = new List<User>();

            for (int i = 0; i < 5; i++)
            {
                Users.Add(new User(name[i], soname[i], age[i]));
            }
            Console.WriteLine(Users[4].Id);
            Search(Users);
        }
        static void Search(List<User> Users)
        {
            Console.WriteLine("Choose serch param\n1) Name\n2) Soname\n3) Age\n4) ID");
            int arg;
            bool flag = Int32.TryParse(Console.ReadLine(), out arg);
            if (!flag || arg > 4 || arg < 1)
            {
                Console.WriteLine("Incorrect input!");
                return;
            }
            Console.WriteLine("Enter serch query");
            string answer = Console.ReadLine().ToLower();
            int convertAnswer;
            Guid convertId;

            switch (arg)
            {
                case 1:
                    if (Users.Exists(u => u.Name.Equals(answer)))
                    {
                        User selectedUser = Users.First(u => u.Name.Equals(answer));
                        selectedUser.ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("There is not User with this parameters!");
                    }
                    break;
                case 2:
                    if (Users.Exists(u => u.Soname.Equals(answer)))
                    {
                        User selectedUser1 = Users.First(u => u.Soname.Equals(answer));
                        selectedUser1.ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("There is not User with this parameters!");
                    }
                    break;
                case 3:
                    Int32.TryParse(answer, out convertAnswer);
                    if (Users.Exists(u => u.Age == convertAnswer))
                    {
                        User selectedUser2 = Users.First(u => u.Age == convertAnswer);
                        selectedUser2.ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("There is not User with this parameters!");
                    }
                    break;
                case 4:
                    Guid.TryParse(answer, out convertId);
                    if (Users.Exists(u => u.Id.Equals(convertId)))
                    {
                        User selectedUser3 = Users.First(u => u.Id.Equals(convertId));
                        selectedUser3.ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("There is not User with this parameters!");
                    }
                    break;
            }
        }
    }
}

