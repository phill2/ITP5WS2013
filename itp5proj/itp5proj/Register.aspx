<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BootstrapASP.Master" CodeBehind="Register.aspx.cs" Inherits="itp5proj.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <title>Index</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    To register, please enter your desired Username and Password as well as your E-mail Address:<br />
        Enter Username:<asp:TextBox ID="user" runat="server"/><br />
        Enter password:<asp:TextBox ID="pwd" TextMode="Password" runat="server"/><br />
        Enter Email-Address:<asp:TextBox ID="email" runat="server"/><br />
        <asp:Button OnClick="Unnamed_Click" Text="Submit" runat="server"/>
    </div>
    </asp:Content>
