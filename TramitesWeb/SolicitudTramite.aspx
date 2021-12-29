<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.master" AutoEventWireup="true" CodeFile="SolicitudTramite.aspx.cs" Inherits="SolicitudTramite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 602px;
            height: 64px;
        }
        .auto-style5 {
            left: 40px;
            top: 86px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="Css/Estiloss.css" rel="stylesheet" />
    <p>
        <br />
    </p>
    <br />
    <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img alt="" class="auto-style4" src="Imagenes/SolicitudDeTramites.png" /><br />
    <br />
    <div class="Caja-Solicitud" >

        <p class="fecha" style="color: #00CC00; font-size: x-large;"><strong>Fecha</strong></p>
        <p class="hora" style="color: #00CC00; font-size: x-large"><strong>Hora</strong></p>
        <p class="tipo" style="color: #00CC00; font-size: x-large"><strong>Tipo</strong></p>
        
        <br />
        <asp:DropDownList ID="DdlHora" class="DdlHora" runat="server">
            <asp:ListItem>8:00</asp:ListItem>
            <asp:ListItem>8:30</asp:ListItem>
            <asp:ListItem>9:00</asp:ListItem>
            <asp:ListItem>9:30</asp:ListItem>
            <asp:ListItem>10:00</asp:ListItem>
            <asp:ListItem>10:30</asp:ListItem>
            <asp:ListItem>11:00</asp:ListItem>
            <asp:ListItem>11:30</asp:ListItem>
            <asp:ListItem>13:00</asp:ListItem>
            <asp:ListItem>13:30</asp:ListItem>
            <asp:ListItem>14:00</asp:ListItem>
            <asp:ListItem>14:30</asp:ListItem>
            <asp:ListItem>15:00</asp:ListItem>
            <asp:ListItem>15:30</asp:ListItem>
            <asp:ListItem>16:00</asp:ListItem>
            <asp:ListItem>16:30</asp:ListItem>
                 </asp:DropDownList>
                
        
       
        <asp:DropDownList ID="DdlTipo" CssClass="DdlTipo" runat="server">
            <asp:ListItem>Tipo 1</asp:ListItem>
            <asp:ListItem>Tipo 2</asp:ListItem>
            <asp:ListItem>Tipo 3</asp:ListItem>
            <asp:ListItem>Tipo 4</asp:ListItem>
            <asp:ListItem>Tipo 5</asp:ListItem>
        </asp:DropDownList>
        
        
       
    
        
        
       
        <asp:Calendar ID="CalFecha" class="CalFecha" runat="server" CssClass="auto-style5"></asp:Calendar>
        
        
       
        <asp:Button ID="BtnSolicitar" CssClass="BtnSolicitar" runat="server" Text="Solicitar" OnClick="BtnSolicitar_Click"  />
        
        
       
        <asp:Label ID="LblError" runat="server" CssClass="LblError"></asp:Label>
        
        
       
        <asp:GridView ID="GvTramites" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TiposdeTramite.Nombre" HeaderText="Tramites" />
                <asp:BoundField DataField="TiposdeTramite.Codigo" HeaderText="Codigo" Visible="False" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        
        
       
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

