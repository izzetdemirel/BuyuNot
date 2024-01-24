<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AktifUyeler.aspx.cs" Inherits="BuyuNot.AdminPanel.AktifUyeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formTasiyici">
        <div class="formBaslik">
            <h3>Üyelerin Listesi</h3>
        </div>
        <br />
        <br />
        <a href='AktifUyeler.aspx?uyeid=<%# Eval("ID") %>'>Aktif Üyeler</a>
        <a href='PasifUyeler.aspx?uyeid'=<%# Eval("ID") %>>Pasif Üyeler</a>
        <br />
        <br />
        <br />
        <asp:ListView ID="lv_uyeler" runat="server" OnItemCommand="lv_uyeler_ItemCommand">
            <LayoutTemplate>
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <th>ID</th>
                        <th>Isim</th>
                        <th>Soyisim</th>
                        <th>KullaniciAdi</th>
                        <th>Mail</th>
                        <th>Kayıt Tarihi</th>
                        <th>Durum</th>
                        <th width="20%">Seçenekler</th>

                    </tr>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("Isim") %></td>
                    <td><%# Eval("Soyisim") %></td>
                    <td><%# Eval("KullaniciAdi") %></td>
                    <td><%# Eval("Mail") %></td>
                    <td><%# Eval("KayitTarihi") %></td>
                    <td><%# Eval("Durum") %></td>
                    <td>
                        <asp:LinkButton ID="lbnt_banla" runat="server" tittle="Banla" CommandName="banla" CommandArgument='<%# Eval("ID") %>'><img src="Resimler/ban.png" /></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

    </div>
</asp:Content>
