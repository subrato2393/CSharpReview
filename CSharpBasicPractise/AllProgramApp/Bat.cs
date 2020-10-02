using System;
using System.Collections.Generic;
using System.Text;

namespace AllProgramApp
{
    public class Bat
    {
        public delegate void BatDelegate(int height,int weight);
        public delegate int HeightDelegate(int x);
        public int Id { get; set; }
        public string BatName { get; set; }
        
        public Bat(int id,string batName)
        {
            this.Id = id;
            this.BatName = batName;
        }
        public void GetBatSize(int height,int weight)
        {
            int result = height * weight;
            Console.WriteLine("Result "+result);
        }
        public int GetHeights(int height)
        {
            return height;
        }
        public Bat()
        {

        }
    }
}
