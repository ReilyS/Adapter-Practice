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
