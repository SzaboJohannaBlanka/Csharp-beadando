using System;
using System.Runtime.InteropServices;

namespace Beadandó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            feladat1(); Console.WriteLine("\n------------------------------");
            feladat2(); Console.WriteLine("\n------------------------------");
            feladat3(); Console.WriteLine("\n------------------------------");
            feladat4(); Console.WriteLine("\n------------------------------");
            feladat5(); Console.WriteLine("\n------------------------------");
            feladat6(); Console.WriteLine("\n------------------------------");
            feladat7(); Console.WriteLine("\n------------------------------");
            feladat8(); Console.WriteLine("\n------------------------------");
            feladat9(); Console.WriteLine("\n------------------------------");
            feladat10(); Console.WriteLine("\n------------------------------");
        }

        private static void feladat10()
        {
            Console.WriteLine("10.feladat: ");

            Console.Write("A tömeged(kg): ");
            int Suly = int.Parse(Console.ReadLine());

            Console.Write("A magasságod(cm): ");
            double Magassag = double.Parse(Console.ReadLine()) / 100;

            double TTI = Suly / (Magassag*Magassag);
            Console.Write($"A testtömegindexed: {TTI}\n");
        }

        private static void feladat9()
        {
            Console.Write("9.feladat: ");

            Console.Write("\nAz autó fogyasztása 100km-en(l): ");
            int Fogyasztas = int.Parse(Console.ReadLine());

            Console.Write("A benzin literenkénti ára: ");
            int Ar = int.Parse(Console.ReadLine());

            Console.Write("A megteendő út hossza: ");
            int Ut = int.Parse(Console.ReadLine());

            int Benzin = (Fogyasztas * Ut) / 100;
            int Utikoltseg = Ar * Benzin;

            Console.Write($"Az útiköltség: {Utikoltseg} ft\n");
        }

        private static void feladat8()
        {
            Console.Write("8.feladat: ");

            Console.Write("\nÍrja be a megtett út hosszát: ");
            int Ut = int.Parse(Console.ReadLine());

            Console.Write("Írja be az eltelt időt: ");
            int Ido = int.Parse(Console.ReadLine());

            int Sebesseg = Ut / Ido;
            Console.Write($"Az átlagsebesség: {Sebesseg}\n");
        }

        private static void feladat7()
        {
            Console.Write("7.feladat: ");

            Console.Write("\nA derékszögű 3szög egyik befogója: ");
            int Befogo1 = int.Parse(Console.ReadLine());

            Console.Write("A derékszögű 3szög másik befogója: ");
            int Befogo2 = int.Parse(Console.ReadLine());

            int Atfogo = Befogo1*Befogo1+Befogo2*Befogo2;
            Console.WriteLine($"A háromszög átfogójának hossza: {Atfogo} cm");
        }

        private static void feladat6()
        {
            Console.Write("6.feladat: ");

            Console.Write("\nA kör sugara(cm): ");
            int Sugar = int.Parse(Console.ReadLine());

            double Pi = Math.PI;

            var Kerulet = 2 * Sugar * Pi;
            var Terulet = Sugar * Sugar * Pi;

            Console.WriteLine($"A kör kerülete: {Kerulet}");
            Console.WriteLine($"A kör területe: {Terulet}\n");
        }

        private static void feladat5()
        {
            Console.WriteLine("5. feladat: ");

            Console.Write("A téglalap 'a' oldala: ");
            int AOldal = int.Parse(Console.ReadLine());

            Console.Write("A téglalap 'b' oldala: ");
            int BOldal = int.Parse(Console.ReadLine());

            int Terulet = AOldal * BOldal;
            int Kerulet = 2 * (AOldal + BOldal);

            Console.Write($"A téglalap területe: {Terulet}");
            Console.Write($"\nA téglalap kerülete: {Kerulet}\n");
        }

        private static void feladat4()
        {
            Console.WriteLine("4. feladat: ");

            Console.Write("\nAz euró árfolyama: ");
            int Euro = int.Parse(Console.ReadLine());

            Console.Write("Mennyi eurót szeretnél átváltani?: ");
            int Atvaltas = int.Parse(Console.ReadLine());

            int Eredmeny = Atvaltas * Euro;

            Console.WriteLine($"Az átváltott euró ennyi forint: {Eredmeny}");
        }

        private static void feladat3()
        {
            Console.WriteLine("3. feladat: ");

            Console.Write("\nA havi fizetés: ");
            int Fizetes = int.Parse(Console.ReadLine());
            int Eves = Fizetes * 11;

            Console.WriteLine($"Az éves fizetés: {Eves}");
        }

        private static void feladat2()
        {
            Console.WriteLine("2. feladat: ");

            Console.Write("\n1. vezetéknév: ");
            string Vezeteknev1 = Console.ReadLine();

            Console.Write("2. vezetéknév: ");
            string Vezeteknev2 = Console.ReadLine();

            Console.Write("1. keresztnév: ");
            string Keresztnev1 = Console.ReadLine();

            Console.Write("2. keresztnév: ");
            string Keresztnev2 = Console.ReadLine();

            Console.WriteLine("Az ebből képezhető nevek: ");

            Console.WriteLine($"{Keresztnev1} {Vezeteknev1}");
            Console.WriteLine($"{Keresztnev1} {Vezeteknev2}");
            Console.WriteLine($"{Keresztnev2} {Vezeteknev1}");
            Console.WriteLine($"{Keresztnev2} {Vezeteknev2}");

        }

        private static void feladat1()
        {
            Console.Write("1. feladat: ");

            Console.Write("\nKérek egy irányítószámot: ");
            int Iranyitoszam = int.Parse(Console.ReadLine());

            Console.Write("Kérek egy várost: ");
            string Varos = Console.ReadLine();

            Console.Write("Kérek egy közterület nevet: ");
            string Kozterulet = Console.ReadLine();

            Console.Write("Kérek egy közterület jelleget: ");
            string Jelleg = Console.ReadLine();

            Console.Write("Kérek egy házszámot: ");
            int Hazszam = int.Parse(Console.ReadLine());

            Console.Write($"\n{Iranyitoszam} {Varos} {Kozterulet} {Jelleg} {Hazszam}\n");
        }
    }
}
