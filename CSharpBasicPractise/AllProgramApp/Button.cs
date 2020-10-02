using System;
using System.Collections.Generic;
using System.Text;

namespace AllProgramApp
{
    public class Button
    {
        public delegate void Activity();
        public event Activity activity;

    }
}
