<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Projects.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .textb {
            padding: 8px 16px;
            text-align: center;
            font-size: 16px;
            margin: 2px 1px;
            width: 271px;
        }
        .button {
  background-color: #4CAF50;
  border: none;
  color: white;
  padding: 8px 16px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 2px 1px;
  transition-duration: 0.4s;
  cursor: pointer;
  width: 271px;
}
.button1 {  
    background-color: white; 
    color: #162a82; 
    border: 2px solid #162a82;
}  
.button1:hover {
  background-color: #162a82;
  color: lightblue;
}
        body {
  background-color: lightblue;
}
        .p1 {
  font-family: "Lucida Console", "Courier New", monospace;
  color: #162a82;
  font-weight: bold;
  font-size: 30px;
}
        .p2 {
  font-family: "Lucida Console", "Courier New", monospace;
  color: #162a82;
  font-size: 20px;
}
        .p3 {
  font-family: Georgia, serif;
  font-size: 20px;
}
        .p4 {
  font-family: "Lucida Console", "Courier New", monospace;
  color: #162a82;
  font-size: 20px;
  font-weight: bold;
}
        .auto-style1 {
            height: 70px;
        }
        .auto-style2 {
            font-family: "Lucida Console", "Courier New", monospace;
            color: #162a82;
            font-weight: bold;
            font-size: 30px;
            height: 70px;
        }
        .auto-style3 {
            height: 21px;
        }
        .auto-style4 {
            height: 172px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table valign="top" align="center" cellspacing="0" >
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td align="center" class="auto-style2">University projects</td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style22"></td>
                    <td class="auto-style46">&nbsp;</td>
                    <td align="center" class="auto-style52">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="button button1" Text="Scan initial data" />
                    </td>
                    <td class="auto-style46">&nbsp;</td>
                    <td class="auto-style16"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style27"></td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style28">
                        &nbsp;</td>
                    <td class="auto-style47">
                        <asp:Label ID="Label1" runat="server" class="p2"></asp:Label>
                    </td>
                    <td class="auto-style29"></td>
                    <td class="auto-style47">
                        <asp:Label ID="Label2" runat="server" class="p2"></asp:Label>
                    </td>
                    <td class="auto-style30">
                        &nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style27"></td>
                </tr>
                <tr>
                    <td class="auto-style27"></td>
                    <td class="auto-style27"></td>
                    <td class="auto-style28">
                        </td>
                    <td class="auto-style47">
                        </td>
                    <td class="auto-style29"></td>
                    <td class="auto-style47">
                        </td>
                    <td class="auto-style30">
                        </td>
                    <td class="auto-style27"></td>
                    <td class="auto-style27"></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style5">&nbsp;</td>
                    <td valign="top" class="auto-style23">
                        &nbsp;</td>
                    <td valign="top" class="auto-style48">
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" font-family="Georgia, serif" Font-Names="Georgia">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style6"></td>
                    <td valign="top" class="auto-style48">
                        <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Font-Names="Georgia">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                    <td valign="top" class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td valign="top" class="auto-style24">
                    </td>
                    <td valign="top" class="auto-style49">
                        &nbsp;</td>
                    <td class="auto-style13"></td>
                    <td valign="top" class="auto-style49">
                        &nbsp;</td>
                    <td valign="top" class="auto-style18">
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td valign="top" class="auto-style25">
                    </td>
                    <td valign="top" class="auto-style50">
                        &nbsp;</td>
                    <td align="center" class="auto-style53">
                        <asp:Button ID="Button2" runat="server" Text="Generate professor list" CssClass="button button1" OnClick="Button2_Click" />
                    </td>
                    <td valign="top" class="auto-style50">
                        &nbsp;</td>
                    <td valign="top" class="auto-style19">
                    </td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td valign="top" class="auto-style25">
                        &nbsp;</td>
                    <td valign="top" class="auto-style50">
                        &nbsp;</td>
                    <td align="center" class="auto-style53">
                        &nbsp;</td>
                    <td valign="top" class="auto-style50">
                        &nbsp;</td>
                    <td valign="top" class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td valign="top" class="auto-style23">
                        &nbsp;</td>
                    <td valign="top" class="auto-style48">
                        &nbsp;</td>
                    <td align="center" class="auto-style52">
                        <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="68px" Font-Names="Georgia">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                    <td valign="top" class="auto-style48">
                        &nbsp;</td>
                    <td valign="top" class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td valign="top" class="auto-style26">
                        </td>
                    <td valign="top" class="auto-style51">
                        </td>
                    <td align="center" class="auto-style54">
                    </td>
                    <td valign="top" class="auto-style51">
                        </td>
                    <td valign="top" class="auto-style20">
                        </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                    <td valign="top" class="auto-style22">
                        </td>
                    <td valign="top" align="right">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" CssClass="button button1" Text="Sort" />
                    </td>
                    <td align="center" class="auto-style55">
                    </td>
                    <td valign="top" class="auto-style46">
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" CssClass="button button1" Text="Update" />
                    </td>
                    <td valign="top" class="auto-style16">
                        </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td valign="top" class="auto-style22">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td align="center" class="auto-style55">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td valign="top" class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                    <td valign="top" class="auto-style22">
                        </td>
                    <td valign="top" class="auto-style46">
                        </td>
                    <td align="center" class="auto-style55">
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" CssClass="button button1" Text="Check professor with most projects" Width="275px" />
                    </td>
                    <td valign="top" class="auto-style46">
                        </td>
                    <td valign="top" class="auto-style16">
                        </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td valign="top" class="auto-style22">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td align="center" class="auto-style55">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td valign="top" class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td valign="top" class="auto-style22">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td align="center" class="auto-style55">
                        <asp:Label ID="Label4" runat="server" class="p3"></asp:Label>
                    </td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td valign="top" class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td valign="top" class="auto-style22">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td align="center" class="auto-style55">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td valign="top" class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td valign="top" class="auto-style22">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td align="center" class="p4">
                        Enter the full name of a professor</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td valign="top" class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td valign="top" class="auto-style22">
                        &nbsp;</td>
                    <td valign="top" class="auto-style46">
                        &nbsp;</td>
                    <td align="center" class="auto-style55">
                        <asp:TextBox ID="TextBox1" runat="server" class="textb"></asp:TextBox>
                    </td>
                    <td valign="top" class="auto-style46">
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" CssClass="button button1" Text="Generate" />
                    </td>
                    <td valign="top" class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td valign="top" class="auto-style3">
                        </td>
                    <td valign="top" class="auto-style3">
                        </td>
                    <td align="center" class="auto-style3">
                        <asp:Label ID="Label5" runat="server" ForeColor="Red" class="p2"></asp:Label>
                    </td>
                    <td valign="top" class="auto-style3">
                        </td>
                    <td valign="top" class="auto-style3">
                        </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td valign="top" class="auto-style4">
                        </td>
                    <td valign="top" class="auto-style4">
                        </td>
                    <td align="center" class="auto-style4">
                        <asp:GridView ID="GridView4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Font-Names="Georgia" valign="top">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                    <td valign="top" class="auto-style4">
                        </td>
                    <td valign="top" class="auto-style4">
                        </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td valign="top" class="auto-style4">
                        &nbsp;</td>
                    <td valign="top" class="auto-style4">
                        &nbsp;</td>
                    <td align="center" class="auto-style4">
                        &nbsp;</td>
                    <td valign="top" class="auto-style4">
                        &nbsp;</td>
                    <td valign="top" class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
