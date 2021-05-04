<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesViewer.aspx.cs" Inherits="_GamesViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Game ID: "></asp:Label>
            <asp:Label ID="txtGameId" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Game Title: "></asp:Label>
            <asp:TextBox ID="txtGameTitle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            Discount: 
            <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Date Published: "></asp:Label>
            <asp:Calendar ID="calDatePublished" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Is Active?: "></asp:Label>
            <asp:CheckBox ID="chkActive" runat="server" />
            <br />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
