using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class addingCars 
    {                    

        public void AddCarList()
        {
            string znaki;
            bool t = true;
            while (t)
            {
                List<cars> listCars = new List<cars>();
                cars newCars = new cars();
                SerializationCars serializator = new SerializationCars();
                foreach (var log in serializator.deserialize())
                {
                    listCars.Add(log);
                }
                Console.WriteLine("Podaj numer opcji: \n1 - Dodaj auto \n2 - Cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    bool a = true;
                    while (a)
                    {
                        Console.WriteLine("Podaj markę samochodu");
                        znaki = Console.ReadLine().ToUpper();
                        
                        if (znaki.Length >= 3)
                        {
                            newCars.Mark = znaki;
                            a = false;
                        }
                    }
                    bool l = true;
                    while (l)
                    {
                        Console.WriteLine("Podaj model samochodu");
                        znaki = Console.ReadLine().ToUpper();

                        if (znaki.Length >= 3)
                        {
                            newCars.Model = znaki;
                            l = false;
                        }
                    }

                    int YearProductionCar;

                    do
                    {
                        Console.WriteLine("Wprowadź rok produkcji samochodu");
                    } while (!int.TryParse(Console.ReadLine(), out YearProductionCar));
                    newCars.Yearproduction = YearProductionCar;

                    double CourseCar;
                    do
                    {
                        Console.WriteLine("Wprowadź przebieg samochodu");
                    } while (!double.TryParse(Console.ReadLine().ToUpper(), out CourseCar));

                    newCars.Course = CourseCar;
                    bool z = true;
                    while (z)
                    {
                        Console.WriteLine("Podaj numer VIN samochodu");
                        newCars.Nr_vin = Console.ReadLine().ToUpper();
                        if (newCars.Nr_vin.Length == 17 )
                        {
                            z = false;
                        }

                        if (newCars.Nr_vin.Length != 17)
                        {
                            Console.WriteLine("Błąd, numer VIN ma 17 znaków");
                        }
                    }

                    bool q = true;
                    while (q)
                    {
                        Console.WriteLine("Podaj numer rejestracyjny samochodu");
                        znaki = Console.ReadLine().ToUpper();

                        if (znaki.Length >= 3)
                        {
                            newCars.Nr_registration = znaki;
                            q = false;
                        }

                        if (newCars.Model.Length < 3)
                        {
                            Console.WriteLine("Błąd");
                        }
                    }

                    bool dost = true;
                    while (dost)
                    {
                        Console.WriteLine("Czy auto jest dostępne? \nTAK/NIE");
                        znaki = Console.ReadLine().ToUpper();

                        if (znaki=="TAK" || znaki =="YES"||znaki=="Y" || znaki == "T")
                        {
                            newCars.Loan = true;
                            dost = false;
                        }

                        if (znaki !="TAK")
                        {
                            newCars.Loan = false;

                        }
                    }

                    listCars.Add(newCars);
                    serializator.serialize(listCars);

                    foreach (var VARIABLE in listCars)
                    {
                        Console.WriteLine(VARIABLE);

                    }

                }

                if (j!=1)
                {
                    t = false;
                }
            }
        }

        public void ListCars()
        {
            List<cars> listCars = new List<cars>();
            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj nr. opcj: \n1 - Lista aut \n2 - cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j==1)
                {
                    SerializationCars serializator = new SerializationCars();

                    foreach (var log in serializator.deserialize())
                    {
                        listCars.Add(log);
                        Console.WriteLine(log);
                    }
                }

                if (j!=1)
                {
                    t = false;
                }
            }
        }

    }
}