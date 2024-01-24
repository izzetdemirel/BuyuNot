<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ReddedilenYorumlar.aspx.cs" Inherits="BuyuNot.AdminPanel.ReddedilenYorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="listetasiyici">
        <div class="listebaslik">
            <h2>Yorumların Listesi</h2>
        </div>
        <br />
        <br />
        <a href='OnaylananYorum.aspx?yorumid=<%# Eval("ID") %>'>Onaylananlar</a>
        <a href='ReddedilenYorumlar.aspx?yorumid=<%# Eval("ID") %>'>Reddedilenler</a>
        <br />
        <br />
        <br />
        <asp:ListView ID="lv_yorumlar" runat="server" OnItemCommand="lv_yorumlar_ItemCommand">
            <LayoutTemplate>
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <th>ID</th>
                        <th>Not</th>
                        <th>Üye</th>
                        <th>İçerik</th>
                        <th>Tarih</th>
                        <th>Durum</th>
                        <th width="20%">Seçenekler</th>
                    </tr>
                    <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Notlar") %></td>
                    <td><%# Eval("Uye") %></td>
                    <td><%# Eval("Icerik") %></td>
                    <td><%# Eval("YorumTarihi") %></td>
                    <td><%# Eval("Durum") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_onayla" runat="server" CommandName="onayla" CommandArgument='<%# Eval("ID") %>'><img src="Resimler/accept.png" /></asp:LinkButton>
                        <asp:LinkButton ID="lbtn_sil" runat="server" CommandName="sil" CommandArgument='<%# Eval("ID") %>'><img src="Resimler/delete.png" /></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
