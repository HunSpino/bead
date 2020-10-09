using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HarcosProjekt
{
    class Program
    {
        private static List<Harcos> harcosok = new List<Harcos>();
        public static void Beolvasas()
        {
            StreamReader r = new StreamReader("harcosok 1.csv");
            while (!r.EndOfStream)
            {
                string sor = r.ReadLine();
                string[] a = sor.Split(';');
                Harcos h = new Harcos(a[0], int.Parse(a[1]));
                harcosok.Add(h);

            }
            r.Close();
        }

        public static void Kiiratas()
        {


            for (int i = 0; i < harcosok.Count; i++)
            {
                Console.WriteLine(i + 1 + ".Játékos\n" + harcosok[i]);
            }
        }

        static void Main(string[] args)
        {
            Harcos h = new Harcos("Revan", 10);
            harcosok.Add(h);
            Beolvasas();
            Console.WriteLine("Adja meg a karakter nevét!: ");
            string ign = Console.ReadLine();
            Console.WriteLine("Kérem adja meg a karakter kasztját!: ");
            int kaszt = int.Parse(Console.ReadLine());

            Harcos N = new Harcos(ign, kaszt);



            Console.ReadKey();
        }
    }
}
