using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Functional_Perspective
{

    //Action delegates returns void. Generic arguments relate to the types of arguments this function takes
    public class Action_Delegate
    {
        Action WriteAnything = () => Console.WriteLine("Anything");
        //or
        Action<string> printText = x => Console.WriteLine(x);
    }
}
