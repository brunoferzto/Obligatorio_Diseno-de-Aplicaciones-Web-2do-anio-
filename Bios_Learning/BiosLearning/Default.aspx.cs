using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica; 
public partial class Logueo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            Session["Empleado"] = null;
        
        
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try
        {
            Empleado emp = new Empleado(txtusu.Text.Trim(), txtpas.Text.Trim());
            IlogicaEmpleado iEmp = FabricaLogica.getLogicaEmpleado();

            if(iEmp.Logueo(emp) != null )
            { 
                Session["Empleado"] = emp;

                    Response.Redirect("AMBEmpleado.aspx");

            }
            else
                lblerror.Text = "No existe Empleado activo con los datos ingresados";

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message; 

        }
    }
}