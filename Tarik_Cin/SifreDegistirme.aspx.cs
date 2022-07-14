using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace Tarik_Cin
{
    public partial class SifreDegistirme : System.Web.UI.Page
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
            if (TextBox1.Text == TextBox2.Text)
            {
                OleDbConnection user_conn = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + Server.MapPath("App_Data\\veritabani.mdb"));
                user_conn.Open();
                OleDbCommand komut = new OleDbCommand("update kullanici Set sifre='" + TextBox1.Text + "'" + " where kullanici_adi='" + Session["kullanici_adi"] + "'", user_conn);
                komut.ExecuteNonQuery();
                user_conn.Close();
                Label1.Text = ("ŞİFRENİZ BAŞARIYLA DEĞİŞTİRİLDİ.");
            }
            else
            {
                Label1.Text = ("HATALI ŞİFRE GİRDİNİZ... LÜTFEN KONTROL EDİNİZ");
            }
        }
    }
}
