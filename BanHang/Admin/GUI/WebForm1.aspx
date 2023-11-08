<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BanHang.Admin.GUI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <div class="center_title_bar">Latest Products</div>
        <asp:Label runat="server" Text="Label">Ma DAnh Muc</asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br />
        <asp:Label runat="server" Text="Label">Ma San Pham</asp:Label>
        <asp:TextBox ID="masp" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Label">Ten San Pham</asp:Label>
        <asp:TextBox ID="ten" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Label">Don Gia</asp:Label>
        <asp:TextBox ID="dongia" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Label">Hinh Anh</asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>
        <br />

        <asp:Button runat="server" Text="Them" OnClick="Unnamed6_Click" />
        <asp:Button runat="server" Text="Sua" OnClick="Unnamed7_Click" />
        <asp:Button runat="server" Text="Xoa" OnClick="Unnamed8_Click" />

        <asp:GridView ID="GridView1111" runat="server" AutoGenerateColumns="False" Style="width: 100%;">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="masp" />
                <asp:BoundField DataField="ten" HeaderText="tensp" />
                <asp:BoundField DataField="dongia" HeaderText="dongia" />
                <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="hinhanh" DataImageUrlFormatString="IMAGES/{0}" HeaderText="hinhanh">
                    <ItemStyle Width="100px" Height="100px" />
                    <ControlStyle Width="100px" Height="100px" />
                </asp:ImageField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </div>
</asp:Content>
