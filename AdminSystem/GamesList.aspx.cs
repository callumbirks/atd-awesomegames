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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["GameId"] = -1;
        Response.Redirect("GamesDataEntry.aspx");
    }

    void DisplayGames()
    {
        clsGamesCollection Games = new clsGamesCollection();
        lstGamesList.DataSource = Games.GamesList;
        lstGamesList.DataValueField = "GameId";
        lstGamesList.DataTextField = "GameTitle";
        lstGamesList.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int GameId;
        Console.Write("Selected index: " + lstGamesList.SelectedIndex);
        if(lstGamesList.SelectedIndex != -1)
        {
            GameId = Convert.ToInt32(lstGamesList.SelectedValue);
            Session["GameId"] = GameId;
            Response.Redirect("GamesViewer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}