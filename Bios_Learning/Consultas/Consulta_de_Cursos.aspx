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
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            width: 479px;
            height: 22px;
        }
        .auto-style4 {
            width: 178%;
        }
        .auto-style5 {
            width: 199px;
        }
        .auto-style6 {
            width: 186px;
        }
        .auto-style7 {
            width: 43px;
        }
        .auto-style8 {
            width: 33px;
        }
        .auto-style9 {
            width: 54px;
        }
        .auto-style11 {
            text-decoration: underline;
        }
        .auto-style12 {
            width: 33px;
            height: 86px;
        }
        .auto-style13 {
            width: 199px;
            height: 86px;
        }
        .auto-style14 {
            width: 43px;
            height: 86px;
        }
        .auto-style15 {
            width: 186px;
            height: 86px;
        }
        .auto-style16 {
            width: 54px;
            height: 86px;
        }
        .auto-style17 {
            height: 86px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <table class="auto-style4">
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style5"><strong><span class="auto-style11">Seleccione Tipo de Curso:</span> </strong> </td>
                            <td class="auto-style7">&nbsp;</td>
                            <td class="auto-style6"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style11">Seleccione Sucursal:</span></strong></td>
                            <td class="auto-style9">&nbsp;</td>
                            <td><strong>&nbsp;&nbsp; <span class="auto-style11">Ingrese dos Fechas:&nbsp;&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong> </td>
                        </tr>
                        <tr>
                            <td class="auto-style12"></td>
                            <td class="auto-style13"><asp:RadioButtonList ID="RBLtipo" runat="server" OnSelectedIndexChanged="RBLtipo_SelectedIndexChanged" AutoPostBack="True" Width="134px">
                        <asp:ListItem Value="Corto">Cortos</asp:ListItem>
                        <asp:ListItem Value="Especializado">Especializados</asp:ListItem>
                    </asp:RadioButtonList>
                            </td>
                            <td class="auto-style14"></td>
                            <td class="auto-style15"><asp:DropDownList ID="DDLSucursal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLSucursal_SelectedIndexChanged">
                    </asp:DropDownList>
                            </td>
                            <td class="auto-style16"></td>
                            <td class="auto-style17">&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Filtrar" Font-Bold="True" Font-Italic="False" Font-Names="Agency FB" />
                                <br />
&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtfechados" runat="server" OnTextChanged="txtfechados_TextChanged"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style5">&nbsp;</td>
                            <td class="auto-style7">&nbsp;</td>
                            <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnlimpiar" runat="server" Text="Limpiar" OnClick="btnlimpiar_Click" Height="23px" Font-Bold="True" Font-Names="Agency FB" />
                &nbsp;&nbsp;</td>
                            <td class="auto-style9">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Repeater ID="RTCurso" runat="server" OnItemCommand="RTCurso_ItemCommand">
                         <ItemTemplate>
                        <table>
                            <tr bgcolor="#999966">
                                
                                 <td>
                                   Codigo: <asp:TextBox ID ="TxtCodigo" ReadOnly ="true"
                                    runat="server"  Width="50" Text='<%# Bind("Codigo")%>'>
                                    </asp:TextBox>
                                         <br />
                                   </td>
                                 <td>
                                    Nombre: <asp:TextBox ID="TxtNombre" ReadOnly ="true"
                                    runat ="server" Width="220" Text ='<%#Bind("Nombre") %>'></asp:TextBox>
                                          <br />
                                   </td>
                                 <td>
                                    Sucursal: <asp:TextBox ID="txtSucursal" ReadOnly ="true"
                                    runat ="server" Width="220" Text ='<%#Bind("Local.Nombre") %>'></asp:TextBox>
                                         <br />
                                    </td>
                                 <td>
                                     Fecha: <asp:TextBox ID="txtfecha" ReadOnly ="true"
                                    runat ="server" Width="70" Text ='<%#Bind("Fecha_Inicio") %>'></asp:TextBox>
                                         <br />
                                     </td>
                                <td>
                                     Costo: <asp:TextBox ID="txtprecio" ReadOnly ="true"
                                    runat ="server" Width="50" Text ='<%#Bind("Costo") %>'></asp:TextBox>  
                                        <br />
                                    </td>     
                                 <td>
                                     Tipo Curso: <asp:TextBox ID="txttipo" ReadOnly ="true"
                                    runat ="server" Width="110" Text ='<%#Bind("TipoCurso") %>'></asp:TextBox>  
                                    </td>   
                                            
                                <td>
                                    <asp:LinkButton ID="LkConsulta" runat="server" style ="text-align: center" ForeColor ="White" CommandName ="aIndividual"
                                       >Consulta Individual</asp:LinkButton>
                                       <br />                     
                                </td>         
                        </table>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                           <table>
                            <tr bgcolor= "#33cccc"

                            </tr>

                                 <td>
                                   Codigo: <asp:TextBox ID ="TxtCodigo" ReadOnly ="true"
                                    runat="server"  Width="50" Text='<%# Bind("Codigo")%>'>
                                    </asp:TextBox>
                                         <br />
                                   </td>
                                 <td>
                                    Nombre: <asp:TextBox ID="TxtNombre" ReadOnly ="true"
                                    runat ="server" Width="220" Text ='<%#Bind("Nombre") %>'></asp:TextBox>
                                          <br />
                                   </td>
                                 <td>
                                    Sucursal: <asp:TextBox ID="txtSucursal" ReadOnly ="true"
                                    runat ="server" Width="220" Text ='<%#Bind("Local.Nombre") %>'></asp:TextBox>
                                         <br />
                                    </td>
                                 <td>
                                     Fecha: <asp:TextBox ID="txtfecha" ReadOnly ="true"
                                    runat ="server" Width="70" Text ='<%#Bind("Fecha_Inicio") %>'></asp:TextBox>
                                         <br />
                                     </td>
                                <td>
                                     Costo: <asp:TextBox ID="txtprecio" ReadOnly ="true"
                                    runat ="server" Width="50" Text ='<%#Bind("Costo") %>'></asp:TextBox>  
                                        <br />
                                    </td>     
                                 <td>
                                      Tipo Curso: <asp:TextBox ID="txttipo" ReadOnly ="true"
                                    runat ="server" Width="110" Text ='<%#Bind("TipoCurso") %>'></asp:TextBox>  
                                    </td>   
                                            
                                <td>
                                   <asp:LinkButton ID="LkConsulta" runat="server" style ="text-align: center" ForeColor ="White" CommandName ="aIndividual"
                                       >Consulta Individual</asp:LinkButton>
                                       <br />                     
                                </td>         
                        </table>

                    </AlternatingItemTemplate>
                    </asp:Repeater>
                </td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblerror" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
