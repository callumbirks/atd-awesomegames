using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _GamesViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsGame aGame = (clsGame)Session["aGame"];
        Response.Write(aGame.GameId);
        Response.Write(aGame.GameTitle);
        Response.Write(aGame.Price);
        Response.Write(aGame.Discount);
        Response.Write(aGame.DatePublished);
        Response.Write(aGame.Active);
    }
}