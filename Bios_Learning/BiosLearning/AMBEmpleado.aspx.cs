using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica; 
public partial class AMBEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            btnmodiciar.Enabled = false;
            
        }
        lblblerror.Text = "";
    }

    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        try
        {
            txtcontra.Enabled = true;
            Empleado emp = FabricaLogica.getLogicaEmpleado().Buscar(txtnomusu.Text);

            if (emp != null)
            {

                txtnomusu.Text = emp.Usuario;
                txtcontra.Text = emp.Contraseña.ToString();

                
                txtnomusu.Enabled = false;
                btnagregar.Enabled = false;
                btneliminar.Enabled = true;
                btnmodiciar.Enabled = true;
                Session["emlBuscado"] = emp;
                
            }
            else
            {
                btnagregar.Enabled = true;
         
            }
        }
        catch (Exception ex)
        {
            lblblerror.Text = ex.Message; 
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {

            Empleado empl = (Empleado)Session["emlBuscado"];
            if (empl != null)
            {
                empl.Contraseña = txtcontra.Text.Trim(); 
                FabricaLogica.getLogicaEmpleado().Modificar(empl);
                limpiar();
                lblblerror.Text = "Modificación Exitosa";
            }
            else
                lblblerror.Text = "No seleccionó ningun Empleado "; 


        }
        catch (Exception ex)
        {
            lblblerror.Text = ex.Message; 
        }

    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        try
        {
            Empleado emp = new Empleado(txtnomusu.Text.Trim(), txtcontra.Text.Trim());
            FabricaLogica.getLogicaEmpleado().Agregar(emp); 
            lblblerror.Text = "Se agregó correctamente"; 
        }
        catch (Exception ex)
        {
            lblblerror.Text = ex.Message; 
        }
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        try
        {
            Empleado empl = (Empleado)Session["emlBuscado"];
            if (empl != null)
            {
            
                FabricaLogica.getLogicaEmpleado().Eliminar(empl);
                lblblerror.Text = "Eliminación Correcta";
                limpiar(); 
            }
            else
                lblblerror.Text = "No seleccionó ningun Empleado ";


        }
        catch (Exception ex)
        {
            lblblerror.Text = ex.Message;
        }
    }

    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        limpiar(); 
        lblblerror.Text = "";
    }

    protected void limpiar ()
    {
        btnagregar.Enabled = false;
        btneliminar.Enabled = false;
        btnmodiciar.Enabled = false;
        txtnomusu.Text = "";
        txtcontra.Text = "";
        txtcontra.Enabled = false;
        txtnomusu.Enabled = true;
        Session["emlBuscado"] = null;
        
    }
}