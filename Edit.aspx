<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WFDB.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1" runat="server">
            <asp:Label ID="LblID" runat="server" Text="ID : "></asp:Label>
&nbsp;<asp:Label ID="LblID1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
&nbsp;
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LblDOB" runat="server" Text="Date of birth"></asp:Label>
&nbsp;
            <asp:TextBox ID="TxtDOB" runat="server" TextMode="DateTime"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnSave" runat="server" OnClick="BtnSave_Click" Text="Save" />
            <br />
        </div>
    </form>
</body>
</html>
