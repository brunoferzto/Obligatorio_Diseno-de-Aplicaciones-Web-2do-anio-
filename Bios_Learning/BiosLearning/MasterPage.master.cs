using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas; 

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

            Empleado emplo = (Empleado)Session["Empleado"];

            if (emplo != null)
            {
                lnksesion.Visible = true;
                lblusuario.Text = emplo.Usuario.ToString();

            }

            else if (emplo == null)
            {
                Menu1.Visible = false;
            

        }

        

    }

    protected void lnksesion_Click(object sender, EventArgs e)
    {
        Session["Empleado"] = null;
        Response.Redirect("Default.aspx");
    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
