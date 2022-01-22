using System;

namespace PhoneBook
{

    class SearchInDirectoryClass
    {
            public void SearchOptionsText()
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("**********************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            }
            public void SearchOptions()
            {
                SearchOptionsText();
                int select;
                bool isNumber = int.TryParse(Console.ReadLine(),out select);
                while(!isNumber || (select<1 || select>2))
                {
                    Console.WriteLine("Hatalı giriş yaptınız");
                    SearchOptionsText();
                    isNumber = int.TryParse(Console.ReadLine(),out select);
                }
                    switch(select)
                    {
                        case 1:
                            Console.WriteLine("Arama yapmak için isim veya soyisim giriniz:");
                            string nameOrSurname = Console.ReadLine().ToUpper();
                            SeachByNameOrSurname(nameOrSurname);
                            break;
                        case 2:
                            Console.WriteLine("Arama yapmak için numarayı giriniz:");
                            long number = int.Parse(Console.ReadLine());
                            SearchByNumber(number);
                            break;
                    }
            }
            public void SeachByNameOrSurname(string search)
            {
                int phoneBookCount = Directory.phoneBookList.Count;
                bool Found = false;
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                for (int i = 0; i < phoneBookCount; i++)
                {
                    if(Directory.phoneBookList[i].Name1 == search || Directory.phoneBookList[i].Surname1 == search)
                        {
                            Found = true;                           
                            Console.WriteLine("İsim: {0}",Directory.phoneBookList[i].Name1);
                            Console.WriteLine("Soyisim: {0}",Directory.phoneBookList[i].Surname1);
                            Console.WriteLine("Telefon Numarası: {0}",Directory.phoneBookList[i].Number1);                            
                        }                                                                   
                }
                if(!Found)
                {
                    Console.WriteLine("Aradığınız kişi rehberde bulunmuyor.");
                }
                Program.Options();
            }

            public void SearchByNumber(long number)
            {
                int phoneBookCount = Directory.phoneBookList.Count;
                bool Found = false;
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                for (int i = 0; i < phoneBookCount; i++)
                {
                    if(Directory.phoneBookList[i].Number1 == number)
                        {
                            Found = true;                           
                            Console.WriteLine("İsim: {0}",Directory.phoneBookList[i].Name1);
                            Console.WriteLine("Soyisim: {0}",Directory.phoneBookList[i].Surname1);
                            Console.WriteLine("Telefon Numarası: {0}",Directory.phoneBookList[i].Number1);                            
                        }                                                                   
                }
                if(!Found)
                {
                    Console.WriteLine("Aradığınız kişi rehberde bulunmuyor.");
                }
                Program.Options();
            }
    } 
}