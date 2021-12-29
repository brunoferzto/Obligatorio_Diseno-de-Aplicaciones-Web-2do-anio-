using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas; 
public partial class Consulta_Individual_de_Curso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Cursos Cur = (Cursos)Session["CursoSel"];
            Composite1.CurSelec = Cur; 
        }
    }
}