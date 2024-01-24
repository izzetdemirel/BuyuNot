<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UyeListele.aspx.cs" Inherits="BuyuNot.AdminPanel.UyeListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="listetasiyici">
        <div class="listebaslik">
            <h2>Üyelerin Listesi</h2>
        </div>
        <asp:ListView ID="lv_uyeler" runat="server" OnItemCommand="lv_uyeler_ItemCommand">
            <LayoutTemplate>
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <th>ID</th>
                        <th>Isim</th>
                        <th>Soyisim</th>
                        <th>KullaniciAdi</th>
                        <th>Mail</th>
                        <th>KayitTarihi</th>
                        <th>Durum</th>
                    </tr>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Isim") %></td>
                    <td><%# Eval("Soyisim") %></td>
                    <td><%# Eval("KullaniciAdi") %></td>
                    <td><%# Eval("Mail") %></td>
                    <td><%# Eval("KayitTarihi") %></td>
                    <td><%# Eval("Durum") %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
