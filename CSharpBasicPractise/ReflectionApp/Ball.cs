using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionApp
{
    public class Ball : IGameItem
    {
        public void PrintMe()
        {
            Console.WriteLine("I am a Ball");
        }
    }
}
