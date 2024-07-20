using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Functional_Perspective
{
    //If a value return is needed, delegate Function can be used, it's always generic
    public class Function_Delegate
    {
        Func<int, int, int> add = Ops.Add;
        //or
        // Func<int, int, int> add = (a, b) => a + b;
    }
}
