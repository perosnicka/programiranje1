using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet
{
    internal class Ekipa
    {
        string ime;
        int StZmag;
        int StNeodlocenih;
        int DaniGoli;
        int PrejetiGoli;
        int StTekem;
        public Ekipa(string i)
        {
            ime = i;
            StTekem = 0;StZmag = 0;StNeodlocenih = 0;PrejetiGoli = 0;DaniGoli = 0;
        }
        public void VnesiRezultat(int d,int p)
        {
            StTekem++;
            if (d > p)
                StZmag++;
            else
                if (d == p)
                StNeodlocenih++;
            DaniGoli += d;
            PrejetiGoli += p;
        }
        public int StTock()
        {
            return 3 * StZmag + StNeodlocenih;
        }
        public int GolRazlika()
        {
            return DaniGoli - PrejetiGoli;
        }
        public void Izpis()
        {
            Console.WriteLine(ime+"\t"+StTock()+"\t"+GolRazlika()+"\t"+DaniGoli);
        }
        public bool BoljsaEkipa(Ekipa druga)
        {
            if (this.StTock() > druga.StTock())
                return true;
            if (this.StTock() == druga.StTock() && this.GolRazlika() > druga.GolRazlika())
                return true;
            if (this.StTock() == druga.StTock() && this.GolRazlika() == druga.GolRazlika() && this.DaniGoli > druga.DaniGoli)
                return true;
            return false;
        }


        public string Ime { get => ime; set => ime = value; }
        public int StZmag1 { get => StZmag; set => StZmag = value; }
        public int StNeodlocenih1 { get => StNeodlocenih; set => StNeodlocenih = value; }
        public int DaniGoli1 { get => DaniGoli; set => DaniGoli = value; }
        public int PrejetiGoli1 { get => PrejetiGoli; set => PrejetiGoli = value; }
        public int StTekem1 { get => StTekem; set => StTekem = value; }
    }
}
