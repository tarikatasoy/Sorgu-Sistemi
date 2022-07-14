using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Tarik_Cin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = TextBox1.Text;
            string sifre = TextBox2.Text;
            OleDbConnection user_conn = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + Server.MapPath("App_Data\\veritabani.mdb"));
            string str = "SELECT * FROM kullanici WHERE kullanici_adi ='" + kullanici_adi + "' and sifre ='" + sifre + "'";
            OleDbCommand komut = new OleDbCommand(str, user_conn);

            user_conn.Open();


            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                Session["kullanici_adi"] = oku["kullanici_adi"].ToString();
                Label1.Visible = false;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "GİRİŞ BAŞARISIZ";
            }

            oku.Close();
            user_conn.Close();
        }
    }
}