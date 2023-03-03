using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Program
    {
        static Soba DnevnaSoba;
        static Soba Kuhinja;
        static Soba Jedilnica;
        static Zunanji Vrt;
        static Zunanji SprednjeDv;
        static Zunanji ZadnjeDv;
        static Lokacija TrenutnaPoz;
        static void Premaknise(Lokacija NovaLokacija)
        {
            TrenutnaPoz = NovaLokacija;
            Console.WriteLine(TrenutnaPoz.Opis());
        }
        static void Main(string[] args)
        {
            UstvariHiso();
            TrenutnaPoz = DnevnaSoba;
            Premaknise(DnevnaSoba);
            Console.WriteLine("Kam naj grem? K=Konec");
            string odg = Console.ReadLine();
            Lokacija nova = null;
            if (odg.ToUpper() == "K")
            {
                Console.WriteLine("Lep sprehod");
            }
            else
            {
                int n = int.Parse(odg);
                nova = new Lokacija(TrenutnaPoz.izhodi[n].ime);
                switch (nova.ime)
                {
                    case "Dnevna soba":
                        nova = DnevnaSoba;break;
                    case "Kuhinja":
                        nova = Kuhinja;break;
                    case "Jedilnica":
                        nova = Jedilnica;break;
                    case "Sprednje dvorišče":
                        nova = SprednjeDv;break;
                    case "Zadnje dvorišče":
                        nova = ZadnjeDv;break;
                    case "Vrt":
                        nova = Vrt;break;

                }
                Premaknise(nova);
            }
        }
        static void UstvariHiso()
        {
            DnevnaSoba = new Soba("Dnevna soba", " starinski tepih");
            Kuhinja = new Soba("Kuhinja", " srebrn pribor");
            Jedilnica = new Soba("Jedilnica", " lončen lonec");
            Vrt = new Zunanji("Vrt", false);
            SprednjeDv = new Zunanji("Sprednje dvorišče", true);
            ZadnjeDv = new Zunanji("Zadnje dvorišče", false);

            DnevnaSoba.izhodi = new Lokacija[2];
            DnevnaSoba.izhodi[0] = SprednjeDv;
            DnevnaSoba.izhodi[1] = Jedilnica;

            Kuhinja.izhodi = new Lokacija[2];
            Kuhinja.izhodi[0] = DnevnaSoba;
            Kuhinja.izhodi[1] = ZadnjeDv;

            Jedilnica.izhodi = new Lokacija[2];
            Jedilnica.izhodi[0] = DnevnaSoba;
            Jedilnica.izhodi[1] = Kuhinja;

            Vrt.izhodi = new Lokacija[2];
            Vrt.izhodi[0] = SprednjeDv;
            Vrt.izhodi[1] = ZadnjeDv;

            SprednjeDv.izhodi = new Lokacija[2];
            SprednjeDv.izhodi[0] = DnevnaSoba;
            SprednjeDv.izhodi[1] = Vrt;

            ZadnjeDv.izhodi = new Lokacija[2];
            ZadnjeDv.izhodi[0] = Vrt;
            ZadnjeDv.izhodi[1] = Kuhinja;

        }
    }
}
