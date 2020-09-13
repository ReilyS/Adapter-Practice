using System;

namespace Adapter_Practice
{
    class Program
    {
        static void Main()
        {
            Bear grizzly = new Grizzly();
            ToyBear teddy = new TeddyBear();
            ToyBear bearAdapt = new BearAdapter(grizzly);

            Console.WriteLine("Bear Functions:");
            grizzly.maul();
            grizzly.hibernate();
            Console.WriteLine();

            Console.WriteLine("ToyBear Functions with TeddyBear:");
            teddy.hug();
            Console.WriteLine();

            Console.WriteLine("ToyBear Functions with Grizzly:");
            bearAdapt.hug();
            Console.WriteLine();
        }
    }
}
