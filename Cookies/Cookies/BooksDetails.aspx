<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksDetails.aspx.cs" Inherits="Cookies.BooksDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            You have selected:
            <br />
            <br />
            <br />
&nbsp;<asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/Books.aspx">LinkButton</asp:LinkButton>
            <br />
        </div>
    </form>
</body>
</html>
