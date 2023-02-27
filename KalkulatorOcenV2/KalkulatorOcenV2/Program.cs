using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi oddelek Študenta 1-ang, 2-mat, 3-nar ");
            int oddelek = int.Parse(Console.ReadLine());
            switch (oddelek)
            {
                case 1:
                    //ang
                    StudentAng a = new StudentAng();
                    Console.WriteLine("Vnesi delni 1 ");
                    a.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2 ");
                    a.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi seminar ");
                    a.Seminar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi ustno ");
                    a.Ustna = int.Parse(Console.ReadLine());
                    Console.WriteLine(a.Izpis());
                    break;
                case 2:
                    //mat
                    StudentMath m = new StudentMath();
                    Console.WriteLine("Vnesi delni 1 ");
                    m.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2 ");
                    m.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(m.Izpis());
                    break;
                case 3:
                    //nar
                    StudentNar n = new StudentNar();
                    Console.WriteLine("Vnesi delni 1 ");
                    n.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2 ");
                    n.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi seminar ");
                    n.Seminar = int.Parse(Console.ReadLine());
                    Console.WriteLine(n.Izpis());
                    break;
            }
            Console.ReadLine();
        }
    }
}
