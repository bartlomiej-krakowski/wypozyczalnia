using System;

namespace Wypozyczalnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*1");
            Console.WriteLine("Podaj login uzytkownika: ");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj hasło uzytkownika: ");
            string haslo = Console.ReadLine();
            //zapisujemy logi i hasło do pliku xml
            if (login == "admin" && haslo == "admin")
            {
                Menu menu = new Menu();
                menu.menu();

            }
            else if (login == "user" && haslo == "user")
            {

            }
            else
            {
                Console.WriteLine("Podałeś złe hasło");
            }


        }
    }
}