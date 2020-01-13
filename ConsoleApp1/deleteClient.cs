using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class deleteClient
    {
        public void deleteClientList()
        {
            string del;
            int delInt;
            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj numer opcji: \n1 - Usuń klienta \n2 - Cofnij");
                int.TryParse(Console.ReadLine(), out delInt);
                if (delInt == 1)
                {


                    clients deleteClient = new clients();
                    List<clients> listClients = new List<clients>();
                    SerializationClients serializator = new SerializationClients();

                    foreach (var log in serializator.deserialize())
                    {
                        listClients.Add(log);
                        Console.WriteLine(log);
                    }

                    bool itstrue = true;
                    int i;
                    while (itstrue)
                    {
                        Console.WriteLine("Podaj numer PESEL klienta");
                        del = Console.ReadLine().ToUpper();
                        if (del.Length == 11)
                        {
                            int.TryParse(Console.ReadLine(), out delInt);
                            deleteClient.Pesel = delInt;
                            i = listClients.LastIndexOf(new clients(deleteClient.Pesel));
                            itstrue = false;
                            listClients.RemoveAt(i);
                        }
                        if (del.Length != 11)
                        {
                            Console.WriteLine("Błąd PESEL ma 17 znaków");
                        }
                    }
                    serializator.serialize(listClients);
                }

                if (delInt != 1)
                {
                    t = false;
                }
            }
        }
    }
}