<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BootstrapASP.Master" CodeBehind="PS3.aspx.cs" Inherits="itp5proj.PS3" %>
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
                    <asp:Button ID="scom" Text="Submit comment" Enabled="false" OnClick="scom_Click" runat="server" /><asp:Label ID="clo" Text="You have to be logged in to comment!" runat="server"/></td>
            </tr>
        </table>
    </div>
    </asp:Content>
   
