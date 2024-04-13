<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>STUD FORM</title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/flowbite/2.3.0/flowbite.min.css" rel="stylesheet" />
    <style>

        div > h3{
            padding:0.3rem;
            font-size:1.1rem;
        }

        form{
            padding : 0.5rem;
        }

    </style>
</head>
<body class="p-4">
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="Label1" CssClass="text-5xl font-extrabold dark:text-white" runat="server" Text="Student Information Form"></asp:Label>
            </h1>
            <br />
            <div>
                <h3>
                    <span>
                        <asp:Label ID="StudIDL" runat="server" Text="Student ID"></asp:Label>
                    </span>
                </h3>
                <asp:TextBox ID="StudID" runat="server" CssClass="block w-full p-4 text-gray-900 border border-gray-300 rounded-lg bg-gray-50 text-base focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"></asp:TextBox>
            </div>
            <br />
            <div>
                <h3>
                    <span>
                        <asp:Label ID="StudNL" runat="server" Text="Student Name"></asp:Label>
                    </span>
                </h3>
                <asp:TextBox ID="StudN" runat="server" CssClass="block w-full p-4 text-gray-900 border border-gray-300 rounded-lg bg-gray-50 text-base focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"></asp:TextBox>
            </div>
            <br />
            <div>
                <h3>
                    <span>
                        <asp:Label ID="CityL" runat="server" Text="City"></asp:Label>
                    </span>
                </h3>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="block w-full p-4 text-gray-900 border border-gray-300 rounded-lg bg-gray-50 text-base focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-50">
                    <asp:ListItem>Domboli</asp:ListItem>
                    <asp:ListItem>Mulund</asp:ListItem>
                    <asp:ListItem>Dadar</asp:ListItem>
                    <asp:ListItem>Thane</asp:ListItem>
                    <asp:ListItem>Kalayan</asp:ListItem>
                    <asp:ListItem>Tokyo</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div>
                <h3>
                    <span>
                        <asp:Label ID="AgeL" runat="server" Text="Age"></asp:Label>
                    </span>
                </h3>
                <asp:TextBox ID="Age" runat="server" CssClass="block w-full p-4 text-gray-900 border border-gray-300 rounded-lg bg-gray-50 text-base focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"></asp:TextBox>
            </div>
            <div>
                <h3>
                    <span>
                        <asp:Label ID="ContactL" runat="server" Text="Contact"></asp:Label>
                    </span>
                </h3>
                <asp:TextBox ID="Contact" runat="server" CssClass="block w-full p-4 text-gray-900 border border-gray-300 rounded-lg bg-gray-50 text-base focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"></asp:TextBox>
            </div>
        </div>

        <br />
        <asp:Button ID="Create" runat="server" Text="Create" CssClass="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2 dark:bg-blue-600 dark:hover:bg-blue-700 focus:outline-none dark:focus:ring-blue-800" OnClick="CreateS" />
        <asp:Button ID="Update" runat="server" Text="Update" CssClass="focus:outline-none text-white bg-yellow-400 hover:bg-yellow-500 focus:ring-4 focus:ring-yellow-300 font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2 dark:focus:ring-yellow-900" OnClick="UpdateS" />
        <asp:Button ID="Delete" runat="server" Text="Delete" CssClass="focus:outline-none text-white bg-red-700 hover:bg-red-800 focus:ring-4 focus:ring-red-300 font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2 dark:bg-red-600 dark:hover:bg-red-700 dark:focus:ring-red-900" OnClick="DeleteS"/>
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover"></asp:GridView>
        </div>
    </form>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/flowbite/2.3.0/flowbite.min.js"></script>
</body>
</html>
