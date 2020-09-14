/*  Author: Reily Stanford
 *  Date: 09/12/2020
 *  File: Grizzly.cs
 *  Description:
 *      This file is a class that inherits from the Bear interface 
 *      and implements the maul and hibernate functions.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Practice
{
    class Grizzly : Bear
    {
        public void hibernate()
        {
            Console.WriteLine("Grizzly entered hibernation.");
        }

        public void maul()
        {
            Console.WriteLine("Grizzly mauled something.");
        }
    }
}
