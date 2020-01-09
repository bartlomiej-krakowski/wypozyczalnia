using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalnia_logowanie
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
            Console.WriteLine("Podaj login: ");
            Login = Console.ReadLine();


            Console.WriteLine("Podaj hasło: ");

            securePwd = new SecureString();
            ConsoleKeyInfo key;

            Console.Write("Enter password: ");
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
                Process.Start("Notepad.exe", "MyUser", securePwd, "MYDOMAIN");
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