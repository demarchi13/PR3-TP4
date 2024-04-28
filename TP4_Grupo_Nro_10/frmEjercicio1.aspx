<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEjercicio1.aspx.cs" Inherits="TP4_Grupo_Nro_10.frmEjercicio1" %>

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
            width: 125px;
        }
        .auto-style3 {
            text-decoration: underline;
            width: 133px;
        }
        .auto-style4 {
            width: 125px;
            height: 18px;
        }
        .auto-style5 {
            height: 18px;
        }
        .auto-style6 {
            height: 18px;
            width: 133px;
        }
        .auto-style7 {
            width: 133px;
        }
        .auto-style8 {
            width: 125px;
            height: 19px;
        }
        .auto-style9 {
            height: 19px;
            width: 133px;
        }
        .auto-style10 {
            height: 19px;
        }
        .auto-style11 {
            width: 125px;
            height: 30px;
        }
        .auto-style12 {
            width: 133px;
            height: 30px;
        }
        .auto-style13 {
            height: 30px;
        }
        .auto-style14 {
            width: 125px;
            height: 29px;
        }
        .auto-style15 {
            width: 133px;
            height: 29px;
        }
        .auto-style16 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">DESTINO INICIO:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"><strong>PROVINCIA:</strong></td>
                    <td class="auto-style13">
                        <asp:DropDownList ID="ddlProvinciaInicio" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"><strong>LOCALIDAD:</strong></td>
                    <td class="auto-style13">
                        <asp:DropDownList ID="ddlLocalidadInicio" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">DESTINO FINAL:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"><strong>PROVINCIA:</strong></td>
                    <td class="auto-style13">
                        <asp:DropDownList ID="ddlProvinciaFinal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaFinal_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"><strong>LOCALIDAD:</strong></td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="ddlLocalidadFinal" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
