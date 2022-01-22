using System;

namespace PhoneBook
{
    public class CreateNewPersonClass : CreateNewPersonManager
    {
        public override string CreateNewPersonName()
        {
            string name = string.Empty;
            int numeric;
            bool isNum = true;
            while(isNum)
            {
                Console.WriteLine("Lütfen isim giriniz: ");
                name = Console.ReadLine();
                isNum = int.TryParse(name, out numeric);
                    if(isNum)
                    Console.WriteLine("Hatal giriş yaptınız.");
            }   
            return name;       
        }

        public override string CreateNewPersonSurname()
        {
            string surname = string.Empty;
            int numeric;
            bool isNum = true;
            while(isNum)
            {
                Console.WriteLine("Lütfen soyisim giriniz");
                surname = Console.ReadLine();
                isNum = int.TryParse(surname, out numeric);
                    if(isNum)
                    Console.WriteLine("Hatal giriş yaptınız.");
            }
            return surname;
        }

        public override long CreateNewPersonNumber()
        {
            bool isNum = false;
            long number = 0;
            while(!isNum)
            {
            Console.WriteLine("Lütfen numara giriniz");
            isNum = long.TryParse(Console.ReadLine(),out number);
                if(!isNum)
                Console.WriteLine("Hatal giriş yaptınız.");
            } 
            return number;
        }
    }
}