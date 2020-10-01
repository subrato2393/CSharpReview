using System;

namespace EventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.ClickEvent += new Button.Activity(ClickTask);
            button.ClickEvent += new Button.Activity(ClickButton);
            //ClickTask(new Program());
            //ClickButton(new Program());
            button.Click(new Program());
            Console.ReadLine();
        }

        private static void ClickTask(object sender)
        {
            Console.WriteLine("Click Task Method Fired");
        }
        private static void ClickButton(object sender)
        {
            Console.WriteLine("Click Button Event Fired");
        }
    }
}
