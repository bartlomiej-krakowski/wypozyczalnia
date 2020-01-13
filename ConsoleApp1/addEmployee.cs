using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1
{
    public class addEmployee
    {
        public void Adiing()
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj Numer opcji: \n1 - Dodaj użytkownika\n2 - cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    userLogin newLogin = new userLogin();
                    userPassword newPassword = new userPassword();
                    List<userLogin> logins = new List<userLogin>();
                    List<userPassword> passwords = new List<userPassword>();

                    SerializationLogin login = new SerializationLogin();
                    SerializationPassword password = new SerializationPassword();

                    foreach (var log in login.deserialize())
                    {
                        logins.Add(log);
                    }

                    foreach (var pass in password.deserialize())
                    {
                        passwords.Add(pass);
                    }

                    bool lo = true;
                    while (lo)
                    {
                        Console.WriteLine("Wprowadź login:");
                        Console.WriteLine();
                        newLogin.Login = Console.ReadLine().ToLower();

                        if (newLogin.Login.Length >2)
                        {
                            lo = false;
                        }
                    }
                    
                    bool k = true;
                    int i;
                    while (k)
                    {
                        Console.WriteLine("Nadaj uprawnienia \n1 - admin \n2 - user");
                        int.TryParse(Console.ReadLine(), out i);
                        if (i >= 1 && i <= 2)
                        {
                            newLogin.Permisson = i;
                            k = false;
                        }

                        if (i > 2)
                        {
                            Console.WriteLine("Uprawnienia: \n1- admin \n2-użytkownik ");
                        }
                    }

                   
                    bool pa = true;
                    while (pa)
                    {
                        Console.WriteLine("Wprowadź hasło:");
                        Console.WriteLine();
                        newPassword.Password = Console.ReadLine().ToLower();

                        if (newPassword.Password.Length >2)
                        {
                            pa = false;
                        }
                        
                    }
                    logins.Add(newLogin);
                    passwords.Add(newPassword);

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

        public void listEmployee()
        {
            List<userLogin> list = new List<userLogin>();
            SerializationLogin serialize = new SerializationLogin();
            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj nr. opcj: \n1 - Lista użytkowników \n2 - cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    foreach (var user in serialize.deserialize())
                    {
                        list.Add(user);
                        Console.WriteLine(user);
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



