<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SehirIlceWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Sehir</label><br />
            <asp:DropDownList ID="ddl_sehir" runat="server" DataTextField="Isim" DataValueField="ID" OnSelectedIndexChanged="ddl_sehir_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div>
            <label>Ilce</label><br />
            <asp:DropDownList ID="ddl_ilce" runat="server" DataTextField="Isim" DataValueField="ID"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
