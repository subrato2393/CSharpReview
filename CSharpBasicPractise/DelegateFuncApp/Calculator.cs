using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateFuncApp
{
    public class Calculator
    {
        public void Addition(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Addition result is "+result);
        }
        public int Add(int x,int y)
        {
            int result = x + y;
            return result;
        }
    }
}
