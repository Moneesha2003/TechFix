<%@ Page Title="" Language="C#" MasterPageFile="~/TechFix.Master" AutoEventWireup="true" CodeBehind="QuotationRequests.aspx.cs" Inherits="TechFix.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel2" runat="server" Height="475px" BackColor="#CCCCCC" CssClass="auto-style3" ForeColor="#9900CC" HorizontalAlign="Center">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#000099"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="50px" Text="Requests"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="grdRequests" runat="server" AutoGenerateColumns="False" OnRowCommand="grdRequests_RowCommand" Height="267px" Width="902px" CssClass="auto-style2" ForeColor="Black" HorizontalAlign="Center">
    <Columns>
        <asp:BoundField DataField="QuotationID" HeaderText="Quotation ID" />
        <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
        <asp:BoundField DataField="Supplier" HeaderText="Supplier" />
        <asp:BoundField DataField="RequiredQuantity" HeaderText="Required Quantity" />
        <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" DataFormatString="{0:F2}" />

        <asp:TemplateField HeaderText="Action">
            <ItemTemplate>
                <asp:Button ID="btnApprove" runat="server" Text="Approve" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Approve" />
                <asp:Button ID="btnReject" runat="server" Text="Reject" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Reject" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    </asp:Panel>
</asp:Content>
