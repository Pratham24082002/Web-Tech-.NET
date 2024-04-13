<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ViewState.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 100vh; padding: 1rem">


    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="Name"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox runat="server" ID="Addr"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
            <asp:Button ID="btnRestore" runat="server" Text="Restore" OnClick="BtnRestore_Click" />
            <br />

        </div>
    </form>
</body>
</html>
