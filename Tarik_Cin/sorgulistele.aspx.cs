using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Tarik_Cin
{
    public partial class sorgulistele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["kullanici_adi"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection user_conn = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + Server.MapPath("App_Data\\veritabani.mdb"));
            user_conn.Open();
            string sorgulama;
            OleDbCommand giris = new OleDbCommand();
            giris.Connection = user_conn;
            sorgulama = DropDownList1.SelectedValue;

            if (DropDownList1.SelectedItem.ToString() == "kullanici_adi")
            {
                giris.CommandText = "select kullanici_adi,ad,soyad,bolum,dogum_tarihi,sehir from kullanici where kullanici_adi='" + TextBox1.Text + "'";
                Label1.Visible = true;
                Label1.Text = "SORGULAMANIZ BAŞARIYLA GERÇEKLEŞTİRİLDİ.";

            }
            if (DropDownList1.SelectedItem.ToString() == "ad")
            {
                giris.CommandText = "select kullanici_adi,ad,soyad,bolum,dogum_tarihi,sehir from kullanici where adi like'%" + TextBox1.Text + "%'";
                Label1.Visible = true;
                Label1.Text = "SORGULAMANIZ BAŞARIYLA GERÇEKLEŞTİRİLDİ.";
            }
            if (DropDownList1.SelectedItem.ToString() == "soyad")
            {
                giris.CommandText = "select kullanici_adi,ad,soyad,bolum,dogum_tarihi,sehir from kullanici where soyadi like'%" + TextBox1.Text + "%'";
                Label1.Visible = true;
                Label1.Text = "SORGULAMANIZ BAŞARIYLA GERÇEKLEŞTİRİLDİ.";
            }
            if (DropDownList1.SelectedItem.ToString() == "bolum")
            {
                giris.CommandText = "select kullanici_adi,ad,soyad,bolum,dogum_tarihi,sehir from kullanici where bolumu like'%" + TextBox1.Text + "%'";
                Label1.Visible = true;
                Label1.Text = "SORGULAMANIZ BAŞARIYLA GERÇEKLEŞTİRİLDİ.";
            }
            GridView1.DataSource = giris.ExecuteReader();
            GridView1.DataBind();
            user_conn.Close();
        }
    }
}