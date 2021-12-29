<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMSucursales.aspx.cs" Inherits="ABMSucursales" Theme="" StyleSheetTheme="Tema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 266px;
        }
        .auto-style8 {
            margin-left: 9px;
        }
        .auto-style10 {
            width: 137px;
        }
        .auto-style16 {
            width: 137px;
            height: 24px;
        }
        .auto-style17 {
            height: 24px;
        }
        .auto-style18 {
            width: 266px;
            height: 24px;
        }
        .auto-style19 {
            margin-left: 0px;
        }
        .auto-style21 {
            width: 137px;
            height: 53px;
        }
        .auto-style22 {
            height: 53px;
        }
        .auto-style23 {
            width: 266px;
            height: 53px;
        }
        .auto-style25 {
            width: 137px;
            height: 26px;
        }
        .auto-style26 {
            height: 26px;
        }
        .auto-style27 {
            width: 266px;
            height: 26px;
        }
        .auto-style28 {
            width: 148px;
        }
        .auto-style29 {
            width: 148px;
            height: 53px;
        }
        .auto-style30 {
            width: 148px;
            height: 26px;
        }
        .auto-style31 {
            width: 148px;
            height: 24px;
        }
        .auto-style32 {
            width: 102px;
        }
        .auto-style33 {
            width: 102px;
            height: 53px;
        }
        .auto-style34 {
            width: 102px;
            height: 26px;
        }
        .auto-style35 {
            width: 102px;
            height: 24px;
        }
        .auto-style36 {
            width: 72px;
        }
        .auto-style37 {
            width: 72px;
            height: 53px;
        }
        .auto-style38 {
            width: 72px;
            height: 26px;
        }
        .auto-style39 {
            width: 72px;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">
                &nbsp;</td>
            <td class="auto-style36">
                <asp:Button ID="btnlimpia" runat="server" OnClick="btnlimpia_Click" Text="Limpiar" />
                </td>
            <td class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Nombre :"></asp:Label>
            </td>
            <td class="auto-style10"><asp:TextBox ID="txtnombre" runat="server" Height="16px" Width="221px"></asp:TextBox>
                </td>
            <td>
                <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Buscar" />
            </td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style33"></td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style29">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Dirección :"></asp:Label>
            </td>
            <td class="auto-style21">
                <asp:TextBox ID="txtdire" runat="server" Width="221px" CssClass="auto-style19" OnTextChanged="txtdire_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style22">&nbsp;<asp:Button ID="btnnewsucu" runat="server" OnClick="Button2_Click" Text="Nueva Sucursal" BorderStyle="Inset" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style34"></td>
            <td class="auto-style38">&nbsp;</td>
            <td class="auto-style30">&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="       Nueva Facilidad :"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:TextBox ID="txtnuevafacil" runat="server" OnTextChanged="txtnuevafacil_TextChanged" Width="173px">ingrese nueva facilidad</asp:TextBox>
                </td>
            <td class="auto-style26"></td>
            <td class="auto-style27"></td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style10">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="                               Facilidades"></asp:Label>
&nbsp;<asp:ListBox ID="lbfacilidad" runat="server" CssClass="auto-style8" OnSelectedIndexChanged="lbfacilidad_SelectedIndexChanged" Width="209px" Height="117px"></asp:ListBox>
                <br />
            </td>
            <td><asp:Button ID="btnregistra" runat="server" Text="Registrar" OnClick="Button1_Click" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" Enabled="False" Width="75px" />
            </td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style10">
                <asp:Button ID="Button3" runat="server" Text="Guardar Cambios" OnClick="Button3_Click" BorderStyle="Inset" />
                </td>
            <td>
                <asp:Button ID="btnborrartodo" runat="server" OnClick="btnborrartodo_Click" Text="Eliminar Sucursal" BorderStyle="Inset" />
            </td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35"></td>
            <td class="auto-style39">&nbsp;</td>
            <td class="auto-style31"></td>
            <td class="auto-style16"><asp:Label ID="lblerror" runat="server"></asp:Label>
            </td>
            <td class="auto-style17"></td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

