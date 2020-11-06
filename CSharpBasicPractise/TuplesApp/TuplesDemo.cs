using System;
using System.Collections.Generic;
using System.Text;

namespace TuplesApp
{
    public class TuplesDemo 
    {
       public Tuple<int, int, double> Math(int a, int b)
        {
            int add = a + b;
            int multiply = a * b;
            double division = a / b;
            Tuple<int, int, double> t = Tuple.Create<int, int, double>(add, multiply, division);
            return t;
        }
    }
}
