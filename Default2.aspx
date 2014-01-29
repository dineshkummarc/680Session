<%@ Page Title="" Language="C#" MasterPageFile="~/RoseindiaMaster.master" AutoEventWireup="true"
    CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style2
        {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p class="style2">
        Welcome
        <asp:Label ID="Label1" runat="server" ForeColor="#006600" Text="Label" Font-Size="XX-Large"></asp:Label>
    </p>
    </asp:Content>
