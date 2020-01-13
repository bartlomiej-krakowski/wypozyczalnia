using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class deleteEmployee
    {
        public void Delete()
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj Numer opcji: \n1 - Usuń użytkownika\n2 - cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    userLogin delteLogin = new userLogin();
                    List<userLogin> logins = new List<userLogin>();
                    List<userPassword> passwords = new List<userPassword>();

                    SerializationLogin login = new SerializationLogin();
                    SerializationPassword password = new SerializationPassword();

                    foreach (var log in login.deserialize())
                    {
                        logins.Add(log);
                        Console.WriteLine($"Login: {log}");
                    }

                    foreach (var pass in password.deserialize())
                    {
                        passwords.Add(pass);
                    }

                    Console.WriteLine("Podaj login do usunięcia");
                    Console.WriteLine();
                    bool ta = true;
                    while (ta)
                    {
                        delteLogin.Login = Console.ReadLine().ToLower();
                        int i = logins.IndexOf(new userLogin(delteLogin.Login));
                        if (i >=0)
                        {
                            logins.RemoveAt(i);
                            passwords.RemoveAt(i);
                            ta = false;
                        }

                        if (i<0)
                        {
                            Console.WriteLine("Błąd zły login");

                        }
                        
                    }

                    ISerializelogin SerializerLogin = new SerializationLogin();
                    SerializerLogin.serialize(logins);
                    ISerializelpass SerializerPassword = new SerializationPassword();
                    SerializerPassword.serialize(passwords);
                }

                if (j != 1)
                {
                    t = false;
                }
            }
        }
    }
}