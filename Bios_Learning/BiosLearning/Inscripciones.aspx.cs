using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica; 
public partial class Inscripciones : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            
        }

    }

    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtcedula.Text != "" && txtcedula.Enabled == true)
            {
               Alumnos alu = FabricaLogica.getLogicaAlumno().Buscar(Convert.ToInt32(txtcedula.Text.Trim()));
                if (alu != null)
                {
                    Session["Alumno"] = alu;
                    txtcedula.Text = alu.Nombre.ToString();
                    txtcodigo.Enabled = true;
                    txtcedula.Enabled = false;

                }
                else
                    lblerror.Text = "No se encontró Alumno"; 

            }
            if (txtcodigo.Text != "" && Session["Curso"] == null)
            {
                Cursos cur = FabricaLogica.getLogicaCursos().Buscar(txtcodigo.Text.Trim());
                if (cur != null)
                {
                    Session["Curso"] = cur;
                    txtcodigo.Text = cur.Nombre.ToString();
                }
                else
                    lblerror.Text = "No se encontró Curso";

            }

            if (Session["Alumno"] != null && Session["Curso"] != null)
            {
                btninscribe.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message; 
        }
    }

    protected void btninscribe_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["Alumno"] != null && Session["Curso"] != null)
            {
                Inscripcion nuvInsc = new Inscripcion((Alumnos)Session["Alumno"], DateTime.Now, (Cursos)Session["Curso"]);
                FabricaLogica.getLogicaAlumno().Inscribir(nuvInsc);
                lblerror.Text = "La Inscripción se ha realizado con Exito";
            }
            else
                lblerror.Text = "Debe buscar un Alumno y un Curso";
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message; 
        }

    }

    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        txtcedula.Text = "";
        txtcedula.Enabled = true; 
        txtcodigo.Text = "";
        txtcodigo.Enabled = false;
        btninscribe.Enabled = false;
        Session["Alumno"] = null;
        Session["Curso"] = null;
        lblerror.Text = ""; 
        
    }

   
}