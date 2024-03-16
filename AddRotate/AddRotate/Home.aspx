<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AddRotate.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="color:wheat;padding:0;margin:0">
    <form id="form1" runat="server">
        <div>
            <marquee>
                <div>
                    <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="Advertisements" Width="500px" ForeColor="White" />
                    <asp:XmlDataSource runat="server" ID="Advertisements" DataFile="~/Advertisements.xml"></asp:XmlDataSource>
                </div>
            </marquee>               
        </div>

        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br/>
        <asp:Label runat="server" Text="Label" ID="label1"></asp:Label>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Btn1Click" />
    </form>
</body>
</html>
