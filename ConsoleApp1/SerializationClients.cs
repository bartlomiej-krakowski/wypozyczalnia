using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class SerializationClients : ISerializeClient
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<clients>));

        public void serialize(List<clients> clientsList)
        {

            clientsList.ForEach(Console.WriteLine);


            try
            {
                using (TextWriter writer = new StreamWriter(@"./clients.xml"))
                {
                    serializer.Serialize(writer, clientsList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            clientsList.Clear();

        }

        public List<clients> deserialize()
        {
            List<clients> newClientList = new List<clients>();

            try
            {
                using (TextReader reader = new StreamReader(@"./clients.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newClientList = (List<clients>)obj;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newClientList;
        }
    }
}