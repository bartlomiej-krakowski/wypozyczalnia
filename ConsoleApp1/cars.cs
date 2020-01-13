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
    [XmlRoot(" Car ")]
    public class cars : IEquatable<cars>
    {
   

        private string mark;
       private string model;
       private int yearproduction;
       private double course;
       private string nr_vin;
        private string nr_registration;
        private bool loan;


        public cars(string mark, string model, int yearproduction, double course, string nr_vin,
            string nr_registration, bool loan)
        {
            this.mark = mark;
            this.model = model;
            this.yearproduction = yearproduction;
            this.course = course;
            this.nr_vin = nr_vin;
            this.nr_registration = nr_registration;
            this.loan = loan;
        }

        public cars(string nrVin)
        {
            nr_vin = nrVin;
        }

        public cars()
        {
        }
        [XmlAttribute(" Mark ")]
        public string Mark
        {
            get => mark;
            set => mark = value;
        }
        [XmlAttribute(" Model ")]
        public string Model
        {
            get => model;
            set => model = value;
        }
        [XmlAttribute(" Yearproduction ")]
        public int Yearproduction
        {
            get => yearproduction;
            set => yearproduction = value;
        }
        [XmlAttribute(" Course ")]
        public double Course
        {
            get => course;
            set => course = value;
        }
        [XmlAttribute(" Nr_vin ")]
        public string Nr_vin
        {
            get => nr_vin;
            set => nr_vin = value;
        }
        [XmlAttribute(" Nr_registration ")]
        public string Nr_registration
        {
            get => nr_registration;
            set => nr_registration = value;
        }
        [XmlAttribute(" Loan ")]
        public bool Loan
        {
            get => loan;
            set => loan = value;
        }
        public override string ToString()
        {
            return $"Mark: {mark}, Model: {model}, Rok Produkcji: {yearproduction}, Przebieg: {course}, VIN : {nr_vin}, Numer rejestracyjny: {nr_registration}, Dostepny: {loan}";
        }
        

        public bool Equals(cars other)
        {

            if (this.Nr_vin == other.Nr_vin)
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
