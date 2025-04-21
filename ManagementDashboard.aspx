<%@ Page Title="" Language="C#" MasterPageFile="~/TechFix.Master" AutoEventWireup="true" CodeBehind="ManagementDashboard.aspx.cs" Inherits="TechFix.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel2" runat="server" BackColor="#CCCCCC" Font-Bold="True" Font-Size="50px" ForeColor="#9900CC" Height="477px" HorizontalAlign="Center">
        <br />
        Management Dashboard<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblRequestCount" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#9933FF" BorderColor="#660066" BorderStyle="Solid" Font-Bold="True" Font-Size="X-Large" ForeColor="#CCCCCC" OnClick="Button1_Click" Text="Requests" />
        <br />
    </asp:Panel>
</asp:Content>
