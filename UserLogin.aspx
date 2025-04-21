<%@ Page Title="" Language="C#" MasterPageFile="~/TechFix.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="TechFix.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel2" runat="server" Font-Bold="True" Font-Size="50px" ForeColor="#9900CC" Height="462px" HorizontalAlign="Center" BackColor="#CCCCCC">
        <br />
        User Login<br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="#660066" Text="Username :"></asp:Label>
        &nbsp;<asp:TextBox ID="txtUname" runat="server" BorderColor="#9900CC" BorderStyle="Solid" Height="30px" Width="276px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="#660066" Text="Password :"></asp:Label>
        &nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" BorderColor="#9900CC" BorderStyle="Solid" Height="30px" Width="276px"></asp:TextBox>
        <br />
        &nbsp;<br />
        <asp:Button ID="btnLogin" runat="server" BackColor="#9933FF" BorderColor="#660066" BorderStyle="Solid" Font-Bold="True" Font-Size="X-Large" ForeColor="#CCCCCC" OnClick="btnLogin_Click" Text="Login" Height="56px" Width="121px" />
        <br />
        <asp:Label ID="lblMessage" runat="server" Font-Size="Medium"></asp:Label>
    </asp:Panel>
</asp:Content>
