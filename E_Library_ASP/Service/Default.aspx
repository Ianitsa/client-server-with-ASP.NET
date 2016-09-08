<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Service.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblDefault" runat="server" Text="Този сайт търси URL, по зададен ISBN"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtDefault" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Търси" />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank">HyperLink</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
