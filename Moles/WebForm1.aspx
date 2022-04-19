<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Moles.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 295px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Look how those moles damaged my precious land....<br />
        <br />
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Highlight" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
        <br />
        <br />
        <asp:Table ID="Table2" runat="server" Height="50px" HorizontalAlign="Left" Width="160px">
            <asp:TableRow runat="server" BorderColor="Black" ForeColor="Black">
                <asp:TableCell runat="server" BorderColor="Black" BorderWidth="2px" ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle">MOLES</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderWidth="2px" ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle">HOLES</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" BorderColor="Black" BorderWidth="1px" ForeColor="Black" HorizontalAlign="Center"></asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderWidth="1px" ForeColor="Black" HorizontalAlign="Center"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
