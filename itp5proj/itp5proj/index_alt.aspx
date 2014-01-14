<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="itp5proj.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style.css" />
    <title>Website ITP 5</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="title">
        <h1>ITP 5 ASP.NET Homepage by Philipp Langer & Sergej Onishchuk</h1></div>
    <div id="navigation">
        <asp:Menu ID="Menu" OnMenuItemClick="Item_Click" runat="server"  StaticDisplayLevels = "3" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <Items>
                <asp:MenuItem Text="PC" Value="PC"></asp:MenuItem>
                <asp:MenuItem Text ="PS3" Value="PS3" ></asp:MenuItem>
                <asp:MenuItem Text ="Xbox" Value="Xbox"></asp:MenuItem>
                <asp:MenuItem Text="Wii" Value="Wii"></asp:MenuItem>
                <asp:MenuItem Text="WiiU" Value="WiiU"></asp:MenuItem>
                <asp:MenuItem Text="PS Vita" Value="PSVita"></asp:MenuItem>                
                <asp:MenuItem Text="Kontakt" Value="Kontakt"></asp:MenuItem>
                <asp:MenuItem Text="Impressum" Value="Impressum"></asp:MenuItem>
                <asp:MenuItem Text="Registrieren" Value="Register"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu> 
     </div>    
            <div id="content">
                <iframe id="ifr" runat="server" src="PC.aspx"/>
            </div>
        <div id="login">
            <asp:Label ID="logintext" Visible="false" Text="" runat="server"/><asp:LinkButton ID="LogoutKlick" Visible="false" Text="Logout" OnClick="LogoutKlick_Click" runat="server"/><br />
            Username:<asp:TextBox ID="lname" runat="server" /><br />
            Password:<asp:TextBox ID="pwd" runat="server" /><br />
            <asp:Button ID="Button1" Text="Login" OnClick="Button1_Click" runat="server" />
        </div>
    </form>
</body>
</html>
