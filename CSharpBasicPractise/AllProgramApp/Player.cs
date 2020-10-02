using System;
using System.Collections.Generic;
using System.Text;

namespace AllProgramApp
{
    public class Player
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int field;
        public Player(int id,string playerName)
        {
            this.Id = id;
            this.PlayerName = playerName;
        }
        public void GetPlayerFullInfo(int id,string name,object obj)
        {
            string fullInfo = Id + "  " + PlayerName;
            Console.WriteLine("Full Info "+fullInfo);
        }
        public Player()
        {

        }
    }
}
