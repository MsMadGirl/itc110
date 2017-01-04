using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateEntree();
            PopulateDrinks();
        }//end if
        
    }//end pageload

    protected void PopulateEntree()
    {
        string[] entree = {"Hamburger", "Mac and Cheese", "Corn Dogs", "Spaghetti", "French Dip"};
        CBLEntree.DataSource = entree;
        CBLEntree.DataBind();

    }//end populateentree

    protected void Button1_Click(object sender, EventArgs e)
    {
        MealOrder meal = new MealOrder();
        foreach(ListItem item in CBLEntree.Items)
        {
            if (item.Selected)
            {
                meal.AddEntree(item.Text);

            }//end if
        }//end foreach

        foreach (ListItem item in CBLDrinks.Items)
        {
            if (item.Selected)
            {
                meal.AddDrink(item.Text);

            }//end if
        }//end foreach

        Session["Meal"] = meal;

        Response.Redirect("Default2.aspx");

    }//end button1click

    protected void PopulateDrinks()
    {
        string[] drinks = { "Soda", "Milkshake", "Coffee", "Tea", "Juice" };
        CBLDrinks.DataSource = drinks;
        CBLDrinks.DataBind();
    }
}