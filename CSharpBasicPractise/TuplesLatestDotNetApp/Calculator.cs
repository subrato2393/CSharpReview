using System;
using System.Collections.Generic;
using System.Text;

namespace TuplesLatestDotNetApp
{
    public  class Calculator
    {

        //this Method return 4 values
        public  (int sum,int sub,int mul,double div) Math(int a,int b)
        {
            int summation = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            var result = (summation, subtraction, multiplication, division);
            return result;
        }
    }
}
