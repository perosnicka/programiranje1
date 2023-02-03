
class Program
{

    static int Povp(int[] ocene)
    {
        int sum = 0;
        foreach (int ocena in ocene)
        {
            sum += ocena;
        }
        return sum / ocene.Length;
    }

    static int Min(int[] ocene)
    {
        int min = ocene[0];
        foreach (int ocena in ocene)
        {
            if (ocena < min)
            {
                min = ocena;
            }
        }
        return min;
    }

    static int Max(int[] ocene)
    {
        int max = ocene[0];
        foreach (int ocena in ocene)
        {
            if (ocena > max)
            {
                max = ocena;
            }
        }
        return max;
    }
    static void Main(string[] args)
    {
        int[] ocene = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Vnesite oceno: ");
            ocene[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Povprečna ocena: " + Povp(ocene));
        Console.WriteLine("Najnižja ocena: " + Min(ocene));
        Console.WriteLine("Najvišja ocena: " + Max(ocene));

    }
}



