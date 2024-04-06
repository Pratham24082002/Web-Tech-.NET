<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADO.WebForm1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" DataKeyField="Id" RepeatDirection="Horizontal" GridLines="Vertical" BorderColor="Black" BorderWidth="1px" CellPadding="5">
                <ItemTemplate>
                    Id:
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /><br />
                    Name:
                    <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" /><br />
                    Class:
                    <asp:Label Text='<%# Eval("Class") %>' runat="server" ID="ClassLabel" /><br />
                    Address:
                    <asp:Label Text='<%# Eval("Address") %>' runat="server" ID="AddressLabel" /><br />
                    <br />
                </ItemTemplate>
            </asp:DataList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:DB1ConnectionString %>" SelectCommand="SELECT [Id], [Name], [Class], [Address] FROM [Students]"></asp:SqlDataSource>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Name" DataValueField="Id" DataSourceID="SqlDataSource1"></asp:DropDownList>
        </div>
        <br />
        <div>

            <asp:DetailsView ID="DetailsView1" runat="server" Height="300px" Width="500px" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" BackImageUrl="https://i.giphy.com/7zJgqvSbjBH2M.webp" AutoGenerateInsertButton="True" AutoGenerateRows="False">
                <Fields>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id"></asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Class" HeaderText="Class" SortExpression="Class"></asp:BoundField>
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
                    <asp:BoundField DataField="Id" ReadOnly="True" SortExpression="Id"></asp:BoundField>
                </Fields>
            </asp:DetailsView>
        </div>

        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id"></asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                <asp:BoundField DataField="Class" HeaderText="Class" SortExpression="Class"></asp:BoundField>
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
            </Columns>
        </asp:GridView>

        <br />
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="Id">
            <AlternatingItemTemplate>
                <tr style="background-color: #FAFAD2; color: #284775;">
                    <td>
                        <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Class") %>' runat="server" ID="ClassLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Address") %>' runat="server" ID="AddressLabel" /></td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color: #FFCC66; color: #000080;">
                    <td>
                        <asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" />
                        <asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel1" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("Name") %>' runat="server" ID="NameTextBox" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("Class") %>' runat="server" ID="ClassTextBox" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("Address") %>' runat="server" ID="AddressTextBox" /></td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button runat="server" CommandName="Insert" Text="Insert" ID="InsertButton" />
                        <asp:Button runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton" />
                    </td>
                    <td>
                        <asp:TextBox Text='<%# Bind("Id") %>' runat="server" ID="IdTextBox" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("Name") %>' runat="server" ID="NameTextBox" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("Class") %>' runat="server" ID="ClassTextBox" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("Address") %>' runat="server" ID="AddressTextBox" /></td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #FFFBD6; color: #333333;">
                    <td>
                        <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Class") %>' runat="server" ID="ClassLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Address") %>' runat="server" ID="AddressLabel" /></td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table runat="server" id="itemPlaceholderContainer" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;" border="1">
                                <tr runat="server" style="background-color: #FFFBD6; color: #333333;">
                                    <th runat="server">Id</th>
                                    <th runat="server">Name</th>
                                    <th runat="server">Class</th>
                                    <th runat="server">Address</th>
                                </tr>
                                <tr runat="server" id="itemPlaceholder"></tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center; background-color: #FFCC66; font-family: Verdana, Arial, Helvetica, sans-serif; color: #333333;">
                            <asp:DataPager runat="server" ID="DataPager1">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True"></asp:NextPreviousPagerField>
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #FFCC66; font-weight: bold; color: #000080;">
                    <td>
                        <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Class") %>' runat="server" ID="ClassLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("Address") %>' runat="server" ID="AddressLabel" /></td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <br />
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource2">
            <Series>
                <asp:Series Name="Series1" XValueMember="Roll" YValueMembers="Marks"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString="<%$ ConnectionStrings:DB1ConnectionString %>" SelectCommand="SELECT * FROM [Marks]"></asp:SqlDataSource>
        </form>


</body>
</html>
