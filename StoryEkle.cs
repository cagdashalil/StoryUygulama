using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryUygulama
{
    public partial class StoryEkle : Form
    {
        VeritabaniIslemleri veriTabani = new VeritabaniIslemleri();

        public StoryEkle()
        {
            InitializeComponent();
        }

        private void StoryEkle_Load(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime();
            tarih = DateTime.Now.Date;
            txtStoryBasTarihi.Text = tarih.ToString().TrimEnd('0', ':');
        }

        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO StoryTable (Story_Adi, Story_Bilgisi, Story_Baslangic_Tarihi) VALUES ('" + txtStoryAdi.Text.Trim() + "', '" + txtStoryBilgisi.Text.Trim() +"', '" + txtStoryBasTarihi.Text.Trim() +"')";
            veriTabani.Ekle(sorgu);
            Application.Restart();
        }
    }
}
