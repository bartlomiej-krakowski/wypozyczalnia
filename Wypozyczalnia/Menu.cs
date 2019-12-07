using System;
using System.Text;

namespace Wypozyczalnia
{
    public class Menu
    {
        enum Admin { dodaj_samochód = 1, usuń_samochód, lista_aut, dodaj_klienta, usuń_klienta, lista_pracowników, dodaj_wypożyczenie, anuluj_wypożyczenie, zmodyfikuj_wypozyczenie, dodaj_pracownika, usuń_pracownika, licencja_programu, statystyka, wyloguj };
        enum User { dodaj_klienta = 1, dodaj_samochód, lista_aut, dodaj_wypozyczenie, anuluj_wypozyczenie, zmodyfikuj_wypożyczenie, wyloguj };

        public void menu()
        {
            int i = 1;

            foreach (Admin admin in (Admin[])Enum.GetValues(typeof(Admin)))
            {
                Console.Write($"[{i++}]. ");
                Console.WriteLine(String.Concat(admin.ToString().Replace('_', ' ')));
            }

            bool exit = true;

            Admin start;
            string choosenOption = Console.ReadLine().Replace(' ', '_');


            bool AdminConfirmed = Enum.TryParse<Admin>(choosenOption, out start);

            if (!AdminConfirmed)
            {
                Console.WriteLine("Wybrałeś niepoprawną opcję");
            }

            switch (start)
            {
                case Admin.dodaj_samochód:
                    break;
                case Admin.usuń_samochód:
                    break;
                case Admin.lista_aut:
                    break;
                case Admin.dodaj_klienta:
                    break;
                case Admin.usuń_klienta:
                    break;
                case Admin.lista_pracowników:
                    break;
                case Admin.dodaj_wypożyczenie:
                    break;
                case Admin.anuluj_wypożyczenie:
                    break;
                case Admin.zmodyfikuj_wypozyczenie:
                    break;
                case Admin.dodaj_pracownika:
                    break;
                case Admin.usuń_pracownika:
                    break;
                case Admin.licencja_programu:
                    break;
                case Admin.statystyka:
                    break;
                case Admin.wyloguj:
                    break;
                default:
                    break;
            }
        }
    }
}
