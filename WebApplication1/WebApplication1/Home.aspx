<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height:100vh;">
    
    
    <form id="form1" runat="server">
        <div style="padding:1.5rem;">
            <asp:TreeView ID="TreeView1" runat="server" BorderColor="#99CCFF" BackColor="#FF9900">
                <Nodes>
                    <asp:TreeNode Selected="True" Text="Snaccc" ToolTip="Snaccc" Value="Snaccc">
                        <asp:TreeNode Text="VEG" ToolTip="VEG" Value="VEG">
                            <asp:TreeNode Text="MENU" ToolTip="MENU" Value="MENU">
                                <asp:TreeNode Text="PANNER CRISPSY" ToolTip="PANNER CRISPSY" Value="PANNER CRISPSY"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="DESSERT" ToolTip="DESSERT" Value="DESSERT">
                                <asp:TreeNode Text="PUDDING" ToolTip="PUDDING" Value="PUDDING"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="NON-VEG" ToolTip="NON-VEG" Value="NON-VEG">
                            <asp:TreeNode Text="CHICKEN CRISPY" ToolTip="CHICKEN CRISPY" Value="CHICKEN CRISPY"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
