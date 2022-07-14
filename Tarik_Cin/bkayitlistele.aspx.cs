using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Tarik_Cin
{
    public partial class bkayitlistele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] == null)
                Response.Redirect("Login.aspx");
            else
            {
                OleDbConnection user_conn = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + Server.MapPath("App_Data\\veritabani.mdb"));
                OleDbCommand komut = new OleDbCommand("SELECT kullanici_adi,ad,soyad,bolum,dogum_tarihi,sehir  FROM kullanici ", user_conn);
                

                user_conn.Open();

                OleDbDataReader oku = komut.ExecuteReader();
                GridView1.DataSource = oku;
                GridView1.DataBind();
                user_conn.Close();
            }
        }
    }
}