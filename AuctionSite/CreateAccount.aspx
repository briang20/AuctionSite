<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="AuctionSite.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 529px; top: 34px; position: absolute" Text="Create New Account"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 130px; top: 152px; position: absolute" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 213px; top: 150px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 131px; top: 198px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 214px; top: 197px; position: absolute" TabIndex="1" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblPassDesc" runat="server" style="z-index: 1; left: 395px; top: 197px; position: absolute" Text="Password must be at least 5 characters long and include a digit"></asp:Label>
        <asp:Label ID="lblAdd1" runat="server" style="z-index: 1; left: 195px; top: 328px; position: absolute" Text="Address 1:"></asp:Label>
        <asp:TextBox ID="txtAdd1" runat="server" style="z-index: 1; left: 285px; top: 326px; position: absolute" TabIndex="4"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 188px; top: 274px; position: absolute" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 285px; top: 272px; position: absolute" TabIndex="2"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 477px; top: 270px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 578px; top: 267px; position: absolute" TabIndex="3"></asp:TextBox>
        <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 513px; top: 370px; position: absolute" Text="State:"></asp:Label>
        <asp:DropDownList ID="ddlStates" runat="server" style="z-index: 1; left: 576px; top: 367px; position: absolute" TabIndex="7">
            <asp:ListItem Selected="True">PA</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblAdd2" runat="server" style="z-index: 1; left: 192px; top: 376px; position: absolute" Text="Address 2:"></asp:Label>
        <asp:TextBox ID="txtAdd2" runat="server" style="z-index: 1; left: 285px; top: 372px; position: absolute" TabIndex="6"></asp:TextBox>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 515px; top: 319px; position: absolute" Text="City:"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 579px; top: 319px; position: absolute" TabIndex="5"></asp:TextBox>
        <asp:Label ID="lblZip" runat="server" style="z-index: 1; left: 193px; top: 425px; position: absolute" Text="Zip Code:"></asp:Label>
        <asp:TextBox ID="txtZip" runat="server" style="z-index: 1; left: 285px; top: 424px; position: absolute" TabIndex="8" TextMode="Number"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 511px; top: 424px; position: absolute" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 572px; top: 420px; position: absolute" TabIndex="9" TextMode="Email"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 347px; top: 505px; position: absolute" TabIndex="10" Text="Submit" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 484px; top: 505px; position: absolute" TabIndex="11" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 294px; top: 91px; position: absolute" Visible="False"></asp:Label>
    </form>
</body>
</html>
