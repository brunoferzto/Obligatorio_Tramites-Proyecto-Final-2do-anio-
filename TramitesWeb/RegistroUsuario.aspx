<%@ Page Title="" Language="C#" MasterPageFile="~/MPGeneral.master" AutoEventWireup="true" CodeFile="RegistroUsuario.aspx.cs" Inherits="RegistroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="Css/Estiloss.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style4 {
            width: 230px;
            text-align: right;
        }
        .auto-style5 {
            width: 230px;
            height: 26px;
            text-align: right;
        }
        .auto-style6 {
            height: 26px;
            text-align: left;
        }
        .auto-style7 {
            width: 230px;
            text-align: right;
            height: 27px;
        }
        .auto-style8 {
            height: 27px;
            text-align: left;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            width: 100%;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style12 {
            outline-width: medium;
            outline-style: none;
            outline-color: invert;
            font-size: 18px;
            border-radius: 10px;
            color: #fff;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            margin-top: 4px;
            background-color: skyblue;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="ImgRegistroUsuario" runat="server" Height="81px" ImageUrl="~/Imagenes/RegistroUsuario.png" Width="498px" CssClass="auto-style11" />
    </p>
        <div class="Caja-Registro">
        <table border="0" class="auto-style10">
            <tr>
                <td class="auto-style7"><strong>DOCUMENTO&nbsp;&nbsp; </strong></td>
                <td class="auto-style8">
                    &nbsp;
                    <asp:TextBox ID="TxtDocumento" CssClass="txts" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>CONTRASEÑA&nbsp;&nbsp; </strong></td>
                <td class="auto-style6">
                    &nbsp;
                    <asp:TextBox ID="TxtPass" CssClass="txts" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><strong>NOMBRE Y APELLIDO&nbsp;&nbsp; </strong></td>
                <td class="auto-style9">
                    &nbsp;
                    <asp:TextBox ID="TxtNomComp"  CssClass="txts" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><strong>TELEFONO&nbsp;&nbsp; </strong></td>
                <td class="auto-style9">
                    &nbsp;
                    <asp:TextBox ID="TxtTel" CssClass="txts" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
            <br />
            <asp:Button ID="BtnAlta" CssClass="botones" runat="server" Text="Alta" OnClick="BtnAlta_Click" />
            <br />
            <br />
            <asp:Label ID="LblError" runat="server"></asp:Label>
            </div>
    <p>

        &nbsp;</p>
    <p>

        &nbsp;</p>
    
</asp:Content>

