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
    public partial class GorevliEkle : Form
    {
        VeritabaniIslemleri veriTabanı = new VeritabaniIslemleri();
        public GorevliEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu= "INSERT INTO Gorevliler (Gorevli_Adi,Gorevli_Soyadi) VALUES ('"+txtAdi.Text.Trim() + "','" + txtSoyadi.Text.Trim()+ "')";
            veriTabanı.Ekle(sorgu);
        }

        private void GorevliEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
