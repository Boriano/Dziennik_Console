using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik_Console
{
    class Display
    { 

//-----------------Wypisywanie Ocen----------------------------------------------
        public static void OcenyMenu(Uczen ucz)
        {
            int wybrany_przedmiot;
            Console.WriteLine("Z jakiego przedmiotu chcesz zobaczyć oceny?");

            Console.Clear();
            Console.WriteLine("Wybierz przedmiot: ");

            for (int i = 0; i < Uczen.licznik_przedmiotow; i++)
            {
                Console.WriteLine(i + 1 + ") " + ucz.lista_przedmiotow[i].nazwa);
            }

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
                case 1:
                    {
                        wybrany_przedmiot = 0;
                        String przedmiot = "jezyk polski";
                        Display.WypiszOceny(wybrany_przedmiot, przedmiot);
                    }; break;

                case 2:
                    {
                        wybrany_przedmiot = 1;
                        String przedmiot = "matematyka";
                        Display.WypiszOceny(wybrany_przedmiot, przedmiot);
                    }; break;

                case 3:
                    {
                        wybrany_przedmiot = 2;
                        String przedmiot = "przyroda";
                        Display.WypiszOceny(wybrany_przedmiot, przedmiot);
                    }; break;

                case 4:
                    {
                        wybrany_przedmiot = 3;
                        String przedmiot = "jezyk angielski";
                        Display.WypiszOceny(wybrany_przedmiot, przedmiot);
                    }; break;

                case 5:
                    {
                        wybrany_przedmiot = 4;
                        String przedmiot = "historia";
                        Display.WypiszOceny(wybrany_przedmiot, przedmiot);
                    }; break;
            }
        }



        private static void WypiszOceny(int wybrany_przedmiot, String przedmiot)
        {
            int licznik = 0;
            Console.Clear();
            Console.WriteLine("Oceny z przedmotu " + przedmiot + "\n");

            for (int i = 0; i < 9; i++)
            {
               Console.WriteLine(Klasa.lista_klas[i].jaka_klasa);

                foreach (var uczen in Klasa.lista_klas[i].lista_uczniow)
                {
                    Console.Write(licznik + ") " + uczen.imie + " " + uczen.nazwisko + " ->");
                    Console.WriteLine(uczen.lista_przedmiotow[wybrany_przedmiot].oceny[0] + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[1]+ " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[2] + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[3] + " " + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[4] + " " + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[5] + " " + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[6] + " " + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[7] + " " + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[8] + " " + " " + uczen.lista_przedmiotow[wybrany_przedmiot].oceny[9]);
                    licznik++;
                }
                licznik = 1;
                Console.WriteLine("\n");
            }
            Console.WriteLine("Wartość 0 oznacza brak oceny.");
            Console.ReadKey();
        }
 

//------------------Wypisywanie ucznów/nauczycieli------------------------------
        public static void ListaUczniow_Nauczycieli_Menu(List<Nauczyciel> lista, List<Klasa> klasy)
        {
            int licznik = 1;

            Console.Clear();
            Console.WriteLine("Co chcesz sprawdzić? ");
            Console.WriteLine("1)Listę Nauczycieli ");
            Console.WriteLine("2)Listę Uczniów ");
            Console.WriteLine("3)Powrót ");

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
                case 1:
                    {
                        Console.Clear();
                        foreach (var nauczyciel in lista)
                        {
                            Console.WriteLine(licznik + ") " + nauczyciel.imie + " " + nauczyciel.nazwisko + "       Przedmiot: " + nauczyciel.jaki_przedmiot);
                            licznik++;
                        }
                        Console.ReadKey();
                    }; break;
                case 2:
                    {
                        Console.Clear();
                        foreach (var klasa in klasy)
                        {
                            Console.WriteLine(klasa.jaka_klasa);
                            foreach (var uczen in klasa.lista_uczniow)
                            {
                                Console.WriteLine(licznik + ") " + uczen.imie + " " + uczen.nazwisko);
                                licznik++;
                            }
                            Console.WriteLine("\n");
                            licznik = 1;
                        }
                        Console.ReadKey();
                    }; break;
                case 3: ; break;
            }
        }

//------------------Dodawanie do listy------------------------------------------

        public static void Dodawanie(List<Klasa> klasa, List<Nauczyciel> lista_nauczycieli)
        {
            Console.Clear();
            Console.WriteLine("1) Dodaj ucznia");
            Console.WriteLine("2) Dodaj nauczyciela");

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
                case 1: Display.Dodaj_Ucznia_Menu(klasa); break;
                case 2: Display.Dodawanie_Nauczyciela(lista_nauczycieli); break;
            }
        }



//-----------------Dodawanie nowego ucznia-------------------------------
        private static void Dodaj_Ucznia_Menu(List<Klasa> klasy)
        {
            String a;
            String b;
            String c;
            Boolean czy_dodano = false;
            long d;

            Console.Clear();

            Console.Write("Podaj Imie: ");
            a = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Podaj Nazwisko: ");
            b = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Podaj Pesel: ");
            d = Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("\n");

            Console.Write("Do jakiej klasy przydzielić nowego ucznia? ");
            Console.Write("\n");
            c = Console.ReadLine();

            Uczen nowy = new Uczen(c, b, a, d);

            for (int i = 0; i < 9; i++)
            {
                if (Klasa.lista_klas[i].jaka_klasa == c)
                {
                    Klasa.lista_klas[i].lista_uczniow.Add(nowy);
                    Console.WriteLine("Dodano nowego ucznia!");
                    czy_dodano = true;
                    Console.ReadKey();
                }
            }
            if(czy_dodano == false)
            {
                Console.WriteLine("Nie ma takiej klasy!");
                Console.ReadKey();
            }
        }

//------------------Dodawanie nauczyciela---------------------------------
        private static void Dodawanie_Nauczyciela (List<Nauczyciel> lista_nauczycieli)
        {
            String a;
            String b;
            String c;

            Console.Clear();

            Console.Write("Podaj Imie: ");
            a = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Podaj Nazwisko: ");
            b = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Czego naucza? ");
            Console.Write("\n");
            c = Console.ReadLine();

            lista_nauczycieli.Add(new Nauczyciel(a, b, c));
            Console.ReadKey();
        }



//------------------Dodawanie Oceny----------------------------
        public static void Dodaj_Ocene_Menu(Uczen ucz)
        {
            int wybrany_przedmiot;
            String wybor_nazwiska;
            Console.Clear();
            Console.WriteLine("Wybierz przedmiot: ");

            for (int i = 0; i < Uczen.licznik_przedmiotow; i++)
            {
               Console.WriteLine(i+1 + ") " + ucz.lista_przedmiotow[i].nazwa);
            }

            int choose = 1;
            try
            {
                choose = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nie podałeś liczby, spróbuj jeszcze raz!");
            }

            switch(choose)
            {
                case 1:
                    {
                        wybrany_przedmiot = 0;
                        Display.KomuOcene(out wybor_nazwiska);
                        Display.JakaOcena(wybor_nazwiska, wybrany_przedmiot);
                    };  break;

                case 2:
                    {
                        wybrany_przedmiot = 1;
                        Display.KomuOcene(out wybor_nazwiska);
                    }; break;

                case 3:
                    {
                        wybrany_przedmiot = 2;
                        Display.KomuOcene(out wybor_nazwiska);
                    }; break;

                case 4:
                    {
                        wybrany_przedmiot = 3;
                        Display.KomuOcene(out wybor_nazwiska);
                    }; break;

                case 5:
                    {
                        wybrany_przedmiot = 4;
                        Display.KomuOcene(out wybor_nazwiska);
                    }; break;
            }
        }


        private static void KomuOcene (out String nazwisko)
        {
            int licznik = 1;
            Console.Clear();
            Console.WriteLine("Wpisz nazwisko osoby, której wstaiwć ocene?");

            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine(Klasa.lista_klas[i].jaka_klasa);
                foreach (var uczen in Klasa.lista_klas[i].lista_uczniow)
                {
                    Console.WriteLine(licznik + ") " + uczen.imie + " " + uczen.nazwisko);
                    licznik++;
                }
                Console.WriteLine("\n");
                licznik = 1;
            }

            nazwisko = Console.ReadLine();
        }


        private static void JakaOcena (String nazwiskko, int jaki_przedmiot)
        {
            Boolean czy_jest = false;

            for (int i = 0; i < 9; i++)
            {
                Uczen[] tablica = new Uczen[Klasa.lista_klas[i].lista_uczniow.Count];
                tablica = Klasa.lista_klas[i].lista_uczniow.ToArray();
                for(int j = 0; j < tablica.Length; j++)
                {
                    if (tablica[j].nazwisko == nazwiskko)
                    {
                        tablica[j].lista_przedmiotow[jaki_przedmiot].Dodaj_ocene();
                        Klasa.lista_klas[i].lista_uczniow = tablica.ToList<Uczen>();
                        czy_jest = true;
                    }
                }
               
            }
            if(czy_jest == false)
            {
                Console.WriteLine("Nie ma takij osoby!");
                Console.ReadKey();
            }

        }

    }
}
