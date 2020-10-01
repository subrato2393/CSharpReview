using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateFuncApp
{
    public class DelegateClass
    {
        public delegate void DelegateMethod(int x, int y);
        public delegate int DelegateMethodWithReturnType(int x,int y);
    }
}
