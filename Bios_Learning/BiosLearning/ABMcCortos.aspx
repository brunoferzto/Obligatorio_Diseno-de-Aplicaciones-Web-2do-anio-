<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMcCortos.aspx.cs" Inherits="ABMcCortos" StyleSheetTheme="Tema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            width: 139px;
        }
        .auto-style3 {
            height: 20px;
            width: 139px;
        }
        .auto-style4 {
            height: 87px;
        }
        .auto-style5 {
            width: 139px;
            height: 87px;
        }
        .auto-style6 {
            width: 247px;
        }
        .auto-style7 {
            height: 20px;
            width: 247px;
        }
        .auto-style8 {
            height: 87px;
            width: 247px;
        }
        .auto-style9 {
            width: 131px;
        }
        .auto-style10 {
            height: 20px;
            width: 131px;
        }
        .auto-style11 {
            height: 87px;
            width: 131px;
        }
        .auto-style12 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style13 {
            width: 139px;
            font-weight: bold;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="lblerror" runat="server" Font-Italic="True" Font-Size="Large"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10"></td>
            <td class="auto-style3">
                <asp:Label ID="lblcodigo" runat="server" Text="Código"></asp:Label>
                :</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtcodigo" runat="server" Width="53px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="auto-style1">
                <asp:Button ID="btnlimpiar" runat="server" OnClick="btnlimpiar_Click" Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                </td>
            <td class="auto-style9">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" Height="26px" />
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
                :</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtnombre" runat="server" Width="222px"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp; &nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lblcosto" runat="server" Text="Costo"></asp:Label>
                :</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtcosto" runat="server" Width="223px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnmodifica" runat="server" Text="Modificar" OnClick="btnmodifica_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lblcupos" runat="server" Text="Cupos"></asp:Label>
                :</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtcupos" runat="server" Width="53px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Empleado:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Label ID="lblempleado" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style5">
                <span class="auto-style12">Seleccione Sucursal:</span><br />
                <br />
            </td>
            <td class="auto-style8">
                <asp:ListBox ID="lbsucu" runat="server" Height="91px" Width="252px" OnSelectedIndexChanged="lbsucu_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style13">Ingrese la Fecha :</td>
            <td class="auto-style6">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Width="200px">
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
            <td>
                <asp:Button ID="btnagregar" runat="server" OnClick="btnagregar_Click" Text="Agregar Curso" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                <asp:RadioButtonList ID="rdlarea" runat="server" OnSelectedIndexChanged="rdlarea_SelectedIndexChanged" BorderStyle="Inset" Font-Bold="True" Font-Italic="False" Font-Names="Century Gothic" Font-Size="Small" ForeColor="#660033">
                    <asp:ListItem>Programación</asp:ListItem>
                    <asp:ListItem>Diseño</asp:ListItem>
                    <asp:ListItem>Economía</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

