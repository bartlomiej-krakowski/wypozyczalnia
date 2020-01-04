using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalnia_logowanie
{
    class logowanie
    {
        private int login;
        private int password;

        public logowanie(int login, int password)
        {
            this.login = login;
            this.password = password;
        }

        public int Login
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

        public int Password
        {
            get
            {
                return password;
            }

            set
            {
                if (value != null)
                {
                    password = value;
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

            Console.WriteLine("Podaj hasło: ");
            


        }
    }
}
