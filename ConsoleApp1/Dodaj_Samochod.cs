using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class add_car
    {
        string mark;
        string model;
        int yearproduction;
        double course;
        string nr_vin;
        string nr_registration;
        bool loan;
       private List<add_car> ListAddCar = new List<add_car>();


       public add_car()
       {
       }

       public add_car(string mark, string model, int yearproduction, double course, string nr_vin,
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

        public string Mark
        {
            get => mark;
            set => mark = value;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public int Yearproduction
        {
            get => yearproduction;
            set => yearproduction = value;
        }

        public double Course
        {
            get => course;
            set => course = value;
        }

        public string Nr_vin
        {
            get => nr_vin;
            set => nr_vin = value;
        }

        public string Nr_registration
        {
            get => nr_registration;
            set => nr_registration = value;
        }

        public bool Loan
        {
            get => loan;
            set => loan = value;
        }


         public void  AddCarList()
        {
            string mark;
            string model;
            int yearproduction = 0;
            double course = 0;
            string nr_vin;
            string nr_registration;
            bool loan = false;

            Console.WriteLine("Podaj markę samochodu");
            string MarkCars = Console.ReadLine();
            Console.WriteLine("Podaj model samochodu");
            string ModelCars = Console.ReadLine();
            Console.WriteLine("Wprowadź rok produkcji");

            int YearProductionCar;
            do
            {
                Console.WriteLine("Wprowadź rok produkcji samochodu");
            } while (!int.TryParse(Console.ReadLine(), out YearProductionCar));

            double CourseCar;
            do
            {
                Console.WriteLine("Wprowadź przebieg samochodu");
            } while (!double.TryParse(Console.ReadLine(), out CourseCar));

            Console.WriteLine("Podaj numer VIN samochodu");
            string NrVinCar = Console.ReadLine();
            Console.WriteLine("Podaj numer rejestracyjny samochodu");
            string NrRegistratiobCar = Console.ReadLine();


            add_car  AddCar1 = new add_car(MarkCars, ModelCars, YearProductionCar, CourseCar, NrVinCar,
                NrRegistratiobCar, loan);
           ListAddCar.Add(AddCar1);
            
        }
    }
}