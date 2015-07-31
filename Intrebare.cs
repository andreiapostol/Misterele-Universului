using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithXMLs.MyClasses
{
    public class Intrebare
    {
        public string Denumire;
        public List<Raspuns> Raspunsuri = new List<Raspuns>();

        public void AdaugaUnNouRaspunsLaIntrebare(Raspuns r)
        {
            this.Raspunsuri.Add(r);
        }

        private String DaMiRaspunsurileCaStringDetaliat()
        {
            string rezultat = "";
            foreach (Raspuns r in this.Raspunsuri)
                rezultat += r.CaString();
            return rezultat;
        }

        public String CaString()
        {
            return "[Denumire intrebare : " + this.Denumire + " Raspunsuri : {" + DaMiRaspunsurileCaStringDetaliat() + "}]";
        }
    }
}
