using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class SerializationCars : ISerializeCar
    {
     
        XmlSerializer serializer = new XmlSerializer(typeof(List<cars>));

        public void serialize(List<cars> carsList)
        {

            carsList.ForEach(Console.WriteLine);


            try
            {
                using (TextWriter writer = new StreamWriter(@"./CARS.xml"))
                {
                    serializer.Serialize(writer, carsList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            carsList.Clear();
          
        }

        public List<cars> deserialize()
        {
            List<cars> newCarList = new List<cars>();

            try
            {
                using (TextReader reader = new StreamReader(@"./CARS.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newCarList = (List<cars>) obj;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return newCarList; 
        }
    }
}