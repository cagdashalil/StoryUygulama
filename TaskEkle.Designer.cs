namespace StoryUygulama
{
    partial class TaskEkle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskBasligi = new System.Windows.Forms.TextBox();
            this.txtTaskIcerik = new System.Windows.Forms.TextBox();
            this.txtTaskTuru = new System.Windows.Forms.TextBox();
            this.comboBoxGorevli = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoryUygulama.Properties.Resources.task;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 136);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(163, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Task Kategorisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(163, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Task Görevlisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task Başlığı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(163, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Task İçeriği:";
            // 
            // txtTaskBasligi
            // 
            this.txtTaskBasligi.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTaskBasligi.Location = new System.Drawing.Point(318, 30);
            this.txtTaskBasligi.Name = "txtTaskBasligi";
            this.txtTaskBasligi.Size = new System.Drawing.Size(124, 24);
            this.txtTaskBasligi.TabIndex = 10;
            // 
            // txtTaskIcerik
            // 
            this.txtTaskIcerik.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTaskIcerik.Location = new System.Drawing.Point(318, 73);
            this.txtTaskIcerik.Name = "txtTaskIcerik";
            this.txtTaskIcerik.Size = new System.Drawing.Size(124, 24);
            this.txtTaskIcerik.TabIndex = 10;
            // 
            // txtTaskTuru
            // 
            this.txtTaskTuru.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTaskTuru.Location = new System.Drawing.Point(322, 167);
            this.txtTaskTuru.Name = "txtTaskTuru";
            this.txtTaskTuru.ReadOnly = true;
            this.txtTaskTuru.Size = new System.Drawing.Size(120, 24);
            this.txtTaskTuru.TabIndex = 10;
            this.txtTaskTuru.Text = "NOT STARTED";
            // 
            // comboBoxGorevli
            // 
            this.comboBoxGorevli.FormattingEnabled = true;
            this.comboBoxGorevli.Location = new System.Drawing.Point(318, 125);
            this.comboBoxGorevli.Name = "comboBoxGorevli";
            this.comboBoxGorevli.Size = new System.Drawing.Size(124, 21);
            this.comboBoxGorevli.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Task Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaskEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxGorevli);
            this.Controls.Add(this.txtTaskTuru);
            this.Controls.Add(this.txtTaskIcerik);
            this.Controls.Add(this.txtTaskBasligi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TaskEkle";
            this.Text = "TaskEkle";
            this.Load += new System.EventHandler(this.TaskEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskBasligi;
        private System.Windows.Forms.TextBox txtTaskIcerik;
        private System.Windows.Forms.TextBox txtTaskTuru;
        private System.Windows.Forms.ComboBox comboBoxGorevli;
        private System.Windows.Forms.Button button1;
    }
}