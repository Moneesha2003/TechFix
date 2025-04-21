<%@ Page Title="" Language="C#" MasterPageFile="~/TechFix.Master" AutoEventWireup="true" CodeBehind="SupplierA.aspx.cs" Inherits="TechFix.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin-left: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel2" runat="server" Height="1098px" BackColor="#CCCCCC" Font-Bold="True" ForeColor="#9900CC" HorizontalAlign="Center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="50px" Text="Supplier A's Dashboard"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="#660066" Text="Product ID:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductID" runat="server" BorderColor="#9900CC" BorderStyle="Solid" CssClass="auto-style2" Height="30px" Width="276px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="#660066" Text="Product Name:"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" BorderColor="#9900CC" BorderStyle="Solid" CssClass="auto-style2" Height="30px" Width="276px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Size="Medium" ForeColor="#660066" Text="Product Price:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtProductPrice" runat="server" BorderColor="#9900CC" BorderStyle="Solid" CssClass="auto-style2" Height="30px" Width="276px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Size="Medium" ForeColor="#660066" Text="Quantity:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductQuantity" runat="server" BorderColor="#9900CC" BorderStyle="Solid" CssClass="auto-style2" Height="30px" Width="276px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" BackColor="#9933FF" BorderColor="#660066" Font-Bold="True" Font-Size="Large" ForeColor="#CCCCCC" Height="35px" OnClick="btnAdd_Click" Text="Add" Width="120px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" BackColor="#9933FF" BorderColor="#660066" Font-Bold="True" Font-Size="Large" ForeColor="#CCCCCC" Height="35px" OnClick="btnUpdate_Click" Text="Update" Width="120px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" BackColor="#9933FF" BorderColor="#660066" Font-Bold="True" Font-Size="Large" ForeColor="#CCCCCC" Height="35px" OnClick="btnDelete_Click" Text="Delete" Width="120px" />
        <br />
        <br />
        <asp:Button ID="btnFind" runat="server" BackColor="#9933FF" BorderColor="#660066" Font-Bold="True" Font-Size="Large" ForeColor="#CCCCCC" Height="35px" OnClick="btnFind_Click" Text="Find" Width="120px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" BackColor="#9933FF" BorderColor="#660066" Font-Bold="True" Font-Size="Large" ForeColor="#CCCCCC" Height="35px" OnClick="btnClear_Click" Text="Clear" Width="120px" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnViewAll" runat="server" BackColor="#9933FF" BorderColor="#660066" Font-Bold="True" Font-Size="Large" ForeColor="#CCCCCC" OnClick="btnViewAll_Click" Text="View All" />
        <br />
        <br />
        <asp:GridView ID="grdAllProducts" runat="server" ForeColor="Black" HorizontalAlign="Center">
        </asp:GridView>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblQuotationsCount" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="btnQuotations" runat="server" BackColor="#9933FF" BorderColor="#660066" Font-Bold="True" Font-Size="Large" ForeColor="#CCCCCC" Height="36px" Text="Orders" OnClick="btnQuotations_Click" />
        <br />
        <br />
        <asp:GridView ID="grdQuotations" runat="server" ForeColor="Black" HorizontalAlign="Center">
        </asp:GridView>
    </asp:Panel>
</asp:Content>
