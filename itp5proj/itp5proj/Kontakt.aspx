<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BootstrapASP.Master" CodeBehind="Kontakt.aspx.cs" Inherits="itp5proj.Kontakt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <title>Index</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    Vorname: <asp:TextBox ID="vname" width="100" style="margin-left: 57px" runat="server"/><br />
        <br />
    Nachname: <asp:TextBox ID="nname" width="100" style="margin-left: 47px" runat="server"/><br />
        <br />
    E-Mail-Adresse: <asp:TextBox ID="mail" width="100" style="margin-left: 13px" runat="server"/><br />
        <br />
    Beschreibung: 
        <br />
        <asp:TextBox TextMode="MultiLine" ID="message" runat="server" size="50" Height="95px" style="margin-left: 117px" Width="256px" />
        <br />
        <br />
    <asp:Button ID="submit" runat="server" Text="Senden" OnClick="submit_Click" Width="89px" style="margin-left: 96px" />
    <asp:Button ID="reset" runat="server" Text="Zurücksetzen" OnClick="reset_Click" style="margin-left: 110px" />
    </asp:Content>
