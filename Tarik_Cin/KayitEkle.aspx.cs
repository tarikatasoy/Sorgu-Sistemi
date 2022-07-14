using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace Tarik_Cin
{
    public partial class KayitEkle : System.Web.UI.Page
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

            string str = "insert into kullanici(kullanici_adi,sifre,ad,soyad,bolum,dogum_tarihi,sehir) values('" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "','" + TextBox3.Text.ToString() + "','" + TextBox4.Text.ToString() + "','" + TextBox5.Text.ToString() + "','" + TextBox6.Text.ToString() + "','" + TextBox7.Text.ToString() + "')";
            OleDbCommand komut = new OleDbCommand(str, user_conn);
            komut.ExecuteNonQuery();
            user_conn.Close();


            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('KAYIT BAŞARI İLE EKLENDİ')", true);


        }
    }
}