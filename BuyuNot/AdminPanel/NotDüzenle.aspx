<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="NotDüzenle.aspx.cs" Inherits="BuyuNot.AdminPanel.NotDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formTasiyici">
        <div class="formBaslik">
            <h3>Not Düzenle</h3>
        </div>
        <div class="formIcerik">
            <asp:Panel ID="pnl_hata" runat="server" CssClass="hatapanel" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
                Not başarılı bir şekilde düzenlendi
            </asp:Panel>
            <div class="satir">
                <label>Not Adı</label><br />
                <asp:TextBox ID="tb_baslik" runat="server"
                    CssClass="metinKutu"></asp:TextBox>
            </div>
            <div class ="satir">
                <label>Özet</label><br />
                <asp:TextBox ID="tb_ozet" runat="server"
                    CssClass="metinKutu"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:CheckBox ID="cb_durum" runat="server" /> Aktif Not
            </div>
            <div class="satir">
                <label>İçerik</label>
                <asp:TextBox ID="tb_icerik" runat="server" CssClass="metinKutu"></asp:TextBox>
            </div>
            <div class="satir satirbosluk">
                <asp:LinkButton ID="lbtn_duzenle" runat="server" CssClass="İslemButon" OnClick="lbtn_duzenle_Click">Not Düzenle</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
