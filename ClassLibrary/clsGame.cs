using System;

namespace ClassLibrary
{
    public class clsGame
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public DateTime DatePublished { get; set; }
        public bool Active { get; set; }
    }
}