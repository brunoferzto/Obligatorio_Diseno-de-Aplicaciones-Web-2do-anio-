using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using EntidadesCompartidas; 
public partial class ABMSucursales : System.Web.UI.Page
{
    Sucursales sucuSel; 
    protected void Page_Load(object sender, EventArgs e)
    {
       
            
        if (!IsPostBack)
        {
            Session["SucuSel"] = null;
            Limpiar(); 
        }
        else
        {
            if (Session["SucuSel"] != null)
                sucuSel = (Sucursales)Session["SucuSel"];
            else
                sucuSel = null; 
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (sucuSel == null)
            {
                List<string> listilla = new List<string>();

                foreach (ListItem unLugar in lbfacilidad.Items)
                    listilla.Add(unLugar.Text.Trim());
                Sucursales sucu = new Sucursales(txtnombre.Text.Trim(), txtdire.Text.Trim(), listilla);
                FabricaLogica.getLogicaSucursal().Agregar(sucu);

                Limpiar();
                txtdire.Text = sucu.Direccion;                
                lblerror.Text = "Alta Correctamente";

            }
        }
        catch(Exception ex)
        {
            lblerror.Text = ex.Message; 
        }

            
    }

    protected void CargarSucursal()
    {
        txtnombre.Text = sucuSel.Nombre;
        txtnombre.Enabled = false; 
        txtdire.Text = sucuSel.Direccion;
        lbfacilidad.DataSource = sucuSel.Facilidad;
        lbfacilidad.DataBind();
        lbfacilidad.SelectedIndex = -1;
        lblerror.Text = "";
        txtnuevafacil.Enabled = true; 
        }
    protected void Limpiar()
    {
        txtnuevafacil.Enabled = false;
        btnborrartodo.Enabled = false;
        btneliminar.Enabled = false;
        btnregistra.Enabled = false;
        Button3.Enabled = false;
        btnnewsucu.Enabled = false;
        txtnombre.Enabled = true;
        txtnombre.Text = "";

        txtdire.Text = "";
        txtnuevafacil.Text = "";
        lbfacilidad.Items.Clear();   
        lbfacilidad.SelectedIndex = -1;
        lblerror.Text = "";
        sucuSel = null;
        Session["SucuSel"] = null;

    }

    protected void btnlimpia_Click(object sender, EventArgs e)
    {
        Limpiar(); 
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {

        if (lbfacilidad.SelectedIndex >= 0)
        {
            lbfacilidad.Items.RemoveAt(lbfacilidad.SelectedIndex);
            Button3.Enabled = true; // guardar cambios
            Button3.BackColor = System.Drawing.Color.Beige;

        }
        else
            lblerror.Text = "Debe Seleccionar un elemento";
    }

    protected void txtnuevafacil_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtnuevafacil.Text.Trim().Length > 0)
        {
            lbfacilidad.Items.Add(txtnuevafacil.Text.Trim());
            txtnuevafacil.Text = "";
            Button3.Enabled = true; // guardar cambios
            Button3.BackColor = System.Drawing.Color.Beige;
            
        }
        else
            lblerror.Text = "Ingrese la nueva facilidad";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {

            if (sucuSel != null)
            {


                sucuSel.Direccion = txtdire.Text;

                List<string> lista = new List<string>();
                sucuSel.Facilidad = lista;

                foreach (ListItem unLugar in lbfacilidad.Items)
                    sucuSel.Facilidad.Add(unLugar.Text.Trim());

                FabricaLogica.getLogicaSucursal().Modificar(sucuSel);
              
               
                lblerror.Text = "Modificacion Exitosa";
            }
            else
                lblerror.Text = "Seleccione una Sucursal";

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }

    protected void btnborrartodo_Click(object sender, EventArgs e)
    {
        if (sucuSel != null)
        {
            FabricaLogica.getLogicaSucursal().Eliminar(sucuSel);           
            Limpiar();
            txtnombre.Text = "";
            lblerror.Text = " Eliminación Exitosa";
        }
    }

    protected void lbfacilidad_SelectedIndexChanged(object sender, EventArgs e)
    {
            
    }

    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        
                    

        sucuSel = FabricaLogica.getLogicaSucursal().Buscar(txtnombre.Text);
        if (sucuSel != null)
        {
            Session["SucuSel"] = sucuSel;
            CargarSucursal();
            btneliminar.Enabled = true;
            btnborrartodo.Enabled = true;
            btnregistra.Enabled = true;


        }
        else
        {
         

            btnnewsucu.Enabled = true;
        }

    }

    protected void txtdire_TextChanged(object sender, EventArgs e)
    {

    }
}