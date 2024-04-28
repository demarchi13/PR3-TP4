<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEjercicio2.aspx.cs" Inherits="TP4_Grupo_Nro_10.frmEjercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 132px;
        }
        .auto-style3 {
            width: 132px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            width: 101px;
            height: 30px;
        }
        .auto-style6 {
            width: 101px;
        }
        .auto-style7 {
            height: 30px;
            width: 296px;
        }
        .auto-style8 {
            width: 296px;
        }
        .auto-style13 {
            width: 132px;
            height: 11px;
        }
        .auto-style14 {
            width: 101px;
            height: 11px;
        }
        .auto-style15 {
            width: 296px;
            height: 11px;
        }
        .auto-style16 {
            height: 11px;
        }
        .auto-style21 {
            width: 132px;
            height: 16px;
        }
        .auto-style22 {
            width: 101px;
            height: 16px;
        }
        .auto-style23 {
            width: 296px;
            height: 16px;
        }
        .auto-style24 {
            height: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Id Producto:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlProducto" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtProducto" runat="server" Width="227px"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style3">Id Categoria:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlCategoria" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtCategoria" runat="server" Width="227px"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style22"></td>
                    <td class="auto-style23"></td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="btnFiltrar" runat="server" Height="32px" OnClick="btnFiltrar_Click" Text="Filtrar" Width="56px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnQuitarFiltro" runat="server" Height="32px" OnClick="btnQuitarFiltro_Click" Text="Quitar Filtro" />
&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style16"></td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="gvProductos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
