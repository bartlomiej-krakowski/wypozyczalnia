using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class DateUSer
    {
        private static List<userLogin> generateDataLogin()
        {
            List<userLogin> userLoginList = new List<userLogin>();
            userLogin userLogin = new userLogin("admin",1);
            userLogin userLogin2 = new userLogin("user",2);
            userLoginList.Add(userLogin);
            userLoginList.Add(userLogin2);

            return userLoginList;
        }

        private static List<userPassword> generateDataPassword()
        {
            List<userPassword> userPasswordsList = new List<userPassword>();
            userPassword userPassword = new userPassword("admin");
            userPassword userPasswords2 = new userPassword("user");
            userPasswordsList.Add(userPassword);
            userPasswordsList.Add(userPasswords2);
            return userPasswordsList;
        }

        public void generateDate()
        {
            List<userLogin> logins = generateDataLogin();
            ISerializelogin SerializerLogin = new SerializationLogin();
            SerializerLogin.serialize(logins);
//            userLogin[] log = logins.ToArray();
//            ((SerializationLogin) SerializerLogin).serialize(log);


            List<userPassword> passwords = generateDataPassword();
            ISerializelpass SerializerPassword = new SerializationPassword();
            SerializerPassword.serialize(passwords);

//            userPassword[] pass = passwords.ToArray();
//            ((SerializationPassword) SerializerPassword).serialize(pass);
        }
    }
}