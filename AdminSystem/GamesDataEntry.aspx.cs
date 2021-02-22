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
        clsGame aGame = new clsGame();
        aGame.GameId = Convert.ToInt16(txtGameId.Text);
        aGame.GameTitle = txtGameTitle.Text;
        aGame.Price = Convert.ToDouble(txtPrice.Text);
        aGame.Discount = Convert.ToInt16(txtDiscount.Text);
        aGame.DatePublished = calDatePublished.SelectedDate;
        aGame.Active = chkActive.Checked;
        Session["aGame"] = aGame;
        Response.Redirect("GamesViewer.aspx");
    }
}