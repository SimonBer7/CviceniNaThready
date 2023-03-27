using System.Diagnostics;

namespace Cviceni0603
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Program start");
            //...
            // zde bude kód programu
            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            //...
            Console.WriteLine("Program finish");
            

            Console.WriteLine("Program start");
            WriteNumbers();
            Console.WriteLine("Program finish");
            


            Console.WriteLine("Program start");
            //vytvořím vlákno a pošlu do něj metodu, která má ve vlákně běžet
            Thread thread = new Thread(new ThreadStart(Program.WriteNumbers));
            //spuštění vlákna
            thread.Start();
            Console.WriteLine("Program finish");

            //rozdil spociva ve vypisu, pomoci noveho threadu se vypise nejdriv Program start a Program finsih a az pote cisla
            
            ListNumbers l = new ListNumbers();
            for (int i = 0; i < 500000000; i++)
            {
                l.Add(i);
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            l.Max();
            l.Min();

            stopWatch.Stop();
            Console.WriteLine("Time: " + stopWatch.ElapsedMilliseconds + "ms");



            ListNumbers l2 = new ListNumbers();
            for (int i = 0; i < 500000000; i++)
            {
                l2.Add(i);
            }
            Thread thread1 = new Thread(new ThreadStart(l2.Max));
            Thread thread2 = new Thread(new ThreadStart(l2.Min));
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            stopWatch2.Stop();
            Console.WriteLine("Time: " + stopWatch2.ElapsedMilliseconds + "ms");
            */




            ListNumbers l = new ListNumbers();
            for (int i = 0; i < 100; i++)
            {
                l.Add(i);
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            l.Max();
            l.Min();

            stopWatch.Stop();
            Console.WriteLine("Time: " + stopWatch.ElapsedMilliseconds + "ms");


            ListNumbers l2 = new ListNumbers();
            for (int i = 0; i < 100; i++)
            {
                l2.Add(i);
            }
            Thread thread1 = new Thread(new ThreadStart(l2.Max));
            Thread thread2 = new Thread(new ThreadStart(l2.Min));
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            stopWatch2.Stop();
            Console.WriteLine("Time: " + stopWatch2.ElapsedMilliseconds + "ms");


        }


        public static void WriteNumbers()
        {
            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                
            }

        }
    }
}