<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="BanHang.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Style="width: 100%;">
            <Columns>
                <asp:BoundField DataField="MASANPHAM" HeaderText="masp" />
                <asp:BoundField DataField="TENSANPHAM" HeaderText="tensp" />
                <asp:BoundField DataField="SOLUONG" HeaderText="soluog" />
                <asp:BoundField DataField="DONGIA" HeaderText="dongia" />
                <asp:BoundField DataField="THANHTIEN" HeaderText="thanhtien" />
                <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="IMAGES/{0}" HeaderText="hinhanh">
                    <ItemStyle Width="100px" Height="100px" />
                    <ControlStyle Width="100px" Height="100px" />
                </asp:ImageField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </div>
</asp:Content>
