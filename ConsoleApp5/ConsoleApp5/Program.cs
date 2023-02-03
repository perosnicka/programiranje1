using System;


class Program
{
    public class Nepremicnina
    {
        public string ulica;
        public int stevilka;
        public string vrsta;

        public Nepremicnina(string ulica, int stevilka, string vrsta)
        {
            this.ulica = ulica;
            this.stevilka = stevilka;
            this.vrsta = vrsta;
        }

    }

    static void Main(string[] args)
    {
        Nepremicnina n1 = new Nepremicnina("Cankarjeva",10,"šola");
        Console.WriteLine("Na naslovu " + n1.ulica + " " + n1.stevilka + " je " + n1.vrsta);

    }
}

