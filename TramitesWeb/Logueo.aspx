<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.master" AutoEventWireup="true" CodeFile="Logueo.aspx.cs" Inherits="Logueo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <link href="Css/Estiloss.css" rel="stylesheet" />
    <link href="Css/Logueooo.css" rel="stylesheet" />
    <div class="Caja-Logueo">
        <h1> Iniciar Sesión</h1>
        <h1> &nbsp;</h1>
        <asp:image runat="server" class="Logo-Logueo" ImageUrl="~/Imagenes/logueologo.png"></asp:image>
            <asp:Label ID="lblci" class="Labels" runat="server" Text="Nro de Cedula"></asp:Label>
            <asp:textbox runat="server" class="TextBoxs" ID="txtcedula" placeholder="Ingrese Cedula"></asp:textbox>

            <asp:Label ID="lblcontra" class="Labels" runat="server" Text="Contraseña"></asp:Label>
            <asp:textbox runat="server" class="TextBoxs" ID="txtcontra" TextMode="Password" placeholder="Ingrese Contraseña"></asp:textbox>

            <asp:button runat="server" class="Btn-Logueo" text="Entrar" ID="btnlogueo" OnClick="btnlogueo_Click" />

        
        <br />
        <br />

        

        <br />
        <br />
        <br />

        

    </div>
    <asp:Label ID="LblError" class="LblError" runat="server"></asp:Label>
</asp:Content>

