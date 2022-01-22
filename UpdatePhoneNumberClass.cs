using System;

namespace PhoneBook
{
    class UpdatePhoneNumberClass
    {
        public void UpdatePerson(string name,string surname)
            {
                int phoneBookCount = Directory.phoneBookList.Count;
                bool Found = false;
                for (int i = 0; i < phoneBookCount; i++)
                {
                    if(Directory.phoneBookList[i].Name1 == name && Directory.phoneBookList[i].Surname1 == surname)
                    {
                        Found = true;
                        Console.WriteLine("{0} {1} adlı kişiyi güncellemek üzere, onaylıyor musunuz ?(y/n)",name,surname);
                        string answer = Console.ReadLine();
                        while(answer!="y" && answer!="n")
                        {
                            Console.WriteLine("Hatalı giriş yaptınız.{0} {1} adlı kişiyi güncellemek üzere, onaylıyor musunuz ?(y/n)",name,surname);
                            answer = Console.ReadLine();
                        }
                        if(answer=="y")
                        {
                            Console.WriteLine("Güncelleme için yeni ismi giriniz:");
                            string ansName = Console.ReadLine();
                            Directory.phoneBookList[i].Name1= ansName.ToUpper();
                            Console.WriteLine("Güncelleme için yeni soyismi giriniz:");
                            string ansSurname = Console.ReadLine();
                            Directory.phoneBookList[i].Surname1= ansSurname.ToUpper();
                            Console.WriteLine("Güncelleme için yeni numarayı giriniz:");
                            long ansNo = long.Parse(Console.ReadLine());
                            Directory.phoneBookList[i].Number1= ansNo;
                            Console.WriteLine("Numara güncellendi.");
                            Program.Options();
                        }
                        else if(answer=="n")
                            Program.Options();
                    }
                }
                if(!Found)
                {
                    NotFoundPersonToUpdate();
                    int select;
                    bool isNumber = int.TryParse(Console.ReadLine(),out select);
                    while(!isNumber || (select<1 || select>2))
                    {
                        Console.WriteLine("Hatalı giriş yaptınız");
                        NotFoundPersonToUpdate();
                        isNumber = int.TryParse(Console.ReadLine(),out select);
                    }
                    switch(select)
                    {
                        case 1:
                            Program.Options();
                            break;
                        case 2:
                            Program.UpdatePhoneNumber();
                            break;
                    }
                }
            }

            public void NotFoundPersonToUpdate()
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine(" * Yeniden denemek için              : (2)");
            }
    }
}