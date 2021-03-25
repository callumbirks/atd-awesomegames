using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsGamesCollection
    {
        private List<clsGame> mGamesList = new List<clsGame>();
        private int mCount = new int();
        private clsGame mThisGame = new clsGame();
        public List<clsGame> GamesList { get => mGamesList; set => mGamesList = value; }
        public int Count { get => mGamesList.Count; }
        public clsGame ThisGame { get => mThisGame; set => mThisGame = value; }
        
        public clsGamesCollection()
        {
            GamesList = new List<clsGame>();
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblGames_SelectAll");
            RecordCount = DB.Count;
            for(int i = 0; i < RecordCount; i++)
            {
                clsGame aGame = new clsGame();
                aGame.GameId = Convert.ToInt32(DB.DataTable.Rows[i]["GameID"]);
                aGame.GameTitle = Convert.ToString(DB.DataTable.Rows[i]["GameTitle"]);
                aGame.Price = Convert.ToDouble(DB.DataTable.Rows[i]["Price"]);
                aGame.Discount = Convert.ToInt32(DB.DataTable.Rows[i]["Discount"]);
                aGame.DatePublished = Convert.ToDateTime(DB.DataTable.Rows[i]["DatePublished"]);
                aGame.Active = Convert.ToBoolean(DB.DataTable.Rows[i]["Active"]);
                GamesList.Add(aGame);
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GameTitle", mThisGame.GameTitle);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@Discount", mThisGame.Discount);
            DB.AddParameter("@DatePublished", mThisGame.DatePublished);
            DB.AddParameter("@Active", mThisGame.Active);
            return DB.Execute("sproc_tblGames_Insert");
        }
    }
}