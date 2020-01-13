using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class SerializationRents : ISerializeRent
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<rents>));

        public void serialize(List<rents> rentsList)
        {

            rentsList.ForEach(Console.WriteLine);


            try
            {
                using (TextWriter writer = new StreamWriter(@"./rents.xml"))
                {
                    serializer.Serialize(writer, rentsList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            rentsList.Clear();

        }

        public List<rents> deserialize()
        {
            List<rents> newRentList = new List<rents>();

            try
            {
                using (TextReader reader = new StreamReader(@"./rents.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newRentList = (List<rents>)obj;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newRentList;
        }
    }
}