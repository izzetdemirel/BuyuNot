<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="PasifUyeler.aspx.cs" Inherits="BuyuNot.AdminPanel.PasifUyeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="listetasiyici">
        <div class="listebaslik">
            <h2>Üyelerin Listesi</h2>
        </div>
        <br />
        <br />
        <a href='AktifUyeler.aspx?uyeid=<%# Eval("ID") %>'>Aktif Üyeler</a>
        <a href='PasifUyeler.aspx?uyeid<%# Eval("ID") %>'>Pasif Üyeler</a>
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
                        <th>KayitTarihi</th>
                        <th>Durum</th>
                        <a href="https://localhost:44364/AdminPanel/PasifUyeler.aspx">https://localhost:44364/AdminPanel/PasifUyeler.aspx</a>
                    </tr>
                    <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
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
                    <td><%# Eval("Durum") %></td
                        <td>
                            <asp:LinkButton ID="lbtn_bankaldir" runat="server" CommandArgument='<%# Eval("ID") %>' CommandName="bankaldir"><img src="Resimler/accept.png" /></asp:LinkButton>
                        </td>>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
