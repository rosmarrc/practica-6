using System;

namespace pract_6_eje_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseC obj = new ClaseC();
            Console.WriteLine(obj);

            Console.ReadKey();
        }
    }

    public class ClaseA
    {
        public ClaseA()
            { Console.WriteLine("soy el constructor de la clase A");
            }
    }
    class ClaseB:ClaseA
    {
        public ClaseB()
        {
            Console.WriteLine("soy el constructor de la clase B");
        }
    }

    class ClaseC:ClaseB
    {
        public ClaseC()
        {
            Console.WriteLine("soy el constructor de la clase C");
        }
    }
}
