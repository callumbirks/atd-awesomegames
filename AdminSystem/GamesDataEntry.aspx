<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesDataEntry.aspx.cs" Inherits="_Games_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGameId" runat="server" Text="Game ID" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtGameId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblGameTitle" runat="server" Text="Title" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtGameTitle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDiscount" runat="server" Text="Discount (%)" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDatePublished" runat="server" Text="Date Published"></asp:Label>
            <asp:Calendar ID="calDatePublished" runat="server"></asp:Calendar>
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" OnCheckedChanged="chkActive_CheckedChanged" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
