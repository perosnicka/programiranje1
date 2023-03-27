abstract class Atlet
{
    protected int startnaStevilka;
    protected string priimek;
    protected string ime;
    protected string klub;

    public Atlet(int s, string p, string i, string k)
    {
        startnaStevilka = s;
        priimek = p;
        ime = i;
        klub = k;
    }

    public abstract void vnesiRezultat();

    protected void Izpis()
    {
        Console.WriteLine("Startna Stevilka " + startnaStevilka + "\nAtlet " + ime + " " + priimek + "\nIn klub " + klub + "\n");
    }
}

class Metalec : Atlet
{
    private string imeDiscipline;
    private double[] meti = new double[6];

    public Metalec(int s, string p, string i, string k, string id) : base(s, p, i, k)
    {
        imeDiscipline = id;
    }

    public override void vnesiRezultat()
    {
        Console.WriteLine("Vnesite rezultate metov:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Met " + (i + 1) + ": ");
            double met = Convert.ToDouble(Console.ReadLine());
            meti[i] = met;
        }
    }

    private double NajboljsiMet()
    {
        double najboljsi = 0;

        for (int i = 0; i < 6; i++)
        {
            if (meti[i] > najboljsi)
            {
                najboljsi = meti[i];
            }
        }

        return najboljsi;
    }

    public void Izpis()
    {
        base.Izpis();
        Console.WriteLine("Disciplina: " + imeDiscipline);
        Console.WriteLine("Meti:");

        for (int i = 0; i < 6; i++)
        {
            if (meti[i] == 0)
            {
                Console.WriteLine("Met " + (i + 1) + ": neveljaven met");
            }
            else
            {
                Console.WriteLine("Met " + (i + 1) + ": " + meti[i]);
            }
        }
    }

    public void IzpisNajboljsiMet()
    {
        Console.WriteLine("Najboljsi met: " + NajboljsiMet());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Metalec m = new Metalec(1, "Primož", "Kozmus", "Ilirija", "Met kladiva");

        m.vnesiRezultat();
        Console.WriteLine();
        m.Izpis();
        Console.WriteLine();
        m.IzpisNajboljsiMet();
    }
}
