using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSpot
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["nombreDelUsuario"] == null)
            {
                Session.Abandon();
                Response.Redirect("login.aspx");
            }
            Label1.Text = Label1.Text + Session["nombreDelUsuario"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
    }
}