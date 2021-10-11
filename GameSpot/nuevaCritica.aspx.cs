using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace GameSpot
{
    public partial class nuevaCritica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["nombreDelUsuario"] == null)
            {
                Session.Abandon();
                Response.Redirect("login.aspx");
            }
            if(DropDownList1.Items.Count == 0)
            {
                String queryJuegos = "select claveJ, nombre from juego";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(queryJuegos, conexion);
                OdbcDataReader lector = comando.ExecuteReader();
                DropDownList1.DataSource = lector;
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataValueField = "claveJ";
                DropDownList1.DataBind();
                conexion.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
    }
}