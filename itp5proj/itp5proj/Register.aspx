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
        Enter Username:<asp:TextBox ID="user" runat="server"/>
        Enter password:<asp:TextBox ID="pwd" runat="server"/>
        Enter Email-Address:<asp:TextBox ID="email" runat="server"/>
        <asp:Button OnClick="Unnamed_Click" runat="server"/>
    </div>
    </form>
</body>
</html>
