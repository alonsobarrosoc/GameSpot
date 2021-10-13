using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Odbc;

namespace GameSpot
{
    public partial class editarPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["nombreDelUsuario"] == null)
            {
                Session.Abandon();
                Response.Redirect("login.aspx");
            }
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("F");
                DropDownList1.Items.Add("M");

            }
            String query = "select * from usuario where claveU = ?";
            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);
            comando.Parameters.AddWithValue("claveU", Int32.Parse(Session["claveU"].ToString()));
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            TextBox1.Text = lector.GetString(1);
            TextBox2.Text = lector.GetString(3);
            DropDownList1.SelectedValue = lector.GetString(4);
            TextBox5.Text = lector.GetString(5);
            TextBox3.Text = lector.GetString(2);
            TextBox4.Text = lector.GetString(2);
            lector.Close();
            conexion.Close();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String query = "update usuario set email = ?, password = ?, nombre = ?, sexo = ?, edad =? where claveU = ?";
            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);
            
            if (TextBox3.Text.Equals(TextBox4.Text))
            {
                comando.Parameters.AddWithValue("email", TextBox1.Text);
                comando.Parameters.AddWithValue("password", TextBox3.Text);
                comando.Parameters.AddWithValue("nombre", TextBox2.Text);
                comando.Parameters.AddWithValue("sexo", DropDownList1.SelectedValue.ToString());
                comando.Parameters.AddWithValue("edad", Int32.Parse(TextBox5.Text));
                comando.Parameters.AddWithValue("claveU", Int32.Parse(Session["claveU"].ToString()));
                try
                {
                    comando.ExecuteNonQuery();
                    Label1.Text = "Los datos se actualizaron correctamente";
                } catch(Exception ex)
                {
                    Label1.Text = "Ocurrió un error";
                }
            }
            else
            {
                Label1.Text = "Las contraseñas no coinciden";
            }

        }
    }
}