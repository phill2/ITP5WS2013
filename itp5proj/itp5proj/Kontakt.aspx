<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="itp5proj.Kontakt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Vorname: <asp:TextBox ID="vname" width="30" style="margin-left: 57px" runat="server"/><br />
        <br />
    Nachname: <asp:TextBox ID="nname" width="30" style="margin-left: 47px" runat="server"/><br />
        <br />
    E-Mail-Adresse: <asp:TextBox ID="mail" width="30" style="margin-left: 13px" runat="server"/><br />
        <br />
    Beschreibung: 
        <br />
        <asp:TextBox TextMode="MultiLine" ID="message" runat="server" size="50" Height="95px" style="margin-left: 117px" Width="256px" />
        <br />
        <br />
    <asp:Button ID="submit" runat="server" Text="Senden" OnClick="submit_Click" Width="89px" style="margin-left: 96px" />
    <asp:Button ID="reset" runat="server" Text="Zurücksetzen" OnClick="reset_Click" style="margin-left: 110px" />
    </form>
</body>
</html>
