using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryUygulama
{
    public class VeritabaniIslemleri
    {
        //SqlConnection baglanti = new SqlConnection("Data Source=37.230.108.253;Initial Catalog=Database1;User ID=atatekmedikal;Password=ask6aylo!");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SLMUQNF; Initial Catalog=ScrumTable; User Id=sa; password=cagdas1238halil;");

        public DataTable VeriCekDt(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public DataSet VeriCek(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds;
        }

        public void Ekle(string sorgu)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc > 0)
            {       
                MessageBox.Show("Bilgi Başarı İle Eklenmiştir.");
                baglanti.Close();
                GorevliEkle.ActiveForm.Close();       
            }
        }

        public void Guncelle(string sorgu)
        {
            baglanti.Open();
            SqlCommand cmd_update = new SqlCommand(sorgu, baglanti);
            int kntrl = cmd_update.ExecuteNonQuery();
            if (kntrl > 0)
            {
                MessageBox.Show("Kategori Değiştirildi");
                baglanti.Close();                
            }
        }
    }
}