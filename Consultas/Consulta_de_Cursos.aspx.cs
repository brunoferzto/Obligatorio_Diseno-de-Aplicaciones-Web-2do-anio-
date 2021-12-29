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
            Response.Redirect("~/Consulta Individual de Curso.aspx"); // si lo pongo en html nonono.
        }
    }

    protected void Linq () //order by fechsa
    {
        List<Cursos> resultadoI = (List<Cursos>)Session["CursosList"];

        if (RBLtipo.SelectedIndex != -1)

        {
            string tipo = RBLtipo.SelectedValue.ToString();
             resultadoI = (from uncurso in (List<Cursos>)Session["CursosList"]
                                       where uncurso.TipoCurso.Trim() == tipo
                                       select uncurso).ToList<Cursos>();       
        }


        if (DDLSucursal.SelectedIndex != -1)
        {
            string sucu = DDLSucursal.SelectedValue.ToString();

            List<Cursos> resultadosII = (from uncurso in (List<Cursos>)resultadoI
                                         where uncurso.Local.Nombre == sucu
                                         select uncurso).ToList<Cursos>();

            RTCurso.DataSource = resultadosII;
            RTCurso.DataBind();
        }



    }

    protected void RBLtipo_SelectedIndexChanged(object sender, EventArgs e)
    {
        Linq();
        //AUTOPOSTBACK HABIL
    }

    protected void DDLSucursal_SelectedIndexChanged(object sender, EventArgs e)
    {
        Linq(); //AUTOPOSTBACK HABIL
    }



    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        DDLSucursal.SelectedIndex = -1;
        RBLtipo.SelectedIndex = -1;

        Linq(); 
        
    }
}