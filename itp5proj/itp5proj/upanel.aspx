<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BootstrapASP.Master" CodeBehind="upanel.aspx.cs" Inherits="itp5proj.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <title>Index</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="paneltext" runat="server">You need to login to use the panel!</asp:Label><br />
        <div>
            <asp:Panel ID="reg" Visible="false" runat="server">
                AccountSettings<br />
            </asp:Panel>
        </div>
    <div>
        <asp:Panel ID="mod" Visible="false" runat="server">
        Add new game
        Enter Game title:<asp:TextBox ID="gt" runat="server"/><br />
        Enter Game description:<asp:TextBox ID="gd" runat="server"/><br />
        Choose category:<asp:DropDownList ID="cc" runat="server"/><br />
        Enter link for the cover:<asp:TextBox ID="cl" runat="server"/><br />
            </asp:Panel>
    </div>
        <div>
            <asp:Panel ID="adm" Visible="false" runat="server">
            User Control
            Choose User:<asp:DropDownList ID="uss" runat="server"/><br />
            Choose Action:<asp:DropDownList ID="ca" runat="server"/>
            </asp:Panel>
        </div>
    </asp:Content>
