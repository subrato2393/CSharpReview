using System;

namespace EventApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.buttonClick += new Calculator.ButtonClick(ButtonClickEvent);
            calculator.buttonClick += new Calculator.ButtonClick(MouseHoverEvent);
            ButtonClickEvent();
            MouseHoverEvent();

            Console.ReadLine();
        }

        private static void MouseHoverEvent()
        {
            Console.WriteLine("Mouse Hover Event Fired");
        }

        private static void ButtonClickEvent()
        {
            Console.WriteLine("Button Click Event Fired");
        }
    }
}
