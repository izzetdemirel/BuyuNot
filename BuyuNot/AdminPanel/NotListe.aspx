<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="NotListe.aspx.cs" Inherits="BuyuNot.AdminPanel.NotListe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Liste.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="listetasiyici">
        <div class="listebaslik">
            <h3>Notlar</h3>
        </div>
        <div class="listeicerik">
            <asp:ListView ID="lv_Notlar" runat="server"
                OnItemCommand="lv_Notlar_ItemCommand">
                <LayoutTemplate>
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <th>ID</th>
                            <th>Başlık</th>
                            <th>Notu Ekleyen</th>
                            <th>Kategori</th>
                            <th>Ekleme Tarihi</th>
                            <th>Durum</th>
                            <th width="20%">Seçenekler</th>
                        </tr>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("Baslik") %></td>
                        <td><%# Eval("Yazar") %></td>
                        <td><%# Eval("Kategori") %></td>
                        <td><%# Eval("EklenmeTarih") %></td>
                        <td><%# Eval("Durum") %></td>
                        <td>
                            <a href="NotDüzenle.aspx?kid=<%# Eval("ID") %>" title="Düzenle">
                                <img src="Resimler/edit.png" /></a>
                            <asp:LinkButton ID="lbtn_durum" runat="server" title="Durum Değiştir" CommandName="durum" CommandArgument='<%# Eval("ID") %>'><img src="Resimler/recycle.png" /></asp:LinkButton>
                            <asp:LinkButton ID="lbtn_sil" runat="server"
                                title="sil" CommandName="sil" CommandArgument='<%# Eval("ID") %>'><img src="Resimler/delete.png" /></asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
