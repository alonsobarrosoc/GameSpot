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
                DropDownList1.Items.Add("2");
                DropDownList1.Items.Add("3");
                DropDownList1.Items.Add("4");
                DropDownList1.Items.Add("5");
                DropDownList1.Items.Add("6");
                DropDownList1.Items.Add("7");
                DropDownList1.Items.Add("8");
                DropDownList1.Items.Add("9");
                DropDownList1.Items.Add("10");

            }
            if(DropDownList2.Items.Count == 0)
            {
                String query = "select claveJ, nombre from juego";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);
                OdbcDataReader lector = comando.ExecuteReader();
                DropDownList2.DataSource = lector;
                DropDownList2.DataValueField = "claveJ";
                DropDownList2.DataTextField = "nombre";
                DropDownList2.DataBind();
                lector.Close();
                conexion.Close();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String queryLlavePrimaria = "select max(claveC) + 1 from critica";
            String insertaCritica = "insert into critica values(?,?,CURRENT_TIMESTAMP, ?,?)";
            String insertaEscribe = "insert into escriben values(?,?,?)";

            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(queryLlavePrimaria, conexion);
            OdbcDataReader lector = comando.ExecuteReader();
            Int32 claveC;
            try
            {
                lector.Read();
                claveC = lector.GetInt32(0);
            } catch(Exception ex)
            {
                claveC = 1;
            }
            lector.Close();
            comando = new OdbcCommand(insertaCritica, conexion);
            comando.Parameters.AddWithValue("claveC", claveC);
            comando.Parameters.AddWithValue("titulo", TextBox1.Text.ToString());
            comando.Parameters.AddWithValue("contenido", TextBox2.Text.ToString());
            comando.Parameters.AddWithValue("calif", Int32.Parse(DropDownList1.SelectedValue));
            try
            {
                comando.ExecuteNonQuery();
                comando = new OdbcCommand(insertaEscribe, conexion);
                comando.Parameters.AddWithValue("claveU", Int32.Parse(Session["claveU"].ToString()));
                comando.Parameters.AddWithValue("claveJ", Int32.Parse(DropDownList2.SelectedValue.ToString()));
                comando.Parameters.AddWithValue("claveC", claveC);
                comando.ExecuteNonQuery();
                Label1.Text = "Crítica registrada correctamente";

            } catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            

        }
    }
}