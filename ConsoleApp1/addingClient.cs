using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class addingClient
    {
        public void addClient()
        {
            string signs;
            bool t = true;
            while (t)
            {
                List<clients> listClients = new List<clients>();
                clients newClient = new clients();
                SerializationClients serializator = new SerializationClients();
                foreach (var log in serializator.deserialize())
                {
                    listClients.Add(log);
                }
                Console.WriteLine("Podaj numer opcji: \n1 - Dodaj klienta \n2 - Cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    bool a = true;
                    while (a)
                    {
                        Console.WriteLine("Podaj imię");
                        signs = Console.ReadLine().ToUpper();

                        if (signs.Length >= 3)
                        {
                            newClient.Name = signs;
                            a = false;
                        }
                    }
                    bool l = true;
                    while (l)
                    {
                        Console.WriteLine("Podaj imię klienta");
                        signs = Console.ReadLine().ToUpper();

                        if (signs.Length >= 3)
                        {
                            newClient.Name = signs;
                            l = false;
                        }
                    }

                    string Surname;

                    do
                    {
                        Console.WriteLine("Wprowadź nazwisko klienta");
                        Surname = Console.ReadLine();
                    } while (Console.ReadLine() == "");
                    newClient.Surname = Surname;

                    string id_nr;
                    do
                    {
                        Console.WriteLine("Wprowadź numer dowodu klienta");
                        id_nr = Console.ReadLine();
                    } while (Console.ReadLine() == "");

                    newClient.Id_nr = id_nr;

                    string address;
                    do
                    {
                        Console.WriteLine("Wprowadź adres zameldowania klienta");
                        address = Console.ReadLine();
                    } while (Console.ReadLine() == "");

                    newClient.Address = address;


                    listClients.Add(newClient);
                    serializator.serialize(listClients);

                    foreach (var VARIABLE in listClients)
                    {
                        Console.WriteLine(VARIABLE);

                    }

                }

                if (j != 1)
                {
                    t = false;
                }
            }
        }
    }
}
