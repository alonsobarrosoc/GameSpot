using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Odbc;

namespace GameSpot
{
    public class ConexionBD
    {
        public OdbcConnection con { get; set; }
        public ConexionBD()
        {
            System.Configuration.Configuration webConfig;
            webConfig = System.Web.Configuration
                .WebConfigurationManager
                .OpenWebConfiguration("/GameSpot");
            System.Configuration.ConnectionStringSettings miStringDeConexion;
            miStringDeConexion = webConfig.ConnectionStrings
                .ConnectionStrings["BDGameSpot"];
            con = new OdbcConnection(miStringDeConexion.ToString());
            con.Open();
        }
    }
}