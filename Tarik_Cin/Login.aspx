<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tarik_Cin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

     <div class="row">
        <div class="col-md-4">
            Kullanıcı Adı:
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox1"  class="form-control" runat="server" ></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            Şifre:
        </div>
        <div class="col-md-4">

            <asp:TextBox ID="TextBox2"  class="form-control" runat="server" TextMode="Password"></asp:TextBox>
              <br />

         <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    </div>
     <div class="row">
         <asp:Button ID="Button1" runat="server" Text="GİRİŞ YAP" Class="btn btn-success" Height="39px" OnClick="Button1_Click" Width="157px" BackColor="Black" />
       
         </div>
</asp:Content>
