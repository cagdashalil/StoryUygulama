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
    public partial class TaskDetay : Form
    {
        VeritabaniIslemleri veriTabani = new VeritabaniIslemleri();
        public TaskDetay()
        {
            InitializeComponent();
        }

        private void TaskDetay_Load(object sender, EventArgs e)
        {
            int gelen = Form1.gonderilecekveri;
            DataSet bilgi=veriTabani.VeriCek("SELECT * FROM TaskTable WHERE Task_ID='"+gelen+"'");
            lblBaslik.Text +=" "+ bilgi.Tables[0].Rows[0]["Task_Basligi"].ToString();
            lblKategori.Text +=" "+ bilgi.Tables[0].Rows[0]["Kategori_Bilgisi"].ToString();
            lblGorevli.Text +=" "+ bilgi.Tables[0].Rows[0]["Task_Gorevlisi"].ToString();
            lblIcerik.Text +=" "+ bilgi.Tables[0].Rows[0]["Task_Icerigi"].ToString();
        }
    }
}
