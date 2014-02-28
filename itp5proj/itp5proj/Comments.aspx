<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="itp5proj.Comments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
    <form id="form1" runat="server">
    <div>
        Comments:<br />
        <table border="0">
            <tr>
                <th>Comment</th>
                <th>Game</th>
            </tr>
        <asp:DataList ID="commies" runat="server">
            <ItemTemplate>
    <tr>
        <td><asp:Label runat="server"><%#DataBinder.Eval(Container.DataItem, "body")%></asp:Label></td>
            <td><asp:Label runat="server"><%#DataBinder.Eval(Container.DataItem, "title")%></asp:Label></td>
    </tr>
    </ItemTemplate>
    </asp:DataList>
            </table>
            </div>
    </form>
</body>
</html>
