namespace StoryUygulama
{
    partial class StoryEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStoryAdi = new System.Windows.Forms.TextBox();
            this.txtStoryBilgisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStoryBasTarihi = new System.Windows.Forms.TextBox();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStoryAdi
            // 
            this.txtStoryAdi.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtStoryAdi.Location = new System.Drawing.Point(296, 40);
            this.txtStoryAdi.Name = "txtStoryAdi";
            this.txtStoryAdi.Size = new System.Drawing.Size(120, 24);
            this.txtStoryAdi.TabIndex = 0;
            // 
            // txtStoryBilgisi
            // 
            this.txtStoryBilgisi.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtStoryBilgisi.Location = new System.Drawing.Point(296, 84);
            this.txtStoryBilgisi.Name = "txtStoryBilgisi";
            this.txtStoryBilgisi.Size = new System.Drawing.Size(120, 24);
            this.txtStoryBilgisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Story Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(163, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Story Bilgisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(163, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Story Başlangıç Tarihi";
            // 
            // txtStoryBasTarihi
            // 
            this.txtStoryBasTarihi.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtStoryBasTarihi.Location = new System.Drawing.Point(296, 156);
            this.txtStoryBasTarihi.Name = "txtStoryBasTarihi";
            this.txtStoryBasTarihi.ReadOnly = true;
            this.txtStoryBasTarihi.Size = new System.Drawing.Size(120, 24);
            this.txtStoryBasTarihi.TabIndex = 0;
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoryEkle.Location = new System.Drawing.Point(296, 186);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(120, 32);
            this.btnStoryEkle.TabIndex = 4;
            this.btnStoryEkle.Text = "Story Kaydet";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoryUygulama.Properties.Resources.add_27107_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 136);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // StoryEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStoryEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStoryBasTarihi);
            this.Controls.Add(this.txtStoryBilgisi);
            this.Controls.Add(this.txtStoryAdi);
            this.Name = "StoryEkle";
            this.Text = "Story Ekle";
            this.Load += new System.EventHandler(this.StoryEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStoryAdi;
        private System.Windows.Forms.TextBox txtStoryBilgisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStoryBasTarihi;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}