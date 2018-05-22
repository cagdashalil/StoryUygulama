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
    public partial class Form1 : Form
    {
        VeritabaniIslemleri VeriTabani = new VeritabaniIslemleri();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(btnTaskEkle1, "Task Ekle");
            Aciklama.SetToolTip(btnTaskEkle2, "Task Ekle");
            Aciklama.SetToolTip(btnTaskEkle3, "Task Ekle");
            Aciklama.SetToolTip(btnTaskEkle4, "Task Ekle");
            Aciklama.SetToolTip(listBox1, "Ayrıntı İçin Çift Tıklayınız");

            DataTable gelen = VeriTabani.VeriCekDt("SELECT Task_Basligi FROM TaskTable WHERE Story_ID=1 and Kategori_Bilgisi='NOT STARTED'"); 
            listBox1.DataSource = gelen;
            listBox1.ValueMember = "Task_Basligi";
            listBox1.DisplayMember = "Task_Basligi";
            

            DataTable gelen2 = VeriTabani.VeriCekDt("SELECT Task_Basligi FROM TaskTable WHERE Story_ID=1 and Kategori_Bilgisi='IN PROGRESS'");
            listBox2.DataSource = gelen2;
            listBox2.ValueMember = "Task_Basligi";
            listBox2.DisplayMember = "Task_Basligi";

            DataTable gelen3 = VeriTabani.VeriCekDt("SELECT Task_Basligi FROM TaskTable WHERE Story_ID=1 and Kategori_Bilgisi='DONE'");
            listBox3.DataSource = gelen3;
            listBox3.ValueMember = "Task_Basligi";
            listBox3.DisplayMember = "Task_Basligi";

            DataTable gelen7 = VeriTabani.VeriCekDt("SELECT Task_Basligi FROM TaskTable WHERE Story_ID=2 and Kategori_Bilgisi='NOT STARTED'");
            listBox4.DataSource = gelen7;
            listBox4.ValueMember = "Task_Basligi";
            listBox4.DisplayMember = "Task_Basligi";

            DataTable gelen5 = VeriTabani.VeriCekDt("SELECT Task_Basligi FROM TaskTable WHERE Story_ID=2 and Kategori_Bilgisi='IN PROGRESS'");
            listBox5.DataSource = gelen5;
            listBox5.ValueMember = "Task_Basligi";
            listBox5.DisplayMember = "Task_Basligi";

            DataTable gelen6 = VeriTabani.VeriCekDt("SELECT Task_Basligi FROM TaskTable WHERE Story_ID=2 and Kategori_Bilgisi='DONE'");
            listBox6.DataSource = gelen6;
            listBox6.ValueMember = "Task_Basligi";
            listBox6.DisplayMember = "Task_Basligi";

            DataSet gelen1 = VeriTabani.VeriCek("SELECT Story_Adi FROM StoryTable WHERE Story_ID=1");
            if((gelen1.Tables[0].Rows.Count)>0)
            { 
            txtStory1.Text ="Story Adı: "+ gelen1.Tables[0].Rows[0]["Story_Adi"].ToString();
            }

            DataSet gelen4 = VeriTabani.VeriCek("SELECT Story_Adi FROM StoryTable WHERE Story_ID=2");
            if ((gelen4.Tables[0].Rows.Count) > 0)
            {
                txtStory2.Text = "Story Adı: " + gelen4.Tables[0].Rows[0]["Story_Adi"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int gonderilecekveri;
        public static string secilen;

        private void btnGorevliEkle_Click(object sender, EventArgs e)
        {
            GorevliEkle FrmGorevliEkle = new GorevliEkle();
            FrmGorevliEkle.Show();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            StoryEkle FrmStoryEkle = new StoryEkle();
            FrmStoryEkle.Show();
        }

        private void btnTaskEkle1_Click(object sender, EventArgs e)
        {
            gonderilecekveri = 1;
            TaskEkle TaskEkle = new TaskEkle();
            TaskEkle.Show();

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            secilen = listBox1.SelectedValue.ToString();

            //int al = listBox1.SelectedIndex;

            //DataSet ds = VeriTabani.VeriCek("SELECT * FROM TaskTable WHERE Task_Basligi='" + secilen + "'");
            //lblBaslik.Text += ds.Tables[0].Rows[0]["Task_Basligi"].ToString();
            //lblGorevli.Text += ds.Tables[0].Rows[0]["Task_Gorevlisi"].ToString();
            //lblIcerik.Text += ds.Tables[0].Rows[0]["Task_Icerigi"].ToString();

            if (e.Button==MouseButtons.Left)
            {
                listBox1.DoDragDrop(secilen,DragDropEffects.All);
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if(e.KeyState==1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            VeriTabani.Guncelle("update TaskTable set Kategori_Bilgisi='IN PROGRESS' where Task_Basligi='"+secilen.ToString()+"'and Story_ID=1");
            Application.Restart();    
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gonderilecekveri = listBox1.SelectedIndex+1;
            TaskDetay taskDetay = new TaskDetay();
            taskDetay.Show();
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            secilen = listBox2.SelectedValue.ToString();

            if (e.Button == MouseButtons.Left)
            {
                listBox1.DoDragDrop(secilen, DragDropEffects.All);
            }
        }

        private void listBox3_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            VeriTabani.Guncelle("update TaskTable set Kategori_Bilgisi='DONE' where Task_Basligi='" + secilen.ToString() + "'and Story_ID=1");
            Application.Restart();
        }


        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {
            secilen = listBox4.SelectedValue.ToString();
            //int al = listBox1.SelectedIndex;

            DataSet ds = VeriTabani.VeriCek("SELECT * FROM TaskTable WHERE Task_Basligi='" + secilen + "'");
            lblBaslik.Text += ds.Tables[0].Rows[0]["Task_Basligi"].ToString();
            lblGorevli.Text += ds.Tables[0].Rows[0]["Task_Gorevlisi"].ToString();
            lblIcerik.Text += ds.Tables[0].Rows[0]["Task_Icerigi"].ToString();

            if (e.Button == MouseButtons.Left)
            {
                listBox4.DoDragDrop(secilen, DragDropEffects.All);
            }
        }

        private void listBox5_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox5_DragDrop(object sender, DragEventArgs e)
        {
            VeriTabani.Guncelle("update TaskTable set Kategori_Bilgisi='IN PROGRESS' where Task_Basligi='" + secilen.ToString() + "'and Story_ID=2");
            Application.Restart();
        }

        private void listBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gonderilecekveri = listBox1.SelectedIndex + 1;
            TaskDetay taskDetay = new TaskDetay();
            taskDetay.Show();
        }

        private void listBox5_MouseDown(object sender, MouseEventArgs e)
        {
            secilen = listBox5.SelectedValue.ToString();

            if (e.Button == MouseButtons.Left)
            {
                listBox3.DoDragDrop(secilen, DragDropEffects.All);
            }
        }

        private void listBox6_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox6_DragDrop(object sender, DragEventArgs e)
        {
            VeriTabani.Guncelle("update TaskTable set Kategori_Bilgisi='DONE' where Task_Basligi='" + secilen.ToString() + "'and Story_ID=2");
            Application.Restart();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void btnTaskEkle2_Click(object sender, EventArgs e)
        {
            gonderilecekveri = 2;
            TaskEkle TaskEkle = new TaskEkle();
            TaskEkle.Show();
        }
    }
}
