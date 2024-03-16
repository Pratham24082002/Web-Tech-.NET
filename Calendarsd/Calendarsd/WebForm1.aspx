<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calendarsd.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height:100vh">
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" Caption="MCA" BackColor="#CCFFCC" SkinID="12" CellSpacing="12" VisibleDate="2024-03-16" SelectedDate="03/16/2024 11:06:06" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender"></asp:Calendar>
            <br/>
            <br/>
            <asp:Label runat="server" Text="Label" ID="label1"></asp:Label>
            <br/>
            <br/>
            <asp:Label runat="server" Text="Label" ID="label2"></asp:Label>
            <br/>
            <br/>
            <asp:Button runat="server" Text="Result" ID="Button" OnClick="Button_Click"></asp:Button>
            <br/>
            <br/>
            <asp:Label runat="server" Text="Label" ID="label3"></asp:Label>

        </div>
    </form>
</body>
</html>
