using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_Console
{
    public class Klasa
    {
        public String wychowawca;
        public String jaka_klasa;
        public List<Uczen> lista_uczniow = new List<Uczen>();
        public static Klasa[] lista_klas = new Klasa[9];
        public static int ile_klas { get; set; } = 0;


        public Klasa (String jaka_klasa, String wychowawca)
        {
            this.jaka_klasa = jaka_klasa;
            this.wychowawca = wychowawca;

            ile_klas++;
        }

        public Klasa(String jaka_klasa)
        {
            this.jaka_klasa = jaka_klasa;
        }


        public void WyswietlListe ()
        {
            foreach (var item in lista_uczniow)
            {
                Console.WriteLine(item.imie + " " + item.nazwisko);
            }
        }

    }
}

