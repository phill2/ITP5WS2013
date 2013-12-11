<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="itp5proj.Kontakt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Vorname: <input type="text" name="vname" size="30" style="margin-left: 57px"/><br />
        <br />
    Nachname: <input type="text" name="nname" size="30" style="margin-left: 47px"/><br />
        <br />
    E-Mail-Adresse: <input type="email" name="mail" size="30" style="margin-left: 13px" /><br />
        <br />
    Beschreibung: 
        <br />
        <asp:TextBox TextMode="MultiLine" runat="server" size="50" Height="95px" style="margin-left: 117px" Width="256px" />
        <br />
        <br />
    <asp:Button ID="submit" runat="server" Text="Senden" Width="89px" style="margin-left: 96px" />
    <asp:Button ID="reset" runat="server" Text="Zurücksetzen" OnClick="reset_Click" style="margin-left: 110px" />
    </form>
</body>
</html>
