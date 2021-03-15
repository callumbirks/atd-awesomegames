using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Games_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayGames();
        }
    }

    void DisplayGames()
    {
        clsGamesCollection Games = new clsGamesCollection();
        lstGamesList.DataSource = Games.GamesList;
        lstGamesList.DataValueField = "GameId";
        lstGamesList.DataTextField = "GameTitle";
        lstGamesList.DataBind();
    }
}