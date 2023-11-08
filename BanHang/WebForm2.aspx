<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BanHang.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="center_content">
                <div class="center_title_bar">Chi tiết sản phẩm</div>

                <div class="prod_box_big">
                    <div class="top_prod_box_big"></div>
                    <div class="center_prod_box_big">
                        <div class="product_img_big">
                            <a href="javascript:popImage('images/big_pic.jpg','Some Title')" title="header=[Zoom] body=[&nbsp;] fade=[on]">
                                <img src="images/<%# Eval("hinhanh") %>" alt="" border="0"
                                    width="100px" height="100px"></a>
                            <div class="thumbs">
                                <a href="#" title="header=[Thumb1] body=[&nbsp;] fade=[on]">
                                    <img src="images/<%# Eval("hinhanh") %>" alt="" border="0" width="30px" height="30px"></a> <a href="#" title="header=[Thumb2] body=[&nbsp;] fade=[on]">
                                        <img src="images/<%# Eval("hinhanh") %>" alt="" border="0" width="30px" height="30px"></a> <a href="#" title="header=[Thumb3] body=[&nbsp;] fade=[on]">
                                            <img src="images/<%# Eval("hinhanh") %>" alt="" border="0" width="30px" height="30px"></a>
                            </div>
                        </div>
                        <div class="details_big_box">
                            <div class="product_title_big"><%# Eval("ten") %></div>
                            <div class="specifications">
                                Disponibilitate: <span class="blue">In stoc</span><br>
                                Garantie: <span class="blue">24 luni</span><br>
                                Tip transport: <span class="blue">Mic</span><br>
                                Pretul include <span class="blue">TVA</span><br>
                            </div>
                            <div class="prod_price_big"><span class="reduce">350$</span> <span class="price">270$</span></div>
                            <a href="WebForm2.aspx?id=<%# Convert.ToInt32(Eval("id")) * -1 %>" class="addtocart">add to cart</a> <a href="#" class="compare">compare</a>
                        </div>
                    </div>
                    <div class="bottom_prod_box_big"></div>
                </div>

            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
