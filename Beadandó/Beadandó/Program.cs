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