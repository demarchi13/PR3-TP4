using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_Grupo_Nro_10
{
    public partial class frmEjercicio3B : System.Web.UI.Page
    {
        //PUNTO 7
        private void cargarLibros(int valor)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";
            
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Libros WHERE IdTema=" + valor, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            gvLibros.DataSource = dr;
            gvLibros.DataBind();

            cn.Close();
        }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            //PUNTO 8
            string AuxValorTema = Request.QueryString["Valor"];
            int valorTema = Convert.ToInt32(AuxValorTema);

            //PUNTO 9
            cargarLibros(valorTema);
        }

        //PUNTO 10
        protected void lnkConsultarTema_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmEjercicio3A.aspx");
        }

       
    }
}
