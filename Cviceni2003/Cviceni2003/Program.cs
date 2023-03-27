using System.Collections.Concurrent;

namespace Cviceni2003
{
    internal class Program
    {

        static Citac c = new Citac(0);
        static List<int> list = new List<int>();
        static ConcurrentBag<int> cb = new ConcurrentBag<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            

            Thread t1 = new Thread(Program.MiliZvys);
            Thread t2 = new Thread(Program.MiliSniz);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine(c);

            Thread t3 = new Thread(Program.MiliToList);
            Thread t4 = new Thread(Program.MiliToList);
            t3.Start();
            t4.Start();

            t3.Join();
            t4.Join();

            if(list.Count == 1_000_000)
            {
                Console.WriteLine("Je to tam :D");
            }
            else
            {
                Console.WriteLine("Neni to tam :(");
            }

            Thread t5 = new Thread(Program.MiliToCb);
            Thread t6 = new Thread(Program.MiliToCb);
            t5.Start();
            t6.Start();

            t5.Join();
            t6.Join();



        }

        public static void MiliZvys()
        {
            for(int i = 0; i < 1_000_000; i++)
            {
                c.Zvys();
            }
        }

        public static void MiliSniz()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                c.Sniz();
            }
        }

        public static void MiliToList()
        {
            Random random = new Random();
            
            for(int i = 0; i < 1_000_000; i++)
            {
                int rndCislo = random.Next(10);
                list.Add(rndCislo);
            }
        }

        public static void MiliToCb()
        {
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            List<Task> bagAddTasks = new List<Task>();
            for (int i = 0; i < 2_000_000; i++)
            {
                var numberToAdd = i;
                bagAddTasks.Add(Task.Run(() => cb.Add(numberToAdd)));
            }

            // Wait for all tasks to complete
            Task.WaitAll(bagAddTasks.ToArray());

            // Consume the items in the bag
            List<Task> bagConsumeTasks = new List<Task>();
            int itemsInBag = 0;
            while (!cb.IsEmpty)
            {
                bagConsumeTasks.Add(Task.Run(() =>
                {
                    int item;
                    if (cb.TryTake(out item))
                    {

                        Interlocked.Increment(ref itemsInBag);
                    }
                }));
            }
            Task.WaitAll(bagConsumeTasks.ToArray());

            Console.WriteLine($"There were {itemsInBag} items in the bag");

        }




    }
}