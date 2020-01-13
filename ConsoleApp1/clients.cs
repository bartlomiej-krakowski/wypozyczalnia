using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    [XmlRoot(" Client ")]
    public class clients : IEquatable<clients>
    {


        private string name;
        private string surname;
        private int PESEL;
        private string id_nr;
        private string address;

        public clients(string name, string surname, int PESEL, string id_nr, string address)
        {
            this.name = name;
            this.surname = surname;
            this.PESEL = PESEL;
            this.id_nr = id_nr;
            this.address = address;
        }

        public clients(int PESEL)
        {
            PESEL = PESEL;
        }

        public clients()
        {
        }

        [XmlAttribute(" Name ")]
        public string Name
        {
            get => name;
            set => name = value;
        }

        [XmlAttribute(" Surname ")]
        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        [XmlAttribute(" PESEL ")]
        public int Pesel
        {
            get => PESEL;
            set => PESEL = value;
        }

        [XmlAttribute(" id_nr ")]
        public string Id_nr
        {
            get => id_nr;
            set => id_nr = value;
        }

        [XmlAttribute(" address ")]
        public string Address
        {
            get => address;
            set => address = value;
        }

        public override string ToString()
        {
            return $"Imię: {name}, Nazwisko: {surname}, PESEL: {PESEL}, Numer dowodu: {id_nr}, Adres zameldowania: {address}";
        }


        public bool Equals(clients other)
        {

            if (this.PESEL == other.PESEL)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


    }
}
