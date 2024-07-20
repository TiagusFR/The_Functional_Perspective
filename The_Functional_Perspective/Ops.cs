using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Functional_Perspective
{
    //Function Basics
    public class Ops
    {
        //Meant to be called simply as Ops.Add() or Add() if 'static' instruction is imported.
        public static int Add(int a, int b)
        {
            return a + b; 
        }

        //Delegate definition
        public delegate int BinaryOperation(int a, int b);

        public void Execute()
        {
            BinaryOperation op = Ops.Add;
            int x = op(2, 3);
        }
    }
}
