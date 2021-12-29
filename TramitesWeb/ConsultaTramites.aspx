<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.master" AutoEventWireup="true" CodeFile="ConsultaTramites.aspx.cs" Inherits="ConsultaTramites" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="Css/Estiloss.css" rel="stylesheet" />
    <style type="text/css">
    .auto-style4 {
        width: 503px;
        height: 66px;
    }
        .auto-style14 {
            font-size: x-large;
        }
        .auto-style15 {
            color: #FFCC00;
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p class="auto-style2">
        &nbsp;</p>
<p class="auto-style2">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img alt="" class="auto-style4" src="Imagenes/ConsultaTramites.png" /></p>
    
        <div class="Caja-Consulta" >
        <strong><span class="auto-style15">Filtros</span><br />
            <br />
            </strong>
        <div><span class="auto-style14">Precio</span><br />
&nbsp;<asp:TextBox ID="txtPrecio" CssClass="txts" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="BtnFiltrarPrecio" CssClass="botones" runat="server" Text="Filtrar" OnClick="BtnFiltrarPrecio_Click" />
            <br />
            <br />
            <br />
            <span class="auto-style14">Año</span><br />
                <asp:DropDownList ID="ddlAño" runat="server" >
                </asp:DropDownList>
                <br />
                <asp:Button ID="BtnFiltrarAnio" CssClass="botones" runat="server" Text="Filtrar" OnClick="BtnFiltrarAnio_Click" />
            </div>
            <br />
    <asp:Label ID="LblError" runat="server"></asp:Label>
    <br />
            </div>
    <p class="auto-style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Repeater ID="RtTipoTramites" runat="server" OnItemCommand="RtTipoTramites_ItemCommand">
            <ItemTemplate>
                <table>
                    <th>
                    Nombre:<asp:TextBox ID="TxtNombre"
                        runat="server" Text='<%# Bind("Nombre") %>'>
                           </asp:TextBox>
                        <br />
                        </th>
                    <td>
                    <asp:LinkButton ID="HLIndividual"
                        runat="server" CommandName="Seleccionar"
                        Text="Seleccionar"></asp:LinkButton>
                            </td>
                    <asp:TextBox ID="TxtCodigo"
                        runat="server" Visible="false" Text='<%# Bind("Codigo")%>'>
                    </asp:TextBox>
                    <asp:TextBox ID="TxtPrecio"
                        runat="server" Visible="false" Text='<%# Bind("Precio")%>'>
                    </asp:TextBox>

                </table>
            </ItemTemplate>
        </asp:Repeater>
    </p>
    <p class="auto-style2">
        <asp:Xml ID="XmlTramite" runat="server"></asp:Xml>
    </p>
    <br />
</asp:Content>

