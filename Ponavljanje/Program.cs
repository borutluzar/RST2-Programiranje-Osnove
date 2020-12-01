using System;

namespace Ponavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person();

            Person personB = new Person();
            personB.Age = 33;
            personB.Height = 192;

            Person personC = personB;

            //personA. = 21;
            personA.SetAge(31);
            
            Console.WriteLine($"Oseba je stara {personC.Age}");
        }
    }

    public class Person
    {
        public Person() { }

        public Person(int age)
        {
            this.age = age;
        }

        public Person(int age, double weigth)
        {
            this.age = age;
            this.weigth = weigth;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public bool NauciSeProgramirati()
        {
            return false;
        } 

        // Spremenljivka (polje), privzeta vrednost 88,
        // lahko ji hkrati spreminjamo vrednost in dostopamo do nje.
        // Ne moremo omogočiti samo enega ali drugega.
        public double weigth = 88;

        // Lastnost s privzeto vrednostjo 180.
        // Auto-implemented, pri get in set lahko
        // določimo možnosti dostopa za vsakega posebej.
        // npr. set samo protected.
        public double Height { get; set; } = 180;

        // Polna implementacija lastnosti,
        // če ni dodatnih preverjanj ali omejitev,
        // je koda kot spodaj in to lahko nadomestimo
        // kar z auto-implemented lastnostjo,
        // kjer se spremljajoči private field (age)
        // samodejno zgenerira v ozadju.
        private int age = 40;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}
