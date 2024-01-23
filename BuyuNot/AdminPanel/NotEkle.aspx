<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="NotEkle.aspx.cs" Inherits="BuyuNot.AdminPanel.NotEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Plugin/ckeditor/ckeditor.js"></script>
  <%-- burayıda sor--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formTasiyici">
        <div class="formBaslik">
            <h3>Not Ekle</h3>
        </div>
        <div class="formIcerik">
            <asp:Panel ID="pnl_hata" runat="server" CssClass="hatapanel" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
                Not Başarılı bir şekilde eklendi
            </asp:Panel>
            <div class="icerikSol">
                <div class="satir">
                    <label>Not Adı</label><br />
                    <asp:TextBox ID="tb_baslik" runat="server" CssClass="metinKutu"></asp:TextBox>
                </div>
                <div class="satir satirbosluk">
                    <label>Kategori Seçiniz</label><br />
                    <asp:DropDownList ID="ddl_kategoriler" runat="server" CssClass="metinKutu" DataTextField="Isim" DataValueField="ID" Style="width:97%"></asp:DropDownList>
                </div>
                <div class="satir satirbosluk">
                    <label>Özet</label><br />
                    <asp:TextBox ID="tb_ozet" runat="server" CssClass="metinKutu" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="satir satirbosluk">
                    <label>Durum</label><br />
                    <asp:CheckBox ID="cb_aktif" runat="server" Text="Aktif" TextAlign="Left" />
                </div>
            </div>
            <div class="icerikSag">
                <div class="satir">
                    <label>İçerik</label><br />
                    <asp:TextBox ID="tb_icerik" runat="server" TextMode="MultiLine" CssClass="metinKutu"></asp:TextBox>
                    <script>
                        
                    </script>
                </div>
                <div class="satir satirbosluk">
                    <asp:LinkButton ID="lbtn_kaydet" runat="server" CssClass="İslemButon" OnClick="lbtn_kaydet_Click">Not Ekle</asp:LinkButton>
                </div>
            </div>
            <div style="clear:both">
            </div>
        </div>
    </div>
</asp:Content>
