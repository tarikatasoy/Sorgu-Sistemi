<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sorgulistele.aspx.cs" Inherits="Tarik_Cin.sorgulistele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
    <br />
    

    <div class="row">
        <div class="col-md-3">
            <h4>SORGULANACAK BÖLÜM:</h4>  
               </div>

        <div class="col-md-4">
            <asp:DropDownList ID="DropDownList1"  class="form-control" runat="server">
                <asp:ListItem Value="none">---SORGULAMA İÇİN DEĞER SEÇİNİZ---</asp:ListItem>
                <asp:ListItem>Kullanıcı Adı</asp:ListItem>
                <asp:ListItem>Ad</asp:ListItem>
                <asp:ListItem>Soyad</asp:ListItem>
                <asp:ListItem>Bölüm</asp:ListItem>               
            </asp:DropDownList>
        </div>
    </div>
        <div class="row">
         <div class="col-md-3">
            <h4>SORGULAMA İÇİN DEĞER GİRİNİZ:</h4>  
               </div>
        <div class="col-md-4">
            <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
        </div>
    </div>

         <div class="row">
             <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="SORGULAMAK İÇİN TIKLAYINIZ" Height="58px" Width="326px" OnClick="Button1_Click" BackColor="Black" /> 
         </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" class="table table-bordered" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Medium" Visible="false"></asp:Label>
</asp:Content>
