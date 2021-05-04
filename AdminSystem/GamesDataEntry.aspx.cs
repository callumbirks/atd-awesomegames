using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Games_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsGamesCollection GamesList = new clsGamesCollection();
        clsGame aGame = new clsGame();
        string Error = aGame.Valid(txtGameTitle.Text, txtPrice.Text, txtDiscount.Text, calDatePublished.SelectedDate.ToLongDateString());
        if (Error == "")
        {
            aGame.GameTitle = txtGameTitle.Text;
            aGame.Price = Convert.ToDouble(txtPrice.Text);
            aGame.Discount = Convert.ToInt16(txtDiscount.Text);
            aGame.DatePublished = calDatePublished.SelectedDate;
            aGame.Active = chkActive.Checked;
            GamesList.ThisGame = aGame;
            GamesList.Add();
            Response.Redirect("GamesList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsGame aGame = new clsGame();
        Int32 GameID;
        Boolean Found = false;
        GameID = Convert.ToInt32(txtGameId.Text);
        Found = aGame.Find(GameID);
        if(Found == true)
        {
            lblError.Text = "";
            txtGameTitle.Text = aGame.GameTitle;
            txtPrice.Text = aGame.Price.ToString();
            txtDiscount.Text = aGame.Discount.ToString();
            calDatePublished.VisibleDate = aGame.DatePublished;
            calDatePublished.SelectedDate = aGame.DatePublished;
            chkActive.Checked = aGame.Active;
        }
        else
        {
            lblError.Text = "A record with that ID was not found";
        }
    }
}