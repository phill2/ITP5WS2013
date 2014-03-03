<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BootstrapASP.Master" CodeBehind="PC.aspx.cs" Inherits="itp5proj.PC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <title>Index</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="games">
        <asp:Table ID="gc" BorderWidth="3" runat="server">
        </asp:Table>
        <table>
            <tr>
                <td>Choose game to comment on: <asp:DropDownList ID="ddl" runat="server"/><br />
                    <asp:TextBox ID="commt" Width="500px" Rows="7" TextMode="MultiLine" runat="server"/><br />
                    <asp:Button ID="scom" Text="Submit comment" Enabled="false" OnClick="scom_Click" runat="server" /></td>
                <td>Rate Game: <asp:DropDownList ID="ddl2" runat="server"/><br />
                <asp:TextBox ID="score" Width="500px" runat="server"/><br />
                <asp:Button ID="sr" Text="Submit Rating" Enabled="false" OnClick="sr_Click" runat="server" /><asp:Label ID="clo" Text="You have to be logged in to comment or rate!" runat="server"/></td>
            </tr>
        </table>
    </div>
    </asp:Content>