using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace Wypozyczalnia
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
            get
            {
                return login;
            }

            set
            {
                bool k = true;
                while (k)
                {
                    value = Console.ReadLine();

                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Bład podano pusty ciąg znaków");


                    }
                    if (!string.IsNullOrEmpty(value))
                    {
                        login = value;
                        k = false;
                    }
                }


            }
        }


        public void log()
        {
            Console.WriteLine("Podaj login: ");
            Login = null;


            securePwd = new SecureString();
            ConsoleKeyInfo key;

            Console.Write("Podaj hasło: ");
            do
            {
                key = Console.ReadKey(true);

                // Ignore any key out of range.
                if (((int)key.Key) >= 65 && ((int)key.Key <= 90))
                {
                    // Append the character to the password.
                    securePwd.AppendChar(key.KeyChar);
                    Console.Write("*");
                }
                // Exit if Enter key is pressed.
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();



            try
            {
                if (Marshal.PtrToStringUni(Marshal.SecureStringToGlobalAllocUnicode(securePwd)) == "abs")
                {
                    Console.WriteLine("haslo jest prawidłowe");
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

