using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class deleteCars
    {
        public void DeleteCarList()
        {
            string del;
            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj numer opcji: \n1 - Usuń auto \n2 - Cofnij");
                int j;
                int.TryParse(Console.ReadLine(),out j);
                if (j==1)
                {


                    cars deleteCar = new cars();
                    List<cars> listCars = new List<cars>();
                    SerializationCars serializator = new SerializationCars();

                    foreach (var log in serializator.deserialize())
                    {
                        listCars.Add(log);
                        Console.WriteLine(log);
                    }

                    bool itstrue = true;
                    int i;
                    while (itstrue)
                    {
                        Console.WriteLine("Podaj numer VIN samochodu do usuniecia z bazy");
                        del = Console.ReadLine().ToUpper();
                        if (del.Length == 17) 
                        {  
                            deleteCar.Nr_vin = del;
                            i = listCars.LastIndexOf(new cars(deleteCar.Nr_vin));
                            itstrue = false;
                            listCars.RemoveAt(i);
                        }
                        if (del.Length != 17)
                        {
                            Console.WriteLine("Błąd VIN ma 17 znaków");
                        }
                    }
                    serializator.serialize(listCars);
                }

                if (j!=1)
                {
                    t = false;
                }
            }
        }
    }
}