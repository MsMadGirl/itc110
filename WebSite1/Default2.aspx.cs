using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["Meal"]==null)
        {
            Response.Redirect("Default.aspx");
        }//end if

        DisplayReceipt();
    }//end page_load

    protected void DisplayReceipt()
    {
        StringBuilder sb = new StringBuilder();
        MealOrder meal = (MealOrder)Session["Meal"];
        List<string> entrees = meal.Entrees;
        List<string> drinks = meal.Drinks;

        foreach(string entree in entrees)
        {
            sb.Append(entree);
            sb.Append("<br/>");

        }//end foreach

        foreach(string drink in drinks)
        {
            sb.Append(drink);
            sb.Append("<br/>");

        }//end foreach

        sb.Append(meal.CalculateTotaL().ToString());
        Label1.Text = sb.ToString();
    }//end displayreceipt
}