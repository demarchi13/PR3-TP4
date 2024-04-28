using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_Grupo_Nro_10
{
    public partial class frmEjercicio2 : System.Web.UI.Page
    {
        //PUNTO 2
        private void CargarGrilla()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();

            SqlCommand cmd = new SqlCommand("Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            gvProductos.DataSource = dr;
            gvProductos.DataBind();

            cn.Close();
        }
        //PUNTO 3
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();

                ddlProducto.Items.Add(new ListItem("Igual a: ", "1"));
                ddlProducto.Items.Add(new ListItem("Mayor a: ", "2"));
                ddlProducto.Items.Add(new ListItem("Menor a: ", "3"));

                ddlCategoria.Items.Add(new ListItem("Igual a: ", "1"));
                ddlCategoria.Items.Add(new ListItem("Mayor a: ", "2"));
                ddlCategoria.Items.Add(new ListItem("Menor a: ", "3"));
            }
        }
        //PUNTO 4
        private void filtrarProductoIgual(int valor)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos where IdProducto=" + valor, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }
        //PUNTO 4
        private void filtrarProductoMayor(int valor)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos where IdProducto >" + valor, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }
        //PUNTO 5
        private void filtrarProductoMenor(int valor)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos where IdProducto <" + valor, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }
        //PUNTO 5
        private void filtrarCategoriaIgual(int valor)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos where IdCategoría=" + valor, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }
        //PUNTO 6
        private void filtrarCategoriaMayor(int valor)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos where IdCategoría>" + valor, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }
        //PUNTO 6
        private void filtrarCategoriaMenor(int valor)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos where IdCategoría<" + valor, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }
        //PUNTO 7
        private void filtrarProductoCategoria(int idProducto, int idCategoria)
        {
            int valorDDLProducto = Convert.ToInt32(ddlProducto.SelectedValue);
            string consulta = "Select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from Productos";

            string OperadorProducto = "";
            if (valorDDLProducto == 1)
            {
                OperadorProducto = "=";
            }
            else if (valorDDLProducto == 2)
            {
                OperadorProducto = ">";
            }
            else if (valorDDLProducto == 3)
            {
                OperadorProducto = "<";
            }

            int valorDDLCategoria = Convert.ToInt32(ddlCategoria.SelectedValue);
            string OperadorCategoria = "";
            if (valorDDLCategoria == 1)
            {
                OperadorCategoria = "=";
            }
            else if (valorDDLCategoria == 2)
            {
                OperadorCategoria = ">";
            }
            else if (valorDDLCategoria == 3)
            {
                OperadorCategoria = "<";
            }

            consulta += " Where idProducto" + OperadorProducto + idProducto + " AND idCategoría " + OperadorCategoria + idCategoria;
            //lblMensaje.Text = consulta;

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand(consulta, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            //PUNTO 8
            if (txtProducto.Text != "")
            {
                //string producto = txtProducto.Text.Trim();
                int idProducto = Convert.ToInt32(txtProducto.Text);

                switch (ddlProducto.SelectedValue)
                {
                    case "1":
                        filtrarProductoIgual(idProducto);
                        break;
                    case "2":
                        filtrarProductoMayor(idProducto);
                        break;
                    case "3":
                        filtrarProductoMenor(idProducto);
                        break;
                    default:
                        break;
                }
            }
            //PUNTO 9
            else if (txtCategoria.Text != "")
            {
                int idCategoria = Convert.ToInt32(txtCategoria.Text); //Guarda el id

                switch (ddlCategoria.SelectedValue)
                {
                    case "1":
                        filtrarCategoriaIgual(idCategoria);
                        break;
                    case "2":
                        filtrarCategoriaMayor(idCategoria);
                        break;
                    case "3":
                        filtrarCategoriaMenor(idCategoria);
                        break;
                    default:
                        break;
                }
            }
            //PUNTO 10
            else if (txtProducto.Text != "" && txtCategoria.Text != "")
            {
                int idProducto = Convert.ToInt32(txtProducto.Text); //Guarda el id
                int idCategoria = Convert.ToInt32(txtCategoria.Text); //Guarda el id             

                filtrarProductoCategoria(idProducto, idCategoria);
            }
            //PUNTO 11
            else
            {
                CargarGrilla();
            }
            txtCategoria.Text = "";
            txtProducto.Text = "";
        }
        //PUNTO 12
        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

       
    }

}
