<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SifreDegistirme.aspx.cs" Inherits="Tarik_Cin.SifreDegistirme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <br />
    <div class="row">
        <div class="col-md-2">
             YENİ ŞİFRE
        </div>
        <div class ="col-md-4">
            <asp:TextBox ID="TextBox1" Class="form form-control" runat="server" TextMode="Password" BackColor="#666666" BorderColor="White" ForeColor="White"></asp:TextBox>
        </div>
        </div>
    <div class="row">
        <div class="col-md-2">
            YENİ ŞİFREYİ TEKRAR GİRİNİZ:
        </div>      
        <div class ="col-md-4">
            <asp:TextBox ID="TextBox2" Class="form form-control" runat="server" TextMode="Password" BackColor="White" ForeColor="Black"></asp:TextBox>
        </div>
        </div>
    <div class="row">
        <div class="col-md-2">

            </div>
        <div class="col-md-5">
            <asp:Button ID="Button1" Class="btn btn-success" runat="server" Text="Şifrenizi Güncellemek İçin Tıklayınız" OnClick="Button1_Click" Width="1050px" BackColor="Black"  />
        </div>
           
        </div>
        
    <br/>
    <asp:Label ID="Label1" runat="server" Font-Size="Medium" Enabled="False"></asp:Label>
      </div>
</asp:Content>
