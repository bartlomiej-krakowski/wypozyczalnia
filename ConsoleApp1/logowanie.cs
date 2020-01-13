using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1
{
    class logowanie
    {
        private string login;
        private SecureString securePwd;

        public logowanie()
        {
        }

        public string Login
        {
            get { return login; }

            set
            {
                if (value != null)
                {
                    login = value;
                }
                else
                {
                    Console.WriteLine("Bład podano pusty ciąg znaków");
                }
            }
        }


        public void log()
        {
            bool t = true;
            while (t)
            {
                Console.Clear();
                Console.WriteLine("Exit - press 1");
                int i;
                int.TryParse(Console.ReadLine(), out i);
                if (i == 1)
                {
                    t = false;
                    break;
                    
                }

                Console.WriteLine("Enter Login: ");
                Login = Console.ReadLine();


                Console.WriteLine("Enter Password: ");
                
              

                securePwd = new SecureString();
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);

                    // Ignore any key out of range.
                    if (((int) key.Key) >= 65 && ((int) key.Key <= 90))
                    {
                        // Append the character to the password.
                        securePwd.AppendChar(key.KeyChar);
                        Console.Write("*");
                    }

                    // Exit if Enter key is pressed.
                } while (key.Key != ConsoleKey.Enter);

                Console.WriteLine();
                Console.WriteLine();
                SerializationLogin loginn = new SerializationLogin();
                SerializationPassword passs = new SerializationPassword();
                Console.WriteLine(loginn.deserialize().Contains(new userLogin {Login = login}));
                try
                {
                    if (loginn.deserialize().Contains(new userLogin {Login = login}) == true)
                    {
                        if (passs.deserialize().Contains(new userPassword
                        {
                            Password = Marshal.PtrToStringUni(Marshal.SecureStringToGlobalAllocUnicode(securePwd))
                        }) == true)
                        {
                            if (loginn.deserialize().IndexOf(new userLogin(login)) == passs.deserialize()
                                    .IndexOf(new userPassword(
                                        Marshal.PtrToStringUni(Marshal.SecureStringToGlobalAllocUnicode(securePwd)))))
                            {

                                if (loginn.deserialize().Exists(x => x.Login == login && x.Permisson == 1))
                                {
                                    Menu menu = new Menu();
                                    menu.menuAdmina();
                                }

                                if (loginn.deserialize().Exists(x => x.Login == login && x.Permisson == 2))
                                {
                                    Menu menu = new Menu();
                                    menu.menuUsera();
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect login or password");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect login or password");
                    }
                }
                catch (Win32Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    securePwd.Dispose();
                }
            }
        }
    }
}