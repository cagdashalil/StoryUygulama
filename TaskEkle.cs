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
    public partial class TaskEkle : Form
    {
        VeritabaniIslemleri VeriTabani = new VeritabaniIslemleri();
        public TaskEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TaskEkle_Load(object sender, EventArgs e)
        {
            DataTable gelen=VeriTabani.VeriCekDt("SELECT Gorevli_Id, Gorevli_Adi FROM Gorevliler");
            comboBoxGorevli.DataSource = gelen;
            comboBoxGorevli.ValueMember = "Gorevli_Adi";
            comboBoxGorevli.DisplayMember = "Gorevli_Adi";


        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if(Form1.gonderilecekveri==1)
            {     
                VeriTabani.Ekle("INSERT INTO TaskTable (Story_ID, Task_Basligi, Kategori_Bilgisi, Task_Gorevlisi, Task_Icerigi) VALUES ('"+ "1" +"', '" + txtTaskBasligi.Text.Trim() + "', '" + txtTaskTuru.Text.Trim() + "' , '" + comboBoxGorevli.SelectedValue.ToString() + "', '" + txtTaskIcerik.Text.Trim() + "')");
                Application.Restart();
            }
            else if(Form1.gonderilecekveri==2)
            {
                VeriTabani.Ekle("INSERT INTO TaskTable (Story_ID, Task_Basligi, Kategori_Bilgisi, Task_Gorevlisi, Task_Icerigi) VALUES ('" + "2" + "', '" + txtTaskBasligi.Text.Trim() + "', '" + txtTaskTuru.Text.Trim() + "' , '" + comboBoxGorevli.SelectedValue.ToString() + "', '" + txtTaskIcerik.Text.Trim() + "')");
                Application.Restart();
            }
        }
    }
}
