using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_Grupo_Nro_10
{
    public partial class frmEjercicio3A : System.Web.UI.Page
    {
        private void cargarTemas()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";
            
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Temas", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            ddlTemas.DataSource = dr;
            ddlTemas.DataTextField = "Tema";
            ddlTemas.DataValueField = "IdTema";

            ddlTemas.DataBind();

            cn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTemas();

            }
        }

        protected void lnkLibros_Click(object sender, EventArgs e)
        {
            string valorTema = ddlTemas.SelectedValue;

            Response.Redirect("frmEjercicio3B.aspx?Valor=" + valorTema);
        }

    }
}
