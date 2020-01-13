using System;

namespace ConsoleApp1
{
    public class Menu
    {
        enum Admin
        {
            dodaj_samochód = 1,
            usuń_samochód,
            lista_aut,
            dodaj_klienta,
            usuń_klienta,
            lista_pracowników,
            dodaj_wypożyczenie,
            anuluj_wypożyczenie,
            zmodyfikuj_wypozyczenie,
            dodaj_pracownika,
            usuń_pracownika,
            licencja_programu,
            statystyka,
            wyloguj
        };

        enum User
        {
            dodaj_klienta = 1,
            dodaj_samochód,
            lista_aut,
            dodaj_wypozyczenie,
            anuluj_wypozyczenie,
            zmodyfikuj_wypożyczenie,
            wyloguj
        };

        public void menuAdmina()
        {
            bool k = true;
            while (k)
            {
                Console.Clear();
                Console.WriteLine("Admin:");
                int i = 1;

                foreach (Admin admin in (Admin[]) Enum.GetValues(typeof(Admin)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(admin.ToString().Replace('_', ' ')));
                }

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
                        addingCars adding = new addingCars();
                        adding.AddCarList();
                        break;
                    case Admin.usuń_samochód:
                        deleteCars delete = new deleteCars();
                        delete.DeleteCarList();
                        break;
                    case Admin.lista_aut:
                        addingCars listing = new addingCars();
                        listing.ListCars();
                        break;
                    case Admin.dodaj_klienta:
                        addingClient addingClient = new addingClient();
                        addingClient.addClient();
                        break;
                    case Admin.usuń_klienta:
                        deleteClient deleteClient = new deleteClient();
                        deleteClient.deleteClientList();
                        break;
                    case Admin.lista_pracowników:
                        addEmployee listUser = new addEmployee();
                        listUser.listEmployee();
                        break;
                    case Admin.dodaj_wypożyczenie:
                        addingRent addingRent = new addingRent();
                        addingRent.addRent();
                        break;
                    case Admin.anuluj_wypożyczenie:
                        deleteRent deleteRent = new deleteRent();
                        deleteRent.DeleteRentList();
                        break;
                    case Admin.zmodyfikuj_wypozyczenie:
                        deleteRent modRentDel = new deleteRent();
                        modRentDel.DeleteRentList();
                        addingRent modRentAdd = new addingRent();
                        modRentAdd.addRent();
                        break;
                    case Admin.dodaj_pracownika:
                        addEmployee add = new addEmployee();
                        add.Adiing();
                        break;
                    case Admin.usuń_pracownika:
                        deleteEmployee delte = new deleteEmployee();
                        delte.Delete();
                        break;
                    case Admin.licencja_programu:
                        licence licence = new licence();
                        licence.DisplayLicence();
                        break;
                    case Admin.statystyka:
                        stats stats = new stats();
                        stats.statsWriter();
                        break;
                    case Admin.wyloguj:

                        k = false;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void menuUsera()
        {
            bool k = true;
            while (k)
            {
                Console.Clear();

                Console.WriteLine("User:");

                int i = 1;

                foreach (User admin in (User[]) Enum.GetValues(typeof(User)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(admin.ToString().Replace('_', ' ')));
                }

                User start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');


                bool AdminConfirmed = Enum.TryParse<User>(choosenOption, out start);

                if (!AdminConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    case User.dodaj_klienta:
                        addingClient addingClient = new addingClient();
                        addingClient.addClient();
                        break;
                    case User.dodaj_samochód:
                        addingCars adding = new addingCars();
                        adding.AddCarList();
                        break;
                    case User.lista_aut:
                        addingCars lists = new addingCars();
                        lists.ListCars();
                        break;
                    case User.dodaj_wypozyczenie:
                        addingRent addingRent = new addingRent();
                        addingRent.addRent();
                        break;
                    case User.anuluj_wypozyczenie:
                        deleteRent deleteRent = new deleteRent();
                        deleteRent.DeleteRentList();
                        break;
                    case User.zmodyfikuj_wypożyczenie:
                        break;
                    case User.wyloguj:
                        k = false;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}