<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="itp5proj.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    To register, please enter your desired Username and Password as well as your E-mail Address:<br />
        Enter Username:<asp:TextBox ID="user" runat="server"/><br />
        Enter password:<asp:TextBox ID="pwd" TextMode="Password" runat="server"/><br />
        Enter Email-Address:<asp:TextBox ID="email" runat="server"/><br />
        <asp:Button OnClick="Unnamed_Click" Text="Submit" runat="server"/>
    </div>
    </form>
</body>
</html>
