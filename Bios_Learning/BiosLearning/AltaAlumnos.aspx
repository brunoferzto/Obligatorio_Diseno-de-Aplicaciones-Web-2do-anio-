<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AltaAlumnos.aspx.cs" Inherits="AltaAlumnos" Theme="" StyleSheetTheme="Tema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 160px;
        }
        .auto-style3 {
            width: 160px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 160px;
            height: 23px;
        }
        .auto-style7 {
            width: 89px;
        }
        .auto-style8 {
            width: 89px;
            height: 28px;
        }
        .auto-style9 {
            width: 89px;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style8">
                <asp:Label ID="Label3" runat="server" Text="Nombre :"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:Button ID="btnagregar" runat="server" OnClick="btnagregar_Click" Text="Agregar" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="Label4" runat="server" Text="Cédula :"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="Télefono" runat="server" Text="Telefono :"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txttele" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="lblerror" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style9"></td>
            <td class="auto-style6"></td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

