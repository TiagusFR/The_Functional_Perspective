using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Functional_Perspective
{
    public class Program2
    {    
        //It also can be a nested funcion 
        static void Main(string[] args)
        {
            int Multiply(int x, int y) => x * y;
            Ops.BinaryOperation op = Multiply;
            int x = op(10, 2); //20
        }

        //Or an anonymous delegate or a lambda function as well

        void Method()
        {
            Ops.BinaryOperation op = (a, b) => a / b;
            int x = op(10, 2); //5
        }
    }
}
