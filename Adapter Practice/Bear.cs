/*  Author: Reily Stanford
 *  Date: 09/12/2020
 *  File: Bear.cs
 *  Description:
 *      This file is an interface holding a function that 
 *      will be overwritten later for maul and hibernate.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Practice
{
    interface Bear
    {
        public void maul();
        public void hibernate();
    }
}
