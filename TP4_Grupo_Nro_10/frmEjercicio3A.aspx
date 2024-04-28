<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEjercicio3A.aspx.cs" Inherits="TP4_Grupo_Nro_10.frmEjercicio3A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-bottom: 40px;
        }
        .auto-style2 {
            width: 130px;
        }
        .auto-style3 {
            width: 231px;
        }
        .auto-style4 {
            width: 130px;
            height: 53px;
        }
        .auto-style5 {
            width: 231px;
            height: 53px;
        }
        .auto-style6 {
            height: 53px;
        }
        .auto-style7 {
            width: 130px;
            height: 55px;
        }
        .auto-style8 {
            width: 231px;
            height: 55px;
        }
        .auto-style9 {
            height: 55px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">Seleccionar Tema:</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="ddlTemas" runat="server" Height="25px" Width="115px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lnkLibros" runat="server" OnClick="lnkLibros_Click">Ver Libros</asp:LinkButton>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
