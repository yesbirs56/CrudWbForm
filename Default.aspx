<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WFDB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Customers<br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <asp:Button ID="BtnAdd" runat="server" Height="30px" OnClick="BtnAdd_Click" Text="Add" Width="55px" />
            <br />
            <br />
            <asp:Label ID="LblID" runat="server" Text="Enter ID"></asp:Label>
&nbsp;
            <asp:TextBox ID="TxtID" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
