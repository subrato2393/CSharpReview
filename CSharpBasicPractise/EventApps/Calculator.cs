using System;
using System.Collections.Generic;
using System.Text;

namespace EventApps
{
    public class Calculator
    {
        public delegate void ButtonClick();
        public event ButtonClick buttonClick;
    }
}
