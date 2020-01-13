using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class SerializationLogin : ISerializelogin 
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<userLogin>));

        public void serialize(List<userLogin> userList)
        {
      
            userList.ForEach(Console.WriteLine);


            try
            {
                using (TextWriter writer = new StreamWriter(@"./persons.xml"))
                {
                    serializer.Serialize(writer, userList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            userList.Clear();
          
        }

        public List<userLogin> deserialize()
        {
            List<userLogin> newUserList = new List<userLogin>();

            try
            {
                using (TextReader reader = new StreamReader(@"./persons.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newUserList = (List<userLogin>) obj;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return newUserList; 
        }


        private void displayPersonTab(List<userLogin> userList)
        {
            foreach (userLogin list in userList)
            {
                Console.WriteLine(list);
            }
        }
    }
}