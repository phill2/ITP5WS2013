<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PC.aspx.cs" Inherits="itp5proj.PC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="games">
        <table border="0">
        <asp:DataList ID="posts" runat="server">
            <ItemTemplate>
                    <tr>
                        <td><asp:Label runat="server"><%#DataBinder.Eval(Container.DataItem, "title")%><br /><%#DataBinder.Eval(Container.DataItem, "description")%></asp:Label></td>
                        <td><asp:Image runat="server" Height="200px" Width="100px" ImageUrl=<%#DataBinder.Eval(Container.DataItem, "cover")%> /></td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dispcomm">
                                <!--<iframe class="ifrc" runat="server" src="Comments.aspx" />-->
                            </div>
                        </td>
                    </tr>
            </ItemTemplate>
        </asp:DataList>
            <tr>
                <td>Choose game to comment on: <asp:DropDownList ID="ddl" runat="server"/><br />
                    <asp:TextBox ID="commt" Width="500px" Rows="7" TextMode="MultiLine" runat="server"/><br />
                    <asp:Button ID="scom" Text="Submit comment" Enabled="false" OnClick="scom_Click" runat="server" /><asp:Label ID="clo" Text="You have to be logged in to comment!" runat="server"/></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
