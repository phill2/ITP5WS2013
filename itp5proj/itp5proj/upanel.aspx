<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BootstrapASP.Master" CodeBehind="upanel.aspx.cs" Inherits="itp5proj.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <title>Index</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="paneltext" runat="server">You need to login to use the panel!</asp:Label><br />
        <div>
            <asp:Panel ID="reg" Visible="false" runat="server">
                <b>AccountSettings</b><br />
                Password Change:<br />
                Current Password:<asp:TextBox ID="cp" TextMode="Password" runat="server"/><br />
                New Password:<asp:TextBox ID="np" TextMode="Password" runat="server"/><br />
                Confirm New Password<asp:TextBox ID="npc" TextMode="Password" runat="server"/><br />
                <asp:Button OnClick="Unnamed_Click" Text="Change Password" runat="server" /><asp:Label ID="warn" Visible="false" runat="server"/><br />
            </asp:Panel>
        </div>
    <div>
        <asp:Panel ID="mod" Visible="false" runat="server">
        <b>Add new game</b><br />
        Enter Game title:<asp:TextBox ID="gt" runat="server"/><br />
        Enter Game description:<asp:TextBox ID="gd" Width="500px" Rows="7" TextMode="MultiLine" runat="server"/><br />
        Choose category:<asp:DropDownList ID="cc" runat="server">
            <asp:ListItem>PC</asp:ListItem>
            <asp:ListItem>PS3</asp:ListItem>
            <asp:ListItem>PSVita</asp:ListItem>
            <asp:ListItem>WiiU</asp:ListItem>
            <asp:ListItem>XBox</asp:ListItem>
                        </asp:DropDownList><br />
        Enter online link for the cover:<asp:TextBox ID="cl" runat="server"/><br />
            <asp:Button OnClick="addgame" Text="Add Game" runat="server"/>
            </asp:Panel>
    </div>
        <div>
            <asp:Panel ID="adm" Visible="false" runat="server">
            <b>User Control</b><br />
            Choose User:<asp:DropDownList ID="uss" runat="server"/><br />
            Choose Action:<asp:DropDownList ID="ca" runat="server">
                <asp:ListItem Value="1">Make Regular</asp:ListItem>
                <asp:ListItem Value="2">Make Moderator</asp:ListItem>
                <asp:ListItem Value="3">Delete</asp:ListItem>
                          </asp:DropDownList>
            <asp:Button OnClick="usc" Text="Modify User" runat="server"/><br />
            </asp:Panel>
        </div>
    </asp:Content>
