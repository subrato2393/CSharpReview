using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodApp
{
    public static class Extensions
    {
        public static int Subtract(this Calculator calculator ,int x,int y)
        {
            return x - y;
        }
        public static void Print(this Calculator calculator)
        {
            Console.WriteLine("Print method call");
        }
    }
}
