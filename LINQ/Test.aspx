<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="LINQ.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <br />
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="btnDisplay" />
        <asp:Button ID="btnGroup" runat="server" OnClick="btnGroup_Click" Text="btnGroup" />
        <asp:Button ID="btnAsc" runat="server" OnClick="btnAsc_Click" Text="btnAsc" />
        <asp:Button ID="btnDesc" runat="server" OnClick="btnDesc_Click" Text="btnDesc" />
        <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>
        <br />
        enter country name<asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
        <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="btnShow" />
    
    </div>
    </form>
</body>
</html>
