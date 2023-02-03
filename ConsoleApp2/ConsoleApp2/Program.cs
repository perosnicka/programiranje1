class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[10];

        for(int i=0; i<10;i++)
        {
            Console.WriteLine("Vnesi " + (i + 1) + " stevilo: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = a[0];
        int max = a[0];

        
        foreach(int stevilo in a)
        {
            if (stevilo < min)
                min = stevilo;
            if (stevilo > max)
                max = stevilo;
        }
        Console.WriteLine("min: "+min);
        Console.WriteLine("max: "+max);


        Console.ReadLine();

        
    }
}