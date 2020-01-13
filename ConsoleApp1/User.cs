using System;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    [XmlRoot("Login")]
    public class userLogin : IEquatable<userLogin>
    {
        public userLogin(string login, int permisson)
        {
            _login = login;
            _permisson = permisson;
        }

        public userLogin(string login)
        {
            _login = login;
        }

        public userLogin(int permisson)
        {
            _permisson = permisson;
        }

        public userLogin()
        {
        }

        private string _login;
        private int _permisson;


        [XmlAttribute("Login")]
        public string Login
        {
            get => _login;
            set => _login = value;
        }

        [XmlAttribute("Permisson")]
        public int Permisson
        {
            get => _permisson;

            set => _permisson = value;
        }


        public bool Equals(userLogin other)
        {
            if (this.Login == other.Login)
            {
                return true;
            }

            if (this.Login != other.Login)
            {
                return false;
            }


            if (this.Permisson == other.Permisson)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return $"Login: {_login} ,Permisson: {_permisson}";
        }
    }
}