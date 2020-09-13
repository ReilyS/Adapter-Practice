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
