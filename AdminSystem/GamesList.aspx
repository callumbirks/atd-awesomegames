﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesList.aspx.cs" Inherits="_Games_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstGamesList" runat="server"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" style="width: 37px; height: 26px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <br />
        Search by Title:
        <asp:TextBox ID="txtTitleQuery" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
&nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
