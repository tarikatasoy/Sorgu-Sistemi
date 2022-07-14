<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KayitEkle.aspx.cs" Inherits="Tarik_Cin.KayitEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <br>

    <div class="row">
       <div class="col-md-4" ">
           Kullanıcı Adı:
       </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox1" runat="server" Class="form-control"></asp:TextBox>

       </div>
    
    </div>

     <div class="row">
       <div class="col-md-4" ">
           Şifre:
       </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox2" runat="server" Class="form-control"></asp:TextBox>

       </div>
    
    </div>
     <div class="row">
       <div class="col-md-4" ">
           Ad:
       </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox3" runat="server" Class="form-control"></asp:TextBox>

       </div>
    
    </div>

     <div class="row">
       <div class="col-md-4" ">
           Soyad:
       </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox4" runat="server" Class="form-control"></asp:TextBox>

       </div>
    
    </div>
     <div class="row">
       <div class="col-md-4" ">
           Bölüm:
       </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox5" runat="server" Class="form-control"></asp:TextBox>

       </div>
    
    </div> <div class="row">
       <div class="col-md-4" ">
           Doğum Tarihi:
       </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox6" runat="server" Class="form-control"></asp:TextBox>

       </div>
    
    </div> <div class="row">
       <div class="col-md-4" ">
           Şehir:
       </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox7" runat="server" Class="form-control"></asp:TextBox>

       </div>
    
    </div>
    <br />

     <div class="row">
       <div class="col-md-4" ">
           
       </div>
        <div class="col-md-4">
            <asp:Button ID="Button1" runat="server" Text="Kayıt Ekle" class="btn btn-success" Height="52px" Width="143px" OnClick="Button1_Click" BackColor="Black"/>

           
               
           

       </div>
    
    </div>
</asp:Content>
