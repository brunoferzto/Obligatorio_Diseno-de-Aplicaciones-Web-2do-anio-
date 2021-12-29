using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using EntidadesCompartidas;

public partial class Consulta_de_Cursos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            try
            {
                
                Session["CursosList"] = FabricaLogica.getLogicaCursos().Listar();
                RTCurso.DataSource = (List<Cursos>)Session["CursosList"];
                RTCurso.DataBind();
               

                Session["SucursalList"] = FabricaLogica.getLogicaSucursal().Listar();
                DDLSucursal.DataSource = (List<Sucursales>)Session["SucursalList"];
                DDLSucursal.DataTextField = "Nombre";
                DDLSucursal.DataBind(); 
                    
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
    }

  

    protected void RTCurso_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "aIndividual") 
        {
            Session["CursoSel"] = FabricaLogica.getLogicaCursos().Buscar(Convert.ToString(((TextBox)(e.Item.Controls[1])).Text));
            Response.Redirect("~/Consulta Individual de Curso.aspx"); 
        }
    }

    protected void CargarDatos()
    {
        RTCurso.DataSource = (List<Cursos>)Session["Resultados"];
        RTCurso.DataBind();
    }

    protected void RBLtipo_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Session["Resultados"] = (from uncurso in (List<Cursos>)Session["CursosList"]
                                     where uncurso.TipoCurso.Trim() == RBLtipo.SelectedValue.ToString()
                                     select uncurso).ToList<Cursos>();

            CargarDatos();
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message; 
        }

       
    }

    protected void DDLSucursal_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (RBLtipo.SelectedIndex != -1)
            {
                Session["Resultados"] = (from uncurso in (List<Cursos>)Session["Resultados"]
                                         where uncurso.Local.Nombre == DDLSucursal.SelectedValue.ToString()
                                         select uncurso).ToList<Cursos>();

                CargarDatos();
            }
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message; 
        }

    }



    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        DDLSucursal.SelectedIndex = -1;
        RBLtipo.SelectedIndex = -1;
        RTCurso.DataSource = (List<Cursos>)Session["CursosList"];
        RTCurso.DataBind();
        txtfecha.Text = "";
        txtfechados.Text = "";
        lblerror.Text = "";
        txtfecha.Enabled = true;
        txtfechados.Enabled = true;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
     try
        { 
            

            if (RBLtipo.SelectedIndex != -1)
            {
                if (txtfecha.Text.Trim() != "" && txtfechados.Text.Trim() != "")
                {
                    DateTime fechaUNO = DateTime.MinValue;
                    DateTime fechaDos = DateTime.MaxValue;

                    if (Convert.ToDateTime(txtfecha.Text.Trim()) < Convert.ToDateTime(txtfechados.Text.Trim()))
                    {
                        fechaUNO = Convert.ToDateTime(txtfecha.Text.Trim());
                        fechaDos = Convert.ToDateTime(txtfechados.Text.Trim());
                    }

                    else if (Convert.ToDateTime(txtfecha.Text.Trim()) > Convert.ToDateTime(txtfechados.Text.Trim()))
                    {
                        fechaUNO = Convert.ToDateTime(txtfechados.Text.Trim());
                        fechaDos = Convert.ToDateTime(txtfecha.Text.Trim());

                    }

                    else
                    {
                        fechaUNO = Convert.ToDateTime(txtfecha.Text.Trim());
                        fechaDos = Convert.ToDateTime(txtfechados.Text.Trim());
                    }


                    Session["Resultados"] =
                          (from uncurso in (List<Cursos>)Session["Resultados"]
                           where uncurso.Fecha_Inicio >= fechaUNO && uncurso.Fecha_Inicio <= fechaDos
                           select uncurso).ToList<Cursos>();

                    CargarDatos();
                    txtfecha.Enabled = false;
                    txtfechados.Enabled = false; 


                }
                else
                    lblerror.Text = "Error, debe ingresar dos fechas";
            }
        }
        catch (Exception ex)
        {
            if (ex.Message == "")
            {
                lblerror.Text = "Error, en Fecha";
            }
            else
            lblerror.Text = ex.Message; 
        }
    }



    protected void txtfechados_TextChanged(object sender, EventArgs e)
    {

    }
}