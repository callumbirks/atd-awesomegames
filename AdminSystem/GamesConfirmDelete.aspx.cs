using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Games_ConfirmDelete : System.Web.UI.Page
{
    private int GameId;

    protected void Page_Load(object sender, EventArgs e)
    {
        GameId = Convert.ToInt32(Session["GameId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsGamesCollection GamesList = new clsGamesCollection();
        GamesList.ThisGame.Find(GameId);
        GamesList.Delete();
        Response.Redirect("GamesList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("GamesList.aspx");
    }
}