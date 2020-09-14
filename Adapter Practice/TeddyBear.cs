/*  Author: Reily Stanford
 *  Date: 09/12/2020
 *  File: TeddyBear.cs
 *  Description:
 *      This file is a class that inherits from the ToyBear 
 *      interface and implements the hug function.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Practice
{
    class TeddyBear : ToyBear
    {
        public void hug()
        {
            Console.WriteLine("Hugged the teddy bear.");
        }
    }
}
