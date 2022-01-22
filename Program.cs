using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Options();
        }

        public static void Options()
        {
            bool isNumber = false;
            int selectNumber = 0;

            OptionsText();
            isNumber = int.TryParse(Console.ReadLine(), out selectNumber);
            while(!isNumber)
            {
                Console.WriteLine("Hatalı giriş yaptınız");
                OptionsText();
                isNumber = int.TryParse(Console.ReadLine(), out selectNumber);
                if(isNumber && (selectNumber < 1 || selectNumber>5))
                {
                    Console.WriteLine("Hatalı giriş yaptınız");
                    isNumber = false;
                }                    
            }


             switch(selectNumber)
             { 
                 case 1:
                    SavePhoneNumber();
                    break;
                 case 2:
                    DeletePhoneNumber();
                    break;
                 case 3:
                    UpdatePhoneNumber();
                    break;
                 case 4:
                    ListAllPersonInDirectory();
                    break;
                 case 5:
                    SearchPersonInDirectory();
                    break;
                 default: 
                 break;
             }
        }

        public static void OptionsText()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
        }

        public static void SavePhoneNumber()
        {
            CreateNewPersonClass createNewPerson = new CreateNewPersonClass();
            string name = createNewPerson.CreateNewPersonName().ToUpper();
            string surname = createNewPerson.CreateNewPersonSurname().ToUpper();
            long no = createNewPerson.CreateNewPersonNumber();
            Directory directory = new Directory();
            directory.AddPersonToDirectory(name,surname,no);
            Console.WriteLine("Kişi rehbere başarılı bir şekilde eklendi.");
            Program.Options();
        }

        public static void DeletePhoneNumber()
        {
            DeletePhoneNumberClass deletePhoneNumber = new DeletePhoneNumberClass();
            Console.WriteLine("Lütfen silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string person = Console.ReadLine().ToUpper();
            deletePhoneNumber.DeleteNumber(person);

        }

        public static void UpdatePhoneNumber()
        {
            UpdatePhoneNumberClass updatePhoneNumber = new UpdatePhoneNumberClass();
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını giriniz:");
            string personName = Console.ReadLine().ToUpper();
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin soyadını giriniz:");
            string personSurname = Console.ReadLine().ToUpper();
            updatePhoneNumber.UpdatePerson(personName,personSurname);
        }

        public static void ListAllPersonInDirectory()
        {
            Directory directory = new Directory();
            directory.ListDirectory();
        }

        public static void SearchPersonInDirectory()
        {
            SearchInDirectoryClass searchInDirectory = new SearchInDirectoryClass();
            searchInDirectory.SearchOptions();
        }

    }
}
