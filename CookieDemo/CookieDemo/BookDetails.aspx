<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="CookieDemo.BookDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="SelBooks" runat="server" Width="500px"></asp:ListBox>
            <br/>
            <br/>
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" PostBackUrl="~/Books.aspx">Select Books</asp:LinkButton>
        </div>
    </form>
</body>
</html>
