using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_Console
{
    public class Nauczyciel
    {
        public String imie;
        public String nazwisko;
        public String jaki_przedmiot;
        public Boolean czy_wychowawca;

        public Nauczyciel(String imie, String nazwisko, String jaki_przedmiot)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.jaki_przedmiot = jaki_przedmiot;
        }


    }
}
