public class Program {
    public static void Main(string[] args) {
        double [] meseci = new double[12];
        double vsota = 0;
        for (int i = 0; i <= meseci.Length; i++) {
            Console.WriteLine("Vnesi povprečno temperaturo za "+(i+1)+". mesec: ");
            meseci[i] = double.Parse(Console.ReadLine());
            vsota = vsota + vsota;
        }

        double povp = vsota / 12;
        Console.WriteLine("Povprečna temperatura: "+povp);
        Console.WriteLine("Mrzli meseci:");
        for(int i = 0; i < meseci.Length; i++){
            if (meseci[i] < povp)
                Console.WriteLine((i + 1) + ".mesec");
        }


    }
}
