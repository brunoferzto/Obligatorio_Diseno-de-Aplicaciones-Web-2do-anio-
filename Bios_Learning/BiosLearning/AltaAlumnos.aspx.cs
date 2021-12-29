using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica; 
public partial class AltaAlumnos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

        }
    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtcedula.Text != "" && txtnombre.Text != "" && txttele.Text != "")
            {
                Alumnos alu = new Alumnos(txtnombre.Text.Trim(), Convert.ToInt32(txtcedula.Text), Convert.ToInt32(txttele.Text));
                FabricaLogica.getLogicaAlumno().Agregar(alu);
                lblerror.Text = "Alta Correcta";
            }
            else
                lblerror.Text = "¡Debe Ingresar Datos!"; 
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
}