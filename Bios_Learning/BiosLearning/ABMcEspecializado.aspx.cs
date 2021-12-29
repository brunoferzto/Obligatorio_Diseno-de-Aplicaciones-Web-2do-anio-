using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica; 
public partial class ABMcEspecializado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Sucursales> lista = FabricaLogica.getLogicaSucursal().Listar();
            Session["Sucursales"] = lista;
            lbsucu.DataSource = lista;
            lbsucu.DataTextField = "Nombre";
            lbsucu.DataBind();
            DesactivoBotones(); 
        }

    }

    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        Limpiar(); 
    }

    protected void DesactivoBotones()
    {
        btnmodifica.Enabled = false;
        btneliminar.Enabled = false;
        btnagregar.Enabled = false;
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        try
        {
            Especializados cort = (Especializados)Session["CurEBuscado"];
            FabricaLogica.getLogicaCursos().Eliminar(cort);
            Limpiar();
            lblerror.Text = " Eliminación Exitosa ";
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }

    protected void btnmodifica_Click(object sender, EventArgs e)
    {
        try
        {
            List<Sucursales> lista = (List<Sucursales>)Session["Sucursales"];

            Especializados C = (Especializados)Session["CurEBuscado"];
            C.Empleados = (Empleado)Session["Empleado"];
            C.Nombre = txtnombre.Text.Trim();
            C.Costo = Convert.ToInt32(txtcosto.Text);
            C.Cupos = Convert.ToInt32(txtcupos.Text);
            C.Fecha_Inicio = Calendar1.SelectedDate;
            C.Duracion = Convert.ToInt32(txtdura.Text);
            C.Local = lista[lbsucu.SelectedIndex];
            

            FabricaLogica.getLogicaCursos().Modificar(C);
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {

        try
        {
            List<Sucursales> lista = (List<Sucursales>)Session["Sucursales"];

            if (lbsucu.SelectedIndex != -1 && Calendar1.SelectedDate != DateTime.MinValue)
            {
                Sucursales sucursal = lista[lbsucu.SelectedIndex];

                Especializados cespe = new Especializados(Convert.ToInt32(txtdura.Text),
                   txtnombre.Text, txtcodigo.Text, Convert.ToInt32(txtcosto.Text),
                   Convert.ToInt32(txtcupos.Text), Calendar1.SelectedDate, sucursal,
                   (Empleado)Session["Empleado"]);

                FabricaLogica.getLogicaCursos().Agregar(cespe);

                Limpiar();
                lblerror.Text = "Se agregó el Curso correctamente";
                
            }
            else
                lblerror.Text = "Todos los campos son obligatoros";

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        { 
        Cursos cor = FabricaLogica.getLogicaCursos().Buscar(txtcodigo.Text);
            if (cor is Especializados)
            {
                txtnombre.Text = cor.Nombre;
                txtcodigo.Text = cor.Codigo;
                txtcosto.Text = cor.Costo.ToString();
                txtcupos.Text = cor.Cupos.ToString();
                lbsucu.SelectedValue = cor.Local.Nombre;
                lblempleado.Text = cor.Empleados.Usuario;

                txtdura.Text = ((Especializados)cor).Duracion.ToString();
                       
                Calendar1.SelectedDate = cor.Fecha_Inicio;

                Session["CurEBuscado"] = cor;

                btneliminar.Enabled = true;
                btnmodifica.Enabled = true;
                txtcodigo.Enabled = false;
            }
            else
                btnagregar.Enabled = true;

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }

    protected void Limpiar()
    {
        lblerror.Text = "";
        txtnombre.Text = "";
        txtcodigo.Text = "";
        txtcodigo.Enabled = true;
        txtcosto.Text = "";
        txtcupos.Text = "";
        lblempleado.Text = ""; 
        txtdura.Text = ""; 
        lbsucu.SelectedIndex = -1;
        Calendar1.SelectedDate = DateTime.Now;
        DesactivoBotones();
        Session["CurEBuscado"] = null;

    }
}