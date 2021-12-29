<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AMBEmpleado.aspx.cs" Inherits="AMBEmpleado" Theme="" StyleSheetTheme="Tema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 97px;
        }
        .auto-style3 {
            width: 97px;
            height: 10px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style13 {
            height: 10px;
        }
        .auto-style14 {
            width: 85px;
        }
        .auto-style15 {
            width: 85px;
            height: 10px;
        }
        .auto-style18 {
            width: 144px;
        }
        .auto-style19 {
            height: 10px;
            width: 144px;
        }
        .auto-style20 {
            width: 170px;
        }
        .auto-style21 {
            height: 10px;
            width: 170px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">
                <asp:Button ID="btnbuscar" runat="server" CssClass="auto-style5" OnClick="btnbuscar_Click" Text="Buscar" Height="39px" Width="95px" />
            </td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">
                <asp:Button ID="btnlimpiar" runat="server" OnClick="btnlimpiar_Click" Text="Limpiar" Width="95px" Height="39px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20"><strong>&nbsp;Nombre de Usuario : </strong> </td>
            <td class="auto-style18">
                <asp:TextBox ID="txtnomusu" runat="server" Width="160px" Font-Size="Large" Height="20px"></asp:TextBox>
            </td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20"><strong>Contraseña :</strong></td>
            <td class="auto-style18">
                <asp:TextBox ID="txtcontra" runat="server" Width="160px" Font-Size="Large" Height="20px"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Button ID="btnmodiciar" runat="server" OnClick="Button3_Click" Text="Modificar" Width="95px" Height="39px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblblerror" runat="server"></asp:Label>
            </td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style21">&nbsp;<asp:Button ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" Height="39px" Width="95px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19"></td>
            <td class="auto-style15">
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" Height="39px" Width="95px" />
            </td>
            <td class="auto-style13">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

