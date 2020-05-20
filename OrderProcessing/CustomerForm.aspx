<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerForm.aspx.cs" Inherits="OrderProcessing.CustomerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
              <asp:Label ID="Label1" runat="server" Text="Customer No :"></asp:Label>
              &nbsp;&nbsp;
              <asp:TextBox ID="tbxCid" runat="server"></asp:TextBox>
            </p> 
            <p>
              <asp:Label ID="Label2" runat="server" Text="Customer Name:"></asp:Label>&nbsp;&nbsp; 
              <asp:TextBox ID="tbxCName" runat="server"></asp:TextBox>
            </p>
            <p>
              <asp:Label ID="Label3" runat="server" Text="Customer Orders"></asp:Label><br/>
              <asp:ListBox ID="lstOrders" runat="server"></asp:ListBox>
            </p>
            <p>
                <asp:Button ID="btnCustomer" runat="server" Text="Get Customer" OnClick="btnCustomer_Click" />&nbsp;&nbsp;&nbsp; 
                <asp:Button ID="btnMain" runat="server" Text="Main Page" OnClick="btnMain_Click" />
                <asp:Button ID="Button1" runat="server" Text="Button" />
            <p/>
        </div>
    </form>
</body>
</html>
