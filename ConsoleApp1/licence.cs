using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class serializeTime
    {


        XmlSerializer serializer = new XmlSerializer(typeof(licence));

        public void serialize(licence time)
        {



            try
            {
                using (TextWriter writer = new StreamWriter(@"./CARS.xml"))
                {
                    serializer.Serialize(writer, time);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public List<cars> deserialize()
        {
            List<cars> newUserList = new List<cars>();

            try
            {
                using (TextReader reader = new StreamReader(@"./CARS.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newUserList = (List<cars>)obj;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newUserList;
        }


    }

    [Serializable]
    [XmlRoot(" Time ")]
    class licence
    {


        DateTime date = DateTime.Today;
        DateTime date1 = DateTime.Parse("17-01-2020");

        System.TimeSpan date4;


        [XmlAttribute(" Time ")]

        public TimeSpan Date4 { get => date4; set => date4 = value; }

        public void DisplayLicence()
        {
            XmlSerializer dateserializer = new XmlSerializer(typeof(DateTime));
            System.TimeSpan date3 = date1.Subtract(date);


            using (StreamWriter zapis = new StreamWriter("czas.txt"))
            {

                zapis.WriteLine(date3);
            }

            using (StreamReader odczytCzas = new StreamReader("czas.txt"))
            {
                odczytCzas.ReadLineAsync(date3);
            }


            bool t = true;
            while (t)
            {
                Console.WriteLine("Wybierz jaką opcję chcesz wybrać: ");
                Console.WriteLine();
                Console.WriteLine("Do końca twojej licencji zostało:");
                Console.WriteLine(date3);
                Console.WriteLine("[1] Przedłóż licencję");


                Console.WriteLine("[0] Wyjście");

                int i;
                int.TryParse(Console.ReadLine(), out i);


                if (i == 1)
                {
                    Console.Clear();
                    Console.WriteLine(DateTime.Today.AddDays(365));
                    Console.WriteLine("Licencja została przedłużona");
                    Console.ReadKey();
                    using (TextWriter writer = new StreamWriter(@"./date.xml"))
                    {
                        dateserializer.Serialize(writer, date);
                    }

                    t = false;
                }

                else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Koniec");
                    t = false;
                }
                else
                {
                    Console.WriteLine("Wybrałeś nie poprawną opcję");
                }
            }
        }
    }
}
