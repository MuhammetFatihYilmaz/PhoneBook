using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class Directory
    {

        public static List<Person> phoneBookList { get; set;}  
        static Directory()
        {
        phoneBookList = new List<Person>();
        phoneBookList.Add(new Person("AHMET", "VURAL",123456789));
        phoneBookList.Add(new Person("VELİ", "YILMAZ",812547832));
        phoneBookList.Add(new Person("AYÇA", "KAR",846387412));
        phoneBookList.Add(new Person("SERTAP", "YAVUZ",251987452));
        phoneBookList.Add(new Person("MEHMET", "YAR",698534157));
        }

        public void AddPersonToDirectory(string name, string surname, long no)
        {
            phoneBookList.Add(new Person(name,surname,no));
        }

        public void ListDirectory()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var item in phoneBookList)
            {
                Console.WriteLine("isim: {0}",item.Name1);
                Console.WriteLine("Soyisim: {0}",item.Surname1);
                Console.WriteLine("Telefon Numarası: {0}",item.Number1);
                Console.WriteLine("-");
            }
            Program.Options();
        }

    }
}