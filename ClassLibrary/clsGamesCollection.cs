using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsGamesCollection
    {
        public List<clsGame> GamesList { get; set; }
        public int Count {
            get
            {
                return GamesList.Count;
            }
            set
            {
                // unnecessary
            }
        }
        public clsGame ThisGame { get; set; }
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
    }
}