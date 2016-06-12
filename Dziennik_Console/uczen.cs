using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_Console
{
   public class Uczen : Klasa
    {
        public String imie;
        public String nazwisko;
        public long pesel { get; set; }
        public Przedmiot[] lista_przedmiotow = new Przedmiot[10];
        public static int licznik_przedmiotow { get; set; } = 5;

        private Przedmiot polski = new Przedmiot("język polski");
        private Przedmiot matematyka = new Przedmiot("matematyka");
        private Przedmiot przyroda = new Przedmiot("przyroda");
        private Przedmiot angielski = new Przedmiot("język angielski");
        private Przedmiot historia = new Przedmiot("historia");


        public Uczen(String jaka_klasa, String nazwisko, String imie, long pesel) : base(jaka_klasa)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;

            lista_przedmiotow[0] = this.polski;
            lista_przedmiotow[1] = this.matematyka;
            lista_przedmiotow[2] = this.przyroda;
            lista_przedmiotow[3] = this.angielski;
            lista_przedmiotow[4] = this.historia;
        }

        public Uczen (String jaka_klasa) : base(jaka_klasa)
        {

        }

        public void NowyPrzedmiot (Przedmiot nowy_przedmiot)
        {
            lista_przedmiotow[licznik_przedmiotow] = nowy_przedmiot;
            licznik_przedmiotow++;
        }




    }
}
