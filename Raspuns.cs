using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithXMLs.MyClasses
{
    public class Raspuns
    {
        // acestea sunt proprietatiile clasei raspuns (atribute);
        public String Valoare;
        public Boolean Corect;

        //acestea sunt metodele clasei raspuns;

        public String CaString()
        {
            return " # Valoare = " + this.Valoare + " Corect = " + this.Corect;
        }
    }
}
