<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Consulta_de_Cursos.aspx.cs" Inherits="Consulta_de_Cursos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 479px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DDLSucursal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLSucursal_SelectedIndexChanged">
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnlimpiar" runat="server" Text="Limpiar" OnClick="btnlimpiar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <asp:RadioButtonList ID="RBLtipo" runat="server" OnSelectedIndexChanged="RBLtipo_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Value="Corto">Cortos</asp:ListItem>
                        <asp:ListItem Value="Especializado">Especializados</asp:ListItem>
                    </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <asp:Repeater ID="RTCurso" runat="server" OnItemCommand="RTCurso_ItemCommand">
                         <ItemTemplate>
                        <table>
                            <tr bgcolor="#993333">

                                 <td>
                                   Codigo: <asp:TextBox ID ="TxtCodigo" ReadOnly ="true"
                                    runat="server" Text='<%# Bind("Codigo")%>'>
                                    </asp:TextBox>
                                         <br />
                                   </td>
                                 <td>
                                    Nombre: <asp:TextBox ID="TxtNombre" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Nombre") %>'></asp:TextBox>
                                          <br />
                                   </td>
                                 <td>
                                    Sucursal: <asp:TextBox ID="txtSucursal" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Local.Nombre") %>'></asp:TextBox>
                                         <br />
                                    </td>
                                 <td>
                                     Fecha: <asp:TextBox ID="txtfecha" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Fecha_Inicio") %>'></asp:TextBox>
                                         <br />
                                     </td>
                                <td>
                                     Costo: <asp:TextBox ID="txtprecio" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Costo") %>'></asp:TextBox>  
                                        <br />
                                    </td>     
                                 <td>
                                     Tipo Curso: <asp:TextBox ID="txttipo" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("TipoCurso") %>'></asp:TextBox>  
                                    </td>   
                                            
                                <td>
                                    <asp:LinkButton ID="LkConsulta" runat="server" style ="text-align: center" ForeColor ="RED" CommandName ="aIndividual"
                                       >Consulta Individual</asp:LinkButton>
                                       <br />                     
                                </td>         
                        </table>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                           <table>
                            <tr bgcolor="Black"></tr>

                                 <td>
                                   Codigo: <asp:TextBox ID ="TxtCodigo" ReadOnly ="true"
                                    runat="server" Text='<%# Bind("Codigo")%>'>
                                    </asp:TextBox>
                                         <br />
                                   </td>
                                 <td>
                                    Nombre: <asp:TextBox ID="TxtNombre" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Nombre") %>'></asp:TextBox>
                                          <br />
                                   </td>
                                 <td>
                                    Sucursal: <asp:TextBox ID="txtSucursal" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Local.Nombre") %>'></asp:TextBox>
                                         <br />
                                    </td>
                                 <td>
                                     Fecha: <asp:TextBox ID="txtfecha" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Fecha_Inicio") %>'></asp:TextBox>
                                         <br />
                                     </td>
                                <td>
                                     Costo: <asp:TextBox ID="txtprecio" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("Costo") %>'></asp:TextBox>  
                                        <br />
                                    </td>     
                                 <td>
                                      Tipo Curso: <asp:TextBox ID="txttipo" ReadOnly ="true"
                                    runat ="server" Text ='<%#Bind("TipoCurso") %>'></asp:TextBox>  
                                    </td>   
                                            
                                <td>
                                   <asp:LinkButton ID="LkConsulta" runat="server" style ="text-align: center" ForeColor ="RED" CommandName ="aIndividual"
                                       >Consulta Individual</asp:LinkButton>
                                       <br />                     
                                </td>         
                        </table>

                    </AlternatingItemTemplate>
                    </asp:Repeater>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <asp:Label ID="lblerror" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
