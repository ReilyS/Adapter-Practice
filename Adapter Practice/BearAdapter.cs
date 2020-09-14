/*  Author: Reily Stanford
 *  Date: 09/12/2020
 *  File: BearAdapter.cs
 *  Description:
 *      This file is an adapter that inherits from the ToyBear 
 *      interface and implements the Bear's maul instead of hug.
 */

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
