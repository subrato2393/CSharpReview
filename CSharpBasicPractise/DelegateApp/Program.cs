using System;

namespace DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var design = new PuzzalMaker.Design(PuzzalDesign);
            design(4, 9);
            var design2 = new PuzzalMaker.Design(new StrangeDesigner().StrangeDesign);
            design2(6, 90);
            Console.ReadLine();
        }
        static void PuzzalDesign(int x,int y)
        {
            Console.WriteLine($"Puzzal design static Method: {x}{y}");
        }
    }
    public class StrangeDesigner
    {
        public void StrangeDesign(int x,int y)
        {
            Console.WriteLine($"Strange design : {x}{y}");
        }
    }
}
