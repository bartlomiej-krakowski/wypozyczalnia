using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class deleteRent
    {
        public void DeleteRentList()
        {
            string del;
            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj numer opcji: \n1 - Usuń wypożyczenie \n2 - Cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    rents deleteRent = new rents();
                    List<rents> listRents = new List<rents>();
                    SerializationRents serializator = new SerializationRents();

                    foreach (var log in serializator.deserialize())
                    {
                        listRents.Add(log);
                        Console.WriteLine(log);
                    }

                    bool itstrue = true;
                    int i;
                    while (itstrue)
                    {
                        Console.WriteLine("Podaj ID wypożyczenia");
                        del = Console.ReadLine();
                        deleteRent.Id = del;
                        i = listRents.LastIndexOf(new rents(deleteRent.Id));
                        itstrue = false;
                        listRents.RemoveAt(i);
                    }
                    serializator.serialize(listRents);
                }

                if (j != 1)
                {
                    t = false;
                }
            }
        }
    }
}