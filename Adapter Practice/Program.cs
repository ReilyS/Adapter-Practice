/*  Author: Reily Stanford
 *  Date: 09/12/2020
 *  File: Program.cs
 *  Description:
 *      This file creates a Bear object and two ToyBear objects with one being 
 *      made by an adapter. Every function of the objects are then called.
 */

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
