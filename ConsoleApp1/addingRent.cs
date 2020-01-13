using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class addingRent
    {
        public void addRent()
        {
            bool t = true;
            while (t)
            {
                List<rents> listRents = new List<rents>();
                rents newRent = new rents();
                SerializationRents serializator = new SerializationRents();
                foreach (var log in serializator.deserialize())
                {
                    listRents.Add(log);
                }

                string id;
                Console.WriteLine("Podaj numer opcji: \n1 - Dodaj wypożyczenie \n2 - Cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    bool a = true;
                    while (a)
                    {
                        Console.WriteLine("Podaj ID");
                        id = Console.ReadLine();
                        newRent.Id = id;
                        a = false;
                    }

                    string vin;
                    bool l = true;
                    while (l)
                    {
                        Console.WriteLine("Podaj VIN pojazdu");
                        vin = Console.ReadLine().ToUpper();

                        if (vin.Length == 17)
                        {
                            newRent.Vin = vin;
                            l = false;
                        }
                    }

                    int pesel;
                    do
                    {
                        Console.WriteLine("Wprowadź PESEL klienta");
                        int.TryParse(Console.ReadLine(), out pesel);
                    } while (Console.ReadLine() == "");

                    newRent.Pesel = pesel;

                    string date_start;
                    do
                    {
                        Console.WriteLine("Wprowadź date początkową");
                        date_start = Console.ReadLine();
                    } while (Console.ReadLine() == "");

                    newRent.Date_start = DateTime.Parse(date_start);

                    string date_stop;
                    do
                    {
                        Console.WriteLine("Wprowadź date końcową");
                        date_stop = Console.ReadLine();
                    } while (Console.ReadLine() == "");

                    newRent.Date_stop = DateTime.Parse(date_stop);

                    listRents.Add(newRent);
                    serializator.serialize(listRents);

                    foreach (var VARIABLE in listRents)
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
