<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConsumerWebServices.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;&nbsp;<asp:Button CommandName="btnLoadData" ID="Button1" runat="server" Text="Show All Products" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <input type="button" id="btnClick" value="Click Me" />
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="#9999FF" BorderStyle="Outset" class="datagrid">
        </asp:GridView>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" BackColor="#FF9966" Height="50px" Width="125px" >
        </asp:DetailsView>
    </form>
</body>
</html>
