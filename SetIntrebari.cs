using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithXMLs.MyClasses
{
    public class SetIntrebari
    {
        public String DenumireSetIntrebari;
        public List<Intrebare> Intrebari = new List<Intrebare>();

        public void AdaugaIntrebare(Intrebare i)
        {
            this.Intrebari.Add(i);
        }

        public void RedenumesteSetIntrebari(String newName)
        {
            this.DenumireSetIntrebari = newName;
        }

        public void AfisarePeConsola()
        {
            Console.WriteLine("Afisare set intrebari:");
            Console.WriteLine(" Denumire set intrebari:" + this.DenumireSetIntrebari);
            foreach (Intrebare i in this.Intrebari)
                Console.WriteLine(" * : " + i.CaString());

            /*
            for (int i = 0; i <= this.Intrebari.Count - 1; i++)
                Console.WriteLine(this.Intrebari.ElementAt(i).ToString());
             */
        }
    }
}
