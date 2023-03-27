namespace Cviceni2703
{
    internal class Program
    {

        static Hrac h = new Hrac("Pepik", 150, true);
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            Thread t1 = new Thread(StaticZvys);
            t1.Start();
            t1.Join();

            Thread t2 = new Thread(StaticSniz);
            t2.Start();
            t2.Join();
            */

            Evidence e = new Evidence();

            Console.WriteLine(e);











        }

        public static void StaticZvys()
        {
            for (int i = 0; i < 10; i++)
            {
                h.Zvys(random.Next(20));
                Console.WriteLine(h);
            }
        }

        public static void StaticSniz()
        {
            for (int i = 0; i < 10; i++)
            {
                h.Sniz(random.Next(20));
                Console.WriteLine(h);
            }
        }

    }
}