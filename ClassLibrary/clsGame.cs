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
        /*
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
        */
        public bool Find(int queryId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GameId", queryId);
            DB.Execute("sproc_tblGames_FilterByGameId");
            if(DB.Count == 1)
            {
                GameId = Convert.ToInt32(DB.DataTable.Rows[0]["GameID"]);
                GameTitle = Convert.ToString(DB.DataTable.Rows[0]["GameTitle"]);
                Price = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                Discount = Convert.ToInt32(DB.DataTable.Rows[0]["Discount"]);
                DatePublished = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePublished"]);
                Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            return false;
        }
    }
}