using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Practice
{
    class BearAdapter : ToyBear
    {
        Bear bear;

        public BearAdapter(Bear _bear)
        {
            bear = _bear;
        }

        public void hug()
        {
            bear.maul();
        }
    }
}
