using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;



namespace CompositeControl
{
    public class Composite : WebControl, INamingContainer
    {

        private Panel _unpanel;

        private TextBox txt1; // nombre
        private TextBox txt2; // codigo
        private TextBox txt4; // costo
        private TextBox txt10; //fecha 
        private TextBox txt5; //fecha inicio
        private TextBox txt6; // atributo indp
        private TextBox txt9; //empleado (usuario)
        private TextBox txt7; //sucuname
        private TextBox txt8; //diresucu
        private ListBox _listbox;  // para facilidades

        //con una puedo hacer todas y esto esta bien?
        private Label lblname;
        private Label lblcodigo;
        private Label lblcosto;
        private Label lblfecha;
        private Label lblcupos;
        private Label lblaindep; 
        private Label lblempleado;
        private Label lblsucursal;
        private Label lbldire;
        private Label lblfacilidad; 

        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            _unpanel = new Panel();
            _unpanel.Controls.Add(new LiteralControl("<table>"));
            _unpanel.ForeColor = System.Drawing.Color.Coral;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));



            lblname = new Label();
            lblname.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblname);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt1 = new TextBox();
            txt1.Height = Unit.Pixel(15);
            txt1.Width = Unit.Pixel(200);
            txt1.ReadOnly = true;
            txt1.Font.Bold = true; 
            txt1.BackColor = System.Drawing.Color.SkyBlue; 
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt1);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
           


            lblcodigo = new Label();
            lblcodigo.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblcodigo);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt2 = new TextBox();
            txt2.Height = Unit.Pixel(15);
            txt2.Width = Unit.Pixel(200);
            txt2.Font.Bold = true;
            txt2.ReadOnly = true;
            txt2.BackColor = System.Drawing.Color.SkyBlue;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt2);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));



            lblfecha = new Label();
            lblfecha.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblfecha);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt10 = new TextBox();
            txt10.Height = Unit.Pixel(15);
            txt10.Width = Unit.Pixel(200);
            txt10.Font.Bold = true;
            txt10.ReadOnly = true;
            txt10.BackColor = System.Drawing.Color.SkyBlue;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt10);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));



            lblcosto = new Label();
            lblcosto.Font.Bold = true;           
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblcosto);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt4 = new TextBox();
            txt4.Height = Unit.Pixel(15);
            txt4.Width = Unit.Pixel(200);
            txt4.Font.Bold = true;
            txt4.BackColor = System.Drawing.Color.SkyBlue;
            txt4.ReadOnly = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt4);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));



            lblcupos = new Label();
            lblcupos.Font.Bold = true;          
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblcupos);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt5 = new TextBox();
            txt5.Height = Unit.Pixel(15);
            txt5.Width = Unit.Pixel(200);
            txt5.Font.Bold = true;
            txt5.BackColor = System.Drawing.Color.SkyBlue;
            txt5.ReadOnly = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt5);
            _unpanel.Controls.Add(new LiteralControl("<tr>")); 
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));



            lblaindep = new Label();
            lblaindep.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblaindep);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt7 = new TextBox();
            txt7.Height = Unit.Pixel(15);
            txt7.Width = Unit.Pixel(200);
            txt7.Font.Bold = true;
            txt7.BackColor = System.Drawing.Color.SkyBlue;
            txt7.ReadOnly = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt7);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));



            lblempleado = new Label();
            lblempleado.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblempleado);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt6 = new TextBox();
            txt6.Height = Unit.Pixel(15);
            txt6.Width = Unit.Pixel(200);
            txt6.Font.Bold = true;
            txt6.BackColor = System.Drawing.Color.SkyBlue;
            txt6.ReadOnly = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt6);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));

            

            lblsucursal = new Label();
            lblsucursal.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblsucursal);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt8 = new TextBox();
            txt8.Height = Unit.Pixel(15);
            txt8.Width = Unit.Pixel(200);
            txt8.Font.Bold = true;
            txt8.BackColor = System.Drawing.Color.DeepSkyBlue;
            txt8.ReadOnly = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt8);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));



            lbldire = new Label();
            lbldire.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lbldire);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));

            txt9 = new TextBox();
            txt9.Height = Unit.Pixel(15);
            txt9.Width = Unit.Pixel(200);
            txt9.Font.Bold = true;
            txt9.BackColor = System.Drawing.Color.DeepSkyBlue;
            txt9.ReadOnly = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(txt9);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            

             lblfacilidad = new Label();
            lblfacilidad.Font.Bold = true;
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(lblfacilidad);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
 
            _listbox = new ListBox();
            _listbox.Height = Unit.Pixel(90);
            _listbox.Width = Unit.Pixel(250);
            _listbox.BackColor = System.Drawing.Color.DeepSkyBlue; 
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(_listbox);
            _unpanel.Controls.Add(new LiteralControl("<tr>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));
            _unpanel.Controls.Add(new LiteralControl("<BR/>"));

            this.Controls.Add(_unpanel);
        }

        public Cursos CurSelec
        {
            set
            {

                this.EnsureChildControls();


                lblname.Text =  "Curso   ";
                lblcodigo.Text = "Codigo    : ";
                lblfecha.Text =  "Fecha     : ";
                lblcosto.Text =  "Precio    : ";
                lblcupos.Text =  "Cupos     : ";
                lblempleado.Text = "Empleado  : ";
                lblsucursal.Text = "        Sucursal : ".ToString();
                lbldire.Text = " Dirección   : ";
                lblfacilidad.Text = "Facilidades de Sucursal  : ";

                txt1.Text = value.Nombre;
                txt2.Text = value.Codigo;
                txt4.Text = value.Costo.ToString();
                txt5.Text = value.Cupos.ToString();
                txt6.Text = value.Empleados.Usuario;
                txt10.Text = value.Fecha_Inicio.ToShortDateString();             
                txt8.Text = value.Local.Nombre;
                txt9.Text = value.Local.Direccion;
                _listbox.DataSource = value.Local.Facilidad;
                _listbox.DataBind(); 

                 if (value is Cortos)
                {
                    lblaindep.Text = "Área :";
                    txt7.Text = ((Cortos)value).Area;
                }
                else
                {
                    lblaindep.Text = "Duración :";
                    txt7.Text = ((Especializados)value).Duracion.ToString(); 

                }

            }
        }


    }
}
