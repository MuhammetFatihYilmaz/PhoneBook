using System;

namespace PhoneBook
{
    class DeletePhoneNumberClass
    {
            public void DeleteNumber(string search)
            {
                int phoneBookCount = Directory.phoneBookList.Count;
                bool Found = false;
                for (int i = 0; i < phoneBookCount; i++)
                {
                    if(Directory.phoneBookList[i].Name1 == search || Directory.phoneBookList[i].Surname1 == search)
                        {
                            Found = true;
                            Console.WriteLine("{0} {1} adlı kişiyi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",Directory.phoneBookList[i].Name1,Directory.phoneBookList[i].Surname1);
                            string answer = Console.ReadLine();
                            while(answer!="y" && answer!="n")
                            {
                                Console.WriteLine("Hatalı giriş yaptınız.{0} {1} adlı kişiyi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",Directory.phoneBookList[i].Name1,Directory.phoneBookList[i].Surname1);
                                answer = Console.ReadLine();
                            }
                            if(answer=="y")
                            {
                                Directory.phoneBookList.Remove(Directory.phoneBookList[i]);
                                Console.WriteLine("Kişi rehberden silindi.");
                                Program.Options();
                            }
                            else if(answer=="n")
                                Program.Options();

                        }                        
                     
                }
                if(!Found)
                {
                    NotFoundPersonToDelete();
                    int select;
                    bool isNumber = int.TryParse(Console.ReadLine(),out select);
                    while(!isNumber || (select<1 || select>2))
                    {
                        Console.WriteLine("Hatalı giriş yaptınız");
                        NotFoundPersonToDelete();
                        isNumber = int.TryParse(Console.ReadLine(),out select);
                    }
                    switch(select)
                    {
                        case 1:
                            Program.Options();
                            break;
                        case 2:
                            Program.DeletePhoneNumber();
                            break;
                    }
                }
            }

            public void NotFoundPersonToDelete()
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız:");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
            }
    }
}