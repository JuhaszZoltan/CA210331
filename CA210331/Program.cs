using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210331
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            //F04();
            //F05();
            //F07();
            //F08();
            //F09();
            //F10();
            //F1112();
            //F13();
            //F14();
            //F15();
            //F1617();
            //F18B();
            //F22();
            Console.ReadKey();
        }
        private static void F22()
        {
            string szoveg = "Alma a fa alatt"; //--> 7;
            int c = 1;
            for (int i = 1; i < szoveg.Length; i++)
            {
                if (!szoveg.Substring(0, i).Contains(szoveg[i])) c++;
            }
            Console.WriteLine($"kulombozo karakterek szama: {c}");           
        }
        private static void F18B()
        {
            string randomJelszo = "";
            for (int i = 0; i < 8; i++)
            {

                switch (rnd.Next(3))
                {
                    case 0: randomJelszo += (char)rnd.Next(97, 123);
                        break;
                    case 1: randomJelszo += (char)rnd.Next(65, 91);
                        break;
                    case 2: randomJelszo += rnd.Next(10);
                        break;
                }
            }
            Console.WriteLine(randomJelszo);
        }
        private static void F1617()
        {
            //string szoveg = "alma a fa alatt";
            //var ct = szoveg.ToCharArray();
            //Array.Sort(ct);
            //szoveg = new string(ct);
            //Console.WriteLine(szoveg);

            Console.Write("elso szo: ");
            string sz1 = Console.ReadLine();

            Console.Write("masodik szo: ");
            string sz2 = Console.ReadLine();

            var ct1 = sz1.ToCharArray();
            var ct2 = sz2.ToCharArray();

            Array.Sort(ct1);
            Array.Sort(ct2);

            sz1 = new string(ct1).Trim();
            sz2 = new string(ct2).Trim();

            if (sz1 == sz2) Console.WriteLine("anagramma");
            else Console.WriteLine("nem anagramma");

        }
        private static void F15()
        {
            string szoveg = "Alma a fa alatt";
            //string masikSzoveg = "";
            //for (int i = 0; i < szoveg.Length; i++)
            //{
            //    if (szoveg[i] != ' ') masikSzoveg += szoveg[i];
            //    else masikSzoveg += '\n';
            //}
            //Console.WriteLine(masikSzoveg);

            //var charTomb = szoveg.ToCharArray();
            //for (int i = 0; i < charTomb.Length; i++)
            //{
            //    if (charTomb[i] == ' ') charTomb[i] = '\n';
            //}
            //string masikSzoveg = new string(charTomb);
            //Console.WriteLine(masikSzoveg);
            szoveg = szoveg.Replace(' ', '\n');
            Console.WriteLine(szoveg);
        }
        private static void F14()
        {
            Console.Write("szo: ");
            string szo = Console.ReadLine();
            string ekezetes =     "áAéÉíÍóÓöÖőŐúÚüÜűŰ";
            string ekezetNelkul = "aAeÉiÍoOoOoOuUuUuU";
            string szoEkNelkul = "";
            for (int i = 0; i < szo.Length; i++)
            {
                if (!ekezetes.Contains(szo[i])) szoEkNelkul += szo[i];
                else szoEkNelkul += ekezetNelkul[ekezetes.IndexOf(szo[i])];
            }
            Console.WriteLine(szoEkNelkul);
        }
        private static void F13()
        {
            Console.Write("szo: ");
            string szo = Console.ReadLine().ToLower();
            string maganhangzok = "aáeéiíoóöőuúüű";
            int mghDB = 0;
            for (int i = 0; i < szo.Length; i++)
            {
                if (maganhangzok.Contains(szo[i])) mghDB++;
            }
            Console.WriteLine($"szóban a magánhangzók száma: {mghDB}");
        }
        private static void F1112()
        {
            Console.Write("szo: ");
            string szo = Console.ReadLine().ToLower();
            //int i = 0;
            //while (i < szo.Length && szo[i] != 'j' && szo[i] != 'J')
            //{
            //    i++;
            //}
            //if (i < szo.Length) Console.WriteLine("van benne j");
            //else Console.WriteLine("nincs benne j");

            if (szo.Contains('j')) Console.WriteLine("van benne j");
            else Console.WriteLine("nincs benne j");
            if (szo.Contains("ly")) Console.WriteLine("van benne ly");
            else Console.WriteLine("nincs benne ly");
        }
        private static void F10()
        {
            Console.Write("szoveg: ");
            var szoveg = Console.ReadLine();

            string kicsereltKezdobetu = 
                szoveg.Substring(0, 1).ToUpper() + 
                szoveg.Substring(1);

            Console.WriteLine(kicsereltKezdobetu);
        }
        private static void F09()
        {
            Console.Write("szöveg: ");
            var szoveg = Console.ReadLine();

            Console.WriteLine($"csupa nagybetűvel: {szoveg.ToUpper()}");
            Console.WriteLine($"csupa kisbetű: {szoveg.ToLower()}");

            Console.Write("másik szöveg: ");
            var megegyszer = Console.ReadLine().ToUpper();
            Console.WriteLine(megegyszer);
        }
        private static void F08()
        {
            Console.Write("mondat: ");
            var mondat = Console.ReadLine();

            if(mondat[mondat.Length - 1] == '!')
            {
                Console.WriteLine("felszólító");
            }
            else if (mondat[mondat.Length - 1] == '?') Console.WriteLine("kérdő");
        }
        private static void F07()
        {
            Console.Write("szoveg: ");
            var szoveg = Console.ReadLine();
            int szavakSzama = 0;
            szoveg = szoveg.Trim(',', ' ', '!');
            Console.WriteLine(szoveg);

            for (int i = 0; i < szoveg.Length - 1; i++)
            {
                if (szoveg[i] == ' ' && szoveg[i + 1] != ' ') szavakSzama++;
            }
            Console.WriteLine($"mszavak száma: {szavakSzama + 1}");
        }
        private static void F05()
        {
            Console.Write("szo: ");
            var szo = Console.ReadLine();

            for (int i = szo.Length - 1; i >= 0; i--)
            {
                Console.Write(szo[i]);
            }
        }
        private static void F04()
        {
            Console.Write("szo: ");
            var szo = Console.ReadLine();

            for (int i = 0; i < szo.Length + 2; i++)
                Console.Write('*');
            Console.Write("\n");
            Console.WriteLine($"*{szo}*");
            for (int i = 0; i < szo.Length + 2; i++)
                Console.Write('*');
            Console.Write("\n");
        }
        private static void F0123()
        {
            string szoveg = "alma a fa alatt";

            //Console.WriteLine(szoveg.Length);
            //Console.WriteLine(szoveg[0]);
            //Console.WriteLine("10");

            for (int i = 0; i < szoveg.Length; i++)
            {
                //Console.Write(szoveg[i] + " ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(szoveg[i]);
            }

            F0123();

        }
    }
}
