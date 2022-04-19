<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="LengthBetweenCities.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">  
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
    color: black; 
    border: 2px solid #ff0000;
}  
.button1:hover {
  background-color: #ff0000;
  color: white;
}
</style> 
</head>
<body>
    <form id="form1" runat="server" style="font-family: Arial, Helvetica, sans-serif">
        <div style="width: 1400px; margin: 0 auto; text-align: center;">
            Number of cities -
        <asp:Label ID="Label1" runat="server" BackColor="White" BorderColor="Black" ForeColor="Red" Font-Names="Arial" Font-Underline="False"></asp:Label>
            , roads -
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Font-Names="Arial" Font-Underline="False"></asp:Label>
&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Cities&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Table ID="Table3" style="width: 271px; margin: 0 auto; text-align: center;" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" CellPadding="5" CellSpacing="5" GridLines="Both" Font-Names="Arial">
        </asp:Table>
        <br />
        The known roads<br />
        <asp:Table ID="Table1" style="width: 271px; margin: 0 auto; text-align: center;" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" CellPadding="5" CellSpacing="5" GridLines="Both" Font-Names="Arial">
        </asp:Table>
        <br />
        Start:
        <asp:Label ID="Label3" runat="server" ForeColor="Red" Font-Names="Arial"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Finish:
        <asp:Label ID="Label4" runat="server" ForeColor="Red" Font-Names="Arial"></asp:Label>
            <br />
        <br />
        <asp:Button ID="Button1" runat="server" BorderStyle="Solid" BorderWidth="2px" OnClick="Button1_Click" CssClass="button button1" Text="Find the shortest path" />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label6" runat="server" ForeColor="Red" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label7" runat="server" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label10" runat="server" ForeColor="Red" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label11" runat="server" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label12" runat="server" ForeColor="Red" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label13" runat="server" Font-Names="Arial"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Font-Names="Arial"></asp:Label>
        <br />
        <asp:Table ID="Table2" style="width: 271px; margin: 0 auto; text-align: center;" runat="server" CellPadding="5" CellSpacing="5">
        </asp:Table>
        </div>
    </form>
</body>
</html>
