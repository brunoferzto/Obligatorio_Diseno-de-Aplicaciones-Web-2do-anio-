<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMcEspecializado.aspx.cs" Inherits="ABMcEspecializado" StyleSheetTheme="Tema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style2 {
            width: 210px;
        }
        .auto-style1 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 210px;
        }
        .auto-style4 {
            height: 9px;
        }
        .auto-style5 {
            height: 9px;
            width: 210px;
        }
        .auto-style6 {
            width: 260px;
        }
        .auto-style7 {
            height: 23px;
            width: 260px;
        }
        .auto-style8 {
            height: 9px;
            width: 260px;
        }
        .auto-style9 {
            width: 143px;
        }
        .auto-style10 {
            height: 23px;
            width: 143px;
        }
        .auto-style11 {
            height: 9px;
            width: 143px;
        }
        .auto-style12 {
            width: 135px;
        }
        .auto-style13 {
            height: 23px;
            width: 135px;
        }
        .auto-style14 {
            height: 9px;
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="lblerror" runat="server" Font-Italic="True" Font-Size="Large"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style3">
                <strong>Código</strong>:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtcodigo" runat="server" Width="54px"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:Button ID="btnlimpiar" runat="server" OnClick="btnlimpiar_Click" Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                &nbsp;</td>
            <td class="auto-style12">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
            </td>
            <td class="auto-style2">
                <strong>Nombre</strong>:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtnombre" runat="server" Width="222px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lblcosto" runat="server" Text="Costo"></asp:Label>
                :</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtcosto" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnmodifica" runat="server" Text="Modificar" OnClick="btnmodifica_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lblcupos" runat="server" Text="Cupos"></asp:Label>
                :</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtcupos" runat="server" Width="54px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2"><strong>Empleado</strong>:</td>
            <td class="auto-style6">
                &nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblempleado" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style14"></td>
            <td class="auto-style5"><strong>Duración</strong>:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtdura" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">
                <strong>
                <br />Seleccione Sucursal:<br /></strong></td>
            <td class="auto-style6">
                <asp:ListBox ID="lbsucu" runat="server" Height="91px" Width="258px"></asp:ListBox>
            </td>
            <td>
                <asp:Button ID="btnagregar" runat="server" OnClick="btnagregar_Click" Text="Agregar Curso" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">Ingrese la Fecha de Inicio:</td>
            <td class="auto-style6">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

