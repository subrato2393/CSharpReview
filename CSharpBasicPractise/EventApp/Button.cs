using System;
using System.Collections.Generic;
using System.Text;

namespace EventApp
{
    public class Button
    {
        public delegate void Activity(object sender);
        public event Activity ClickEvent;

        public void Click(object sender)
        {
            ClickEvent(sender);
        }
    }
}
