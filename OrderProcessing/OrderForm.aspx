<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderForm.aspx.cs" Inherits="OrderProcessing.OrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Customer Id: "></asp:Label><asp:TextBox ID="tbxCid" runat="server"></asp:TextBox>
        <p/>
        <p>
        Poroducts: <asp:Label ID="lblMessage" runat="server" Visible="False"></asp:Label> <br />
        <asp:ListBox ID="lstProducts" runat="server" Rows="6" Width="163px" SelectionMode="Multiple" ></asp:ListBox> <br />
                </p>
            <p>
        <asp:Button ID="btnBuy" runat="server" Text="Purchase" OnClick="btnBuy_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="btnMain" runat="server" Text="Main Page" OnClick="btnMain_Click" />
                </p>
    </div>
    </form>
</body>
</html>
