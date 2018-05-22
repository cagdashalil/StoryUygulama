namespace StoryUygulama
{
    partial class TaskDetay
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
            this.lblGorevli = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGorevli
            // 
            this.lblGorevli.AutoSize = true;
            this.lblGorevli.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGorevli.Location = new System.Drawing.Point(12, 118);
            this.lblGorevli.Name = "lblGorevli";
            this.lblGorevli.Size = new System.Drawing.Size(142, 21);
            this.lblGorevli.TabIndex = 13;
            this.lblGorevli.Text = "Task Görevlisi:";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIcerik.Location = new System.Drawing.Point(12, 69);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(116, 21);
            this.lblIcerik.TabIndex = 11;
            this.lblIcerik.Text = "Task İçeriği:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(12, 163);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(153, 21);
            this.lblKategori.TabIndex = 12;
            this.lblKategori.Text = "Task Kategorisi:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(12, 26);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(127, 21);
            this.lblBaslik.TabIndex = 10;
            this.lblBaslik.Text = "Task Başlığı:";
            // 
            // TaskDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 233);
            this.Controls.Add(this.lblGorevli);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblBaslik);
            this.Name = "TaskDetay";
            this.Text = "TaskDetay";
            this.Load += new System.EventHandler(this.TaskDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGorevli;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblBaslik;
    }
}