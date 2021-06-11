<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WFDB.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Customer<br />
            <br />
            <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LblDOB" runat="server" Text="DOB : "></asp:Label>
            <asp:TextBox ID="TxtDOB" runat="server" TextMode="DateTime"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
&nbsp;
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnSave" runat="server" OnClick="BtnSave_Click" Text="Add" />
            <br />
        </div>
    </form>
</body>
</html>
