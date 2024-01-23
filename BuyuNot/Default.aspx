<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuyuNot.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rp_Notlar" runat="server">
        <ItemTemplate>
            <div class="not">
                <h3 style="min-height:50px;"><%# Eval("Baslik") %></h3>
                <div class="yazarKategori">
                    Kategori: <%# Eval("Kategori") %>    | Yazar: <%# Eval("Yazar") %> 
                </div>
                <div class="ozet">
                    <%# Eval("Ozet") %>
                </div>
                <a class="devamiButton" href='NotIcerik.aspx?nid=<%# Eval("ID") %>'>Yazının Devamı</a>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
