<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="KategoriListele.aspx.cs" Inherits="BuyuNot.AdminPanel.KategoriListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Liste.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="listetasiyici">
        <div class="listebaslik">
            <h3>Kategoriler</h3>
        </div>
        <div class="listeicerik">
            <asp:ListView ID="lv_kategoriler" runat="server"
                OnItemCommand="lv_kategoriler_ItemCommand">
                <LayoutTemplate>
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <th>ID</th>
                            <th>Isim</th>
                            <th>Durum</th>
                            <th width="20%">Seçenekler</th>
                        </tr>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("Isim") %></td>
                        <td><%# Eval("Durum") %></td>
                        <td>
                            <a href='KategoriDuzenle.aspx?kid=<%# Eval("ID") %>' title="Düzenle">
                                <img src="Resimler/edit.png" />
                            </a>
                            <asp:LinkButton ID="lbtn_durum"
                                CommandName="durum" CommandArgument='<%# Eval("ID") %>'><img src="Resimler/recycle.png" />
                            </asp:LinkButton>
                            <asp:LinkButton ID="lbtn_sil" runat="server"
                                title="sil" CommandName="sil" CommandArgument='<%# Eval("ID") %>'><img src="Resimler/delete.png" />
                            </asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
                </asp:ListView>
        </div>
    </div>
</asp:Content>
