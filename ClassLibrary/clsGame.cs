using System;

namespace ClassLibrary
{
    public class clsGame
    {
        private int mGameId { get; set; }
        public int GameId
        {
            get
            {
                return mGameId;
            }
            set
            {
                mGameId = value;
            }
        }
        public string GameTitle { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public DateTime DatePublished { get; set; }
        public bool Active { get; set; }

        public bool Find(int testId)
        {
            mGameId = 17;
            GameTitle = "Adventures of Bork";
            Price = 16.99;
            Discount = 10;
            DatePublished = new DateTime(2021, 02, 21);
            Active = true;
            return true;
        }
    }
}