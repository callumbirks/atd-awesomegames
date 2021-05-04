using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _GamesViewer : System.Web.UI.Page
{
    int GameId;

    protected void Page_Load(object sender, EventArgs e)
    {
        GameId = Convert.ToInt32(Session["GameId"]);
        if(IsPostBack == false)
        {
            if(GameId != -1)
            {
                DisplayGame();
            }
        }
    }

    private void DisplayGame()
    {
        clsGamesCollection GamesList = new clsGamesCollection();
        GamesList.ThisGame.Find(GameId);
        clsGame aGame = GamesList.ThisGame;
        txtGameId.Text = aGame.GameId.ToString();
        txtGameTitle.Text = aGame.GameTitle;
        txtPrice.Text = aGame.Price.ToString();
        txtDiscount.Text = aGame.Discount.ToString();
        calDatePublished.SelectedDate = aGame.DatePublished;
        calDatePublished.VisibleDate = aGame.DatePublished;
        chkActive.Checked = aGame.Active;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        String StrDatePublished = calDatePublished.SelectedDate.ToLongDateString();
        clsGame aGame = new clsGame();
        String Error = aGame.Valid(txtGameTitle.Text, txtPrice.Text, txtDiscount.Text, StrDatePublished);
        if(Error == "")
        {
            aGame.GameId = GameId;
            aGame.GameTitle = txtGameTitle.Text;
            aGame.Price = Convert.ToDouble(txtPrice.Text);
            aGame.Discount = Convert.ToInt32(txtDiscount.Text);
            aGame.DatePublished = calDatePublished.SelectedDate;
            aGame.Active = chkActive.Checked;
            clsGamesCollection GamesList = new clsGamesCollection();
            if(GameId == -1)
            {
                GamesList.ThisGame = aGame;
                GamesList.Add();
            }
            else
            {
                GamesList.ThisGame.Find(GameId);
                GamesList.ThisGame = aGame;
                GamesList.Update();
            }
            Response.Redirect("GamesList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}