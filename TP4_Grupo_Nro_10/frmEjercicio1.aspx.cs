using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace TP4_Grupo_Nro_10
{ 
    public partial class frmEjercicio1 : System.Web.UI.Page
    {
        //PUNTO 2
        private void CargarProvincias(DropDownList ddlProvincia)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";

            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT * FROM Provincias";
            comando.Connection = conexion;

            SqlDataReader lector = comando.ExecuteReader();

            ddlProvincia.DataSource = lector;
            ddlProvincia.DataTextField = "NombreProvincia";
            ddlProvincia.DataValueField = "IdProvincia";

            ddlProvincia.DataBind();

            conexion.Close();
        }
        
        //PUNTO 6
        private void CargarProvincias2(DropDownList ddlProvincia, int indiceDDL)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";

            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT * FROM Provincias WHERE IdProvincia !=" + indiceDDL;
            comando.Connection = conexion;

            SqlDataReader lector = comando.ExecuteReader();

            ddlProvincia.DataSource = lector;
            ddlProvincia.DataTextField = "NombreProvincia";
            ddlProvincia.DataValueField = "IdProvincia";

            ddlProvincia.DataBind();

            conexion.Close();
        }

        //PUNTO 5
        private void CargarLocalidadesInicio(DropDownList ddlLocalidades)
        {
            int idProvincia = Convert.ToInt32(ddlProvinciaInicio.SelectedValue);

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";

            conexion.Open();

            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SELECT * FROM Localidades WHERE IdProvincia=" + idProvincia;
            comando.Connection = conexion;
            SqlDataReader lector = comando.ExecuteReader();

            ddlLocalidades.DataTextField = "NombreLocalidad";
            ddlLocalidades.DataValueField = "IdLocalidad";
            ddlLocalidades.DataSource = lector;

            ddlLocalidades.DataBind(); ;

            conexion.Close();
        }

        //PUNTO 7
        private void CargarLocalidadesFinal(DropDownList ddlLocalidades, int valorIndice)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";

            conexion.Open();

            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SELECT * FROM Localidades WHERE IdProvincia=" + valorIndice;
            comando.Connection = conexion;
            SqlDataReader lector = comando.ExecuteReader();

            ddlLocalidades.DataTextField = "NombreLocalidad";
            ddlLocalidades.DataValueField = "IdLocalidad";
            ddlLocalidades.DataSource = lector;

            ddlLocalidades.DataBind(); ;

            conexion.Close();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //PUNTO 3 cargar provincias
                CargarProvincias(ddlProvinciaInicio);

                //PUNTO 4 Carga el valor inicial de los ddl
                ddlProvinciaInicio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
                ddlLocalidadInicio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
                ddlProvinciaFinal.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
                ddlLocalidadFinal.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }

        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //PUNTO 8
                //Carga las localidades segun la provincia seleccionada
                CargarLocalidadesInicio(ddlLocalidadInicio);
                ddlLocalidadInicio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));

                //Cargar las provincias destino final
                int indiceInicio = Convert.ToInt32(ddlProvinciaInicio.SelectedValue);
                CargarProvincias2(ddlProvinciaFinal, indiceInicio);
                ddlProvinciaFinal.Items.Insert(0, new ListItem("--Seleccionar--", "0"));

                //PUNTO9
                //Limpia ddlFinalLocalidades si no hay ninguna provincia final seleccionada
                int auxInicio = Convert.ToInt32(ddlProvinciaFinal.SelectedValue);
                int auxFinal = Convert.ToInt32(ddlLocalidadInicio.SelectedValue);
                if (ddlProvinciaFinal.SelectedItem.Text == "--Seleccionar--" || (auxInicio == auxFinal))
                {
                    ddlLocalidadFinal.ClearSelection();
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {    
            //PUNTO 10
            //Carga las localidades segun la provincia destino final seleccionada
            int indiceFinal = Convert.ToInt32(ddlProvinciaFinal.SelectedValue);
            CargarLocalidadesFinal(ddlLocalidadFinal, indiceFinal);
            ddlLocalidadFinal.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
        }
    }
}
