using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class stats
    {
        public void statsWriter()
        {
            SerializationCars serialiaz = new SerializationCars();
            SerializationLogin serializationLogin = new SerializationLogin();

            List<cars> listCar = new List<cars>();
            List<userLogin> listUser = new List<userLogin>();
            foreach (var item in serialiaz.deserialize())
            {
                listCar.Add(item);
            }

            foreach (var item in serializationLogin.deserialize())
            {
                listUser.Add(item);

            }

            Console.WriteLine($"Liczba pracowników: {listUser.Count}\nLiczba pojazdów: {listCar.Count}");

            Console.ReadKey();
        }
    }
}