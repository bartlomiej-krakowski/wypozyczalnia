using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class SerializationPassword : ISerializelpass
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<userPassword>));

        public void serialize(List<userPassword> passwords)
        {
            
            passwords.ForEach(Console.WriteLine);


            try
            {
                using (TextWriter writer = new StreamWriter(@"./passwords.xml"))
                {
                    serializer.Serialize(writer, passwords);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            passwords.Clear();
            
        }

        public List<userPassword> deserialize()
        {
            List<userPassword> newPasswordList = new List<userPassword>();

            try
            {
                using (TextReader reader = new StreamReader(@"./passwords.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newPasswordList = (List<userPassword>) obj;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newPasswordList;
        }

        private void displayPersonTab( List<userPassword> passwords)
        {
            foreach (userPassword password in passwords)
            {
                Console.WriteLine(password);
            }
        }
    }
}

