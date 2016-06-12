using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_Console
{
    public class Przedmiot
    {
        public String nazwa;
        public int []oceny = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int ile_ocen = 0;

       private enum skala_ocen
        {
            jedynka = 1,
            dwójka = 2,
            trójka = 3,
            czwórka = 4,
            piątka = 5,
            szostka = 6
        }

        public Przedmiot (String nazwa)
        {
            this.nazwa = nazwa;
        }


        public Przedmiot ()
        {

        }


        public void Dodaj_ocene ()
        {
            int x = 0;

            Console.WriteLine("Podaj ocenę do wpisania:");
            Console.WriteLine("1) Niedostateczny");
            Console.WriteLine("2) Dopuszczający");
            Console.WriteLine("2) Dopuszczają");
            Console.WriteLine("3) Dostateczny");
            Console.WriteLine("4) Dobry");
            Console.WriteLine("5) Bardzo Dobry");
            Console.WriteLine("6) Celujący");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Podałeś niewłaściwą wartość!");
            }

            switch(x)
            {
                case 1: this.oceny[ile_ocen] = (int)skala_ocen.jedynka; break;

                case 2: this.oceny[ile_ocen] = (int)skala_ocen.dwójka; break;

                case 3: this.oceny[ile_ocen] = (int)skala_ocen.trójka; break;

                case 4: this.oceny[ile_ocen] = (int)skala_ocen.czwórka; break;

                case 5: this.oceny[ile_ocen] = (int)skala_ocen.piątka; break;

                case 6: this.oceny[ile_ocen] = (int)skala_ocen.szostka; break;
            }
            this.ile_ocen++;
        }

        double Srednia(int suma_ocen)
        {
            return (suma_ocen / this.ile_ocen);
        }

    }
}
