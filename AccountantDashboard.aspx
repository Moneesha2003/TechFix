<%@ Page Title="" Language="C#" MasterPageFile="~/TechFix.Master" AutoEventWireup="true" CodeBehind="AccountantDashboard.aspx.cs" Inherits="TechFix.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin-left: 332px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="652px" BackColor="#CCCCCC" CssClass="auto-style3" ForeColor="#9900CC" HorizontalAlign="Center">
            <asp:Label ID="Label1" runat="server" Text="Products List" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Supplier A's Products List" Font-Underline="True"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataKeyNames="ProductID,ProductPrice,Quantity" CssClass="auto-style2" ForeColor="Black" HorizontalAlign="Center">
    <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
        <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
        <asp:BoundField DataField="ProductPrice" HeaderText="Product Price" />
        <asp:BoundField DataField="Quantity" HeaderText="Quantity In Stock" />

        <asp:TemplateField HeaderText="Required Quantity">
            <ItemTemplate>
                <asp:TextBox ID="txtQuantity" runat="server" Text="1" AutoPostBack="true"></asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Calculate">
            <ItemTemplate>
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Calculate" />
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Total Price">
            <ItemTemplate>
                <asp:Label ID="lblTotalPrice" runat="server" Text="0"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Action">
            <ItemTemplate>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Submit" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>


            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Supplier B's Products List" Font-Underline="True"></asp:Label>
            <br />
            <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView2_RowCommand" DataKeyNames="ProductID,ProductPrice" CssClass="auto-style2" ForeColor="Black" HorizontalAlign="Center">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Product Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity In Stock" />

                <asp:TemplateField HeaderText="Required Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQuantity" runat="server" Text="1" AutoPostBack="true"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Calculate">
                    <ItemTemplate>
                        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Calculate" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Total Price">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalPrice" runat="server" Text="0"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Submit" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </asp:Panel>
</asp:Content>

