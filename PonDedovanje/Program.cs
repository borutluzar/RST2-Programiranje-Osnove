using System;
using System.Collections.Generic;

namespace PonDedovanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor samsung = new Monitor(33, 1200);
            Monitor dell = new Monitor(24, 1200);
            Console.WriteLine($"Monitor {nameof(samsung)} ima diagonalo {samsung.Price}");

            Vehicle voz = new Vehicle(2, 20);
            Digger bager = new Digger(4, 185, true);
            Console.WriteLine(bager.ToString());
            Console.WriteLine($"Vozilo {nameof(bager)} ima maksimalno hitrost {bager.MaxSpeed}");

            Console.ReadLine();
        }
    }

    public class Vehicle
    {
        //public Vehicle() { }

        public Vehicle(int wheels, int maxSpeed)
        {
            this.Wheels = wheels;
            this.MaxSpeed = maxSpeed;
        }

        public int Wheels { get; set; }

        public int MaxSpeed { get; }

        public override string ToString()
        {
            return $"Vozilo: W={this.Wheels}, MS={this.MaxSpeed}";
        }
    }

    public class Digger : Vehicle
    {
        public Digger(int w, int m, bool drill) : base(w, m)
        {
            this.Drill = drill;
        }

        public bool Drill { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, D={(this.Drill ? "DA" : "NE")}";
        }
    }


    public class Monitor
    {
        public Monitor(double diag, double pr)
        {
            this.Diagonal = diag;
            this.Price = pr;
        }

        public double Diagonal { get; set; }

        public double Price { get; set; }
    }
}
