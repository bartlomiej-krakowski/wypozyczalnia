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
    [XmlRoot(" Rent ")]
    public class rents : IEquatable<rents>
    {
        private int PESEL;
        private string VIN;
        private DateTime date_start;
        private DateTime date_stop;
        private string id;

        public rents(string id, int PESEL, string VIN, DateTime date_start, DateTime date_stop)
        {
            this.id = id;
            this.PESEL = PESEL;
            this.VIN = VIN;
            this.date_start = date_start;
            this.date_stop = date_stop;
        }

        public rents(string id)
        {
            this.id = id;
        }

        public rents()
        {
        }

        [XmlAttribute(" ID ")]
        public string Id
        {
            get => Id;
            set => Id = value;
        }
        [XmlAttribute(" PESEL ")]
        public int Pesel
        {
            get => Pesel;
            set => Pesel = value;
        }
        [XmlAttribute(" VIN ")]
        public string Vin
        {
            get => Vin;
            set => Vin = value;
        }
        [XmlAttribute(" Date_start ")]
        public DateTime Date_start
        {
            get => Date_start;
            set => Date_start = value;
        }
        [XmlAttribute(" Date_stop ")]
        public DateTime Date_stop
        {
            get => Date_stop;
            set => Date_stop = value;
        }
        
        public override string ToString()
        {
            return $"ID: {id}, PESEL: {PESEL}, VIN: {VIN}, Data początkowa: {date_start}, Data końcowa: {date_stop}";
        }


        public bool Equals(rents other)
        {

            if (this.Id == other.Id)
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
