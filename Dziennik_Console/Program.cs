using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Klasa> klasy = new List<Klasa>();
            List<Nauczyciel> lista_nauczycieli = new List<Nauczyciel>();

            lista_nauczycieli.Add(new Nauczyciel("Magda", "Łapińska", "Matematyka"));
//-------------GENEROWANIE DANYCH POCZĄTKOWYCH---------------------
            Klasa IIB = new Klasa("IIb", "Gabriela Maryna");
            Uczen ub1 = new Uczen("IIB",  "Kowalski", "Andrian", 1353452);
            Uczen ub2 = new Uczen("IIB",  "Boryńska", "Katarzyna", 3534634);
            Uczen ub3 = new Uczen("IIB",  "Młynaczryk", "Mietek", 34611);
            Uczen ub4 = new Uczen("IIB",  "Babka", "Aniela", 1234654);
            IIB.lista_uczniow.Add(ub1);
            IIB.lista_uczniow.Add(ub2);
            IIB.lista_uczniow.Add(ub3);
            IIB.lista_uczniow.Add(ub4);


            Klasa IIIC = new Klasa("IIIc", "Krzysztof Nakonieczny");
            Uczen uc1 = new Uczen("IIIc",  "Matejko", "Gienek", 864234);
            Uczen uc2 = new Uczen("IIIc",  "Kajko", "Patrycja", 35794);
            Uczen uc3 = new Uczen("IIIc",  "Waryjska", "Elżbieta", 234279);
            Uczen uc4 = new Uczen("IIIc",  "Kowal", "Karol", 231896);
            Uczen uc5 = new Uczen("Ia", "Urban", "Filip", 3252345);

            IIIC.lista_uczniow.Add(uc1);
            IIIC.lista_uczniow.Add(uc2);
            IIIC.lista_uczniow.Add(uc3);
            IIIC.lista_uczniow.Add(uc4);

            Klasa IA = new Klasa("Ia", "Krzysztof Nakonieczny");
            IA.lista_uczniow.Add(uc5);

            Klasa IB = new Klasa("Ib", "Krzysztof Nakonieczny");
            Klasa IC = new Klasa("Ic", "Krzysztof Nakonieczny");

            Klasa IIA = new Klasa("IIa", "Krzysztof Nakonieczny");
            Klasa IIC = new Klasa("IIc", "Krzysztof Nakonieczny");

            Klasa IIIA = new Klasa("IIIa", "Krzysztof Nakonieczny");
            Klasa IIIB = new Klasa("IIIb", "Krzysztof Nakonieczny");

            klasy.Add(IA);
            klasy.Add(IB);
            klasy.Add(IC);
            klasy.Add(IIA);
            klasy.Add(IIB);
            klasy.Add(IIC);
            klasy.Add(IIIA);
            klasy.Add(IIIB);
            klasy.Add(IIIC);

            Klasa.lista_klas[0] = IA;
            Klasa.lista_klas[1] = IB;
            Klasa.lista_klas[2] = IC;
            Klasa.lista_klas[3] = IIA;
            Klasa.lista_klas[4] = IIB;
            Klasa.lista_klas[5] = IIC;
            Klasa.lista_klas[6] = IIIA;
            Klasa.lista_klas[7] = IIIB;
            Klasa.lista_klas[8] = IIIC;
            //-------------MENU GŁÓWNE-----------------------------------------------------
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Dziennik");
                Console.WriteLine("1) Oceny");
                Console.WriteLine("2) Lista uczniów i nauczycieli");
                Console.WriteLine("3) Dodaj Ocene");
                Console.WriteLine("4) Dodaj...");
                Console.WriteLine("5) Zakończ \n");
                Console.Write("=>");


                int choose = 1;
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Nie podałeś liczby, spróbuj jeszcze raz!");
                }

                switch (choose)
                {
                    case 1: Display.OcenyMenu(uc1); break;
                    case 2: Display.ListaUczniow_Nauczycieli_Menu(lista_nauczycieli, klasy); break;
                    case 3: Display.Dodaj_Ocene_Menu(uc1); break;
                    case 4: Display.Dodawanie(klasy, lista_nauczycieli); break;
                    case 5: System.Environment.Exit(0); break;

                    default: Console.WriteLine("Zły wybór! Spróbuj jeszcze raz!"); break;
                }
            }
        }
    }
}
