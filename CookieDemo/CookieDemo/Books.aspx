<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="CookieDemo.Books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <asp:Label ID="lblBook" runat="server" Text="Select Books"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="books" runat="server" AutoPostBack="True"></asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="BtnAdd" runat="server" Text="Add a Book" OnClick="BtnAdd_Click" />
            <br />
            <br />
            <asp:Button ID="BtnDetails" runat="server" Text="View Details" OnClick="BtnDetails_Click" />
            <asp:Label ID="IsErr" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
