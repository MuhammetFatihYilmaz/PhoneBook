using System;

namespace PhoneBook
{
        public class Person
        {
            private string Name;
            private string Surname;
            private long Number;
            //
            public string Name1 { get => Name; set => Name = value; }
            public string Surname1 { get => Surname; set => Surname = value; }
            public long Number1 { get => Number; set => Number = value; }

            public Person(string name, string surname, long number)
            {
                Name1 = name;
                Surname1 = surname;
                Number1 = number;
            }
        }

}