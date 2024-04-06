<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CommonValidators.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style=" display: flex; flex-direction: column;align-items:center">
        <fieldset style="padding: 1.5rem; border-style: solid;width:70%">
        <legend>
            MYFORM
        </legend>       
        <div >
            <asp:Label ID="namelabel" runat="server" Text="Label">Name</asp:Label><br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Name Required" ControlToValidate="name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="ageLabel" runat="server" Text="Label">Age</asp:Label><br />
            <asp:TextBox ID="age" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Age Required" ControlToValidate="age" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="* Age Invalid" ForeColor="Red" ControlToValidate="age" Type="Integer" MaximumValue="101" MinimumValue="18"></asp:RangeValidator>
            <br />             
            <br />             
            <asp:Label ID="cityLabel" runat="server" Text="Label">City</asp:Label><br />

            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True"></asp:ListItem>
                <asp:ListItem>Dombivili</asp:ListItem>
                <asp:ListItem>Kalyan</asp:ListItem>
                <asp:ListItem>Mulund</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="* City Required" ForeColor="Red" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="genderLabel" runat="server" Text="Label">Gender</asp:Label><br />
            
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Gender Required" ControlToValidate="RadioButtonList1" ForeColor="Red"></asp:RequiredFieldValidator>
            
            <br />
            <asp:Label ID="emailLabel" runat="server" Text="Label">Email</asp:Label><br />
            <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
            <br/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Email Required" ControlToValidate="email" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Email Not Valid" ControlToValidate="email" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="hobbiesLabel" runat="server" Text="Label">Hobbies</asp:Label>
            <br />
            <div>

                <asp:CheckBoxList ID="Hobbies" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="0">Music</asp:ListItem>
                    <asp:ListItem Value="1">Gamming</asp:ListItem>
                    <asp:ListItem Value="2">Art</asp:ListItem>
                </asp:CheckBoxList>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="* Please Choose At Least One Hobby" ControlToValidate="Hobbies" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            
            </div>
            <br />
            <br />
            <asp:Label ID="passLabel" runat="server" Text="Label">Password</asp:Label><br />
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="confpassLabel" runat="server" Text="Label">Confirm Password</asp:Label><br />
            <asp:TextBox ID="confpassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="* Passwords Not Same" ControlToCompare="password" ControlToValidate="confpassword" ForeColor="Red"></asp:CompareValidator>
            <br />
            <input id="Submit" type="submit" value="submit" />
            <input id="Reset" type="reset" value="reset" />
           
        </div>
        </fieldset>
    </form>
</body>
</html>
