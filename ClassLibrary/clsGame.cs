using System;

namespace ClassLibrary
{
    public class clsGame
    {
        private int mGameId;
        private string mGameTitle;
        private double mPrice;
        private int mDiscount;
        private DateTime mDatePublished;
        private bool mActive;
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
        public string GameTitle { get => mGameTitle; set => mGameTitle = value; }
        public double Price { get => mPrice; set => mPrice = value; }
        public int Discount { get => mDiscount; set => mDiscount = value; }
        public DateTime DatePublished { get => mDatePublished; set => mDatePublished = value; }
        public bool Active { get => mActive; set => mActive = value; }

        public string Valid(string gameTitle,
                            string price,
                            string discount,
                            string datePublished)
        {
            string Error = "";
            // Validation for gameTitle
            if(gameTitle.Length < 1)
            {
                Error += "gameTitle is an empty string. ";
            }
            if(gameTitle.Length > 50)
            {
                Error += "gameTitle should be less than 50 characters. ";
            }
            // Validation for price
            try
            {
                double dblPrice = Convert.ToDouble(price);
                if(dblPrice < 0.0)
                {
                    Error += "price can not be negative. ";
                }
                if(dblPrice > 100.0)
                {
                    Error += "price should be less than 100. ";
                }
            }
            catch(FormatException e)
            {
                Error += "price should be a double. ";
            }
            // Validation for discount
            try
            {
                int intDiscount = Convert.ToInt32(discount);
                if(intDiscount < 0)
                {
                    Error += "discount can not be negative. ";
                }
                if(intDiscount > 100)
                {
                    Error += "discount should be less than 100. ";
                }
            }
            catch(FormatException e)
            {
                Error += "discount should be an int. ";
            }
            // Validation for datePublished
            try
            {
                DateTime datDatePublished = Convert.ToDateTime(datePublished);
                DateTime dat1990 = new DateTime(1990, 01, 01);
                if(datDatePublished < dat1990)
                {
                    Error += "datePublished should be no earlier than 1st Jan 1990. ";
                }
                if(datDatePublished > DateTime.Now.Date)
                {
                    Error += "datePublished can not be in the future. ";
                }
            }
            catch(FormatException e)
            {
                Error += "datePublished should be of type dateTime. ";
            }

            return Error;
        }
        public bool Find(int queryId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GameId", queryId);
            DB.Execute("sproc_tblGames_FilterByGameId");
            if(DB.Count == 1)
            {
                mGameId = Convert.ToInt32(DB.DataTable.Rows[0]["GameID"]);
                mGameTitle = Convert.ToString(DB.DataTable.Rows[0]["GameTitle"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mDiscount = Convert.ToInt32(DB.DataTable.Rows[0]["Discount"]);
                mDatePublished = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePublished"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            return false;
        }

        
    }
}