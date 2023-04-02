using System.Collections.Concurrent;

namespace MorePripravaNaThready
{
    internal class Program
    {

        static Citac c = new Citac(100);
       static List<int> list = new List<int>();
        static object lockObj = new object();
        static ConcurrentBag<int> cisla = new ConcurrentBag<int>();
        static Random rand = new Random();
        static void Main(string[] args)
        {

            Thread zvysThread = new Thread(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    c.Zvys();
                }
            });

            Thread snizThread = new Thread(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    c.Sniz();
                }
            });

            zvysThread.Start();
            snizThread.Start();

            zvysThread.Join();
            snizThread.Join();

            Console.WriteLine($"Konečná hodnota čítače: {c.Hodnota}");

            Thread generujThread1 = new Thread(() =>
            {
                CislaToList();
            });

            Thread generujThread2 = new Thread(() =>
            {
                CislaToList();
            });


            generujThread1.Start();
            generujThread2.Start();

            generujThread1.Join();
            generujThread2.Join();

            if (list.Count == 2000000)
            {
                Console.WriteLine("Podařilo se vygenerovat 2 000 000 čísel do Listu.");
            }
            else
            {
                Console.WriteLine("Nepodařilo se vygenerovat dostatek čísel do Listu.");
            }


            Thread vlakno1 = new Thread(() => GenerujCisla());
            Thread vlakno2 = new Thread(() => GenerujCisla());

            vlakno1.Start();
            vlakno2.Start();

            vlakno1.Join();
            vlakno2.Join();

            if (cisla.Count == 2000000)
            {
                Console.WriteLine("Podařilo se vygenerovat 2 000 000 čísel do ConcurrentBag.");
            }
            else
            {
                Console.WriteLine("Nepodařilo se vygenerovat dostatek čísel do ConcurrentBag.");
            }

            Hrac h = new Hrac("Pepa", 100, true);

            Thread threadDemage = new Thread(() =>
            {
                for(int i =0; i< 10; i++)
                {
                    h.Sniz(rand.Next(5));
                }
            });

            Thread threadHeal = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    h.Zvys(rand.Next(5));
                }
            });

            threadDemage.Start();
            threadHeal.Start();

            threadDemage.Join();
            threadHeal.Join();

            if (h.IsAlive && h.Zdravi > 0)
            {
                Console.WriteLine(h);
            }

        }


        public static void CislaToList()
        {
            Random r = new Random();
            for(int i = 0; i < 1_000_000; i++)
            {
                lock (lockObj)
                {
                    list.Add(r.Next(20));
                }
            }

           


        }

        static void GenerujCisla()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                int cislo = rand.Next(1, 1001);
                cisla.Add(cislo);
            }
        }


    }
}