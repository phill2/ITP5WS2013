<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PC.aspx.cs" Inherits="itp5proj.PC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="posts" runat="server">
            <ItemTemplate>
                <asp:Label runat="server"><%#DataBinder.Eval(Container.DataItem, "title")%><br /><%#DataBinder.Eval(Container.DataItem, "description")%></asp:Label>
                <asp:Image ImageAlign="Right" runat="server" Height="200px" Width="100px" ImageUrl=<%#DataBinder.Eval(Container.DataItem, "cover")%> /><!--Linie nicht beachten, es soll so sein-->
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
