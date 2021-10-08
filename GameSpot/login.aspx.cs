using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace GameSpot
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s = "select nombre from usuario where email=? and password=?";
            String email = "", password = "";
            email = TextBox1.Text;
            password = TextBox2.Text;

            ConexionBD conABD = new ConexionBD();
            OdbcConnection conexion = conABD.con;
            OdbcCommand comando = new OdbcCommand(s, conexion);
            
            Console.WriteLine(email);
            Console.WriteLine(password);

            comando.Parameters.AddWithValue("email", email);
            comando.Parameters.AddWithValue("password", password);
            OdbcDataReader lector = comando.ExecuteReader();
            if(lector.HasRows == true)
            {
                lector.Read();
                String nombreUsuario;
                nombreUsuario= lector.GetString(0);
                lector.Close();
                Session.Add("nombreDelUsuario", nombreUsuario);
                Session.Timeout = 30; //Tenemos 30 min porque es de cr'iticas y no de bancos
                Response.Redirect("home.aspx");
            }
            else
            {
                Label3.Text = "Credenciales incorrectas, intentalo de nuevo";

                Session.Abandon();
            }



        }
    }
}