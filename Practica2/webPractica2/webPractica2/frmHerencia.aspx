<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHerencia.aspx.cs" Inherits="webPractica2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Segunda Práctica - Herencia y Polimorfismo</title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style6 {
            width: 471px;
        }
        .auto-style7 {
            width: 472px;
        }
        .auto-style8 {
            width: 473px;
        }
        .auto-style9 {
            width: 474px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="text-align: center"><%--Tabla1x13--%>
                <%--Fila1--%>
                <tr>
                    <td>
                        <h1 style="text-align: center">
                            <asp:Label ID="Label1" runat="server" style="text-align: center" Text="Cálculo de Figuras Geotricas en 2D."></asp:Label>
                        </h1>
                    </td>
                </tr>
                <%--Fila2--%>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <%--Fila3--%>
                <tr>
                    <td style="text-align: center">
                        <asp:RadioButtonList ID="rlbfiguras" runat="server" RepeatDirection="Horizontal" Height="16px" Width="100%" OnSelectedIndexChanged="rlbfiguras_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True" Value="opcTri">Triangulo.</asp:ListItem>
                            <asp:ListItem Value="opcRec">Rectangulo.</asp:ListItem>
                            <asp:ListItem Value="opcRom">Rombo.</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <%--Fila4--%>
                <tr>
                    <td>
                        <asp:Image ID="imgFigura" ImageUrl="imageurl" runat="server" />
                    </td>
                </tr>
                <%--Fila5--%>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="lblMsj" runat="server" ForeColor="Red" style="text-align: center; font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <%--Fila6--%>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <%--Fila7--%>
                <tr>
                    <td style="text-align: center">
                        <asp:Panel ID="pnlTriangulo" runat="server">
                            <table align="center" class="auto-style1">
                                <tr>
                                    <td class="auto-style9">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <asp:Label ID="Label2" runat="server" Text="Lado A"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtLadoA" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <asp:Label ID="Label3" runat="server" Text="Lado B"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtLadoB" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <asp:Label ID="Label4" runat="server" Text="Ángulo"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtAngulo" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <%--Fila8--%>
                <tr>
                    <td>
                        <asp:Panel ID="pnlRectangulo" runat="server" Visible="false">
                            <table align="center" class="auto-style1">
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">
                                        <asp:Label ID="Label8" runat="server" Text="Lado A"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtLado1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">
                                       <asp:Label Text="Lado B" runat="server"></asp:Label>
                                   </td>
                                    <td>
                                        <asp:TextBox ID="txtLado2" runat="server"/>  
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <%--Fila9--%>
                <tr>
                    <td>
                        <asp:Panel ID="pnlRombo" runat="server" Visible="False">
                            <table align="center" class="auto-style1">
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label5" runat="server" Text="Diagonal mayor:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDiagMy" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label6" runat="server" Text="Diagonal menor:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDiagMn" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label7" runat="server" Text="Lado"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtLado" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <%--Fila10--%>
                <tr>
                    <td>&nbsp;</td> 
                </tr>
                <%--Fila11--%>
                <tr>
                    <td>
                        <asp:Button ID="btnCalcular" Text="Calcular" runat="server" style="font-weight: 700" OnClick="btnCalcular_Click" />
                    </td>
                </tr>
                <%--Fila12--%>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <%--Fila13--%>
                <tr>
                    <td>
                        <asp:Panel ID="pnlRpta" runat="server" Visible="false">
                            <table align="center" class="auto-style1">
                                <tr>
                                    <td class="auto-style6">
                                        <asp:Label Text="Área" runat="server"/>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblArea" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">
                                        <asp:Label Text="Perímetro" runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label ID="lblPerim" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan = "2" style="text-align : center">
                                        <asp:Button ID="btnLimpiar" Text="Limpiar" runat="server" style="font-weight : 700" OnClick="btnLimpiar_Click" />
                                    </td>
                                </tr>
                                </table>                               
                        </asp:Panel>                   
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
