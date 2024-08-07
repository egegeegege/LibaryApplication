namespace LibaryApplication
{
    partial class frm_YoneticiPanel
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
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_kitapEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kitapEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitapEkle.ForeColor = System.Drawing.Color.White;
            this.btn_kitapEkle.Location = new System.Drawing.Point(99, 146);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(185, 71);
            this.btn_kitapEkle.TabIndex = 1;
            this.btn_kitapEkle.Text = "Kitap Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = false;
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.BackColor = System.Drawing.Color.Transparent;
            this.btn_kitaplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kitaplar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitaplar.ForeColor = System.Drawing.Color.White;
            this.btn_kitaplar.Location = new System.Drawing.Point(99, 329);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(185, 71);
            this.btn_kitaplar.TabIndex = 1;
            this.btn_kitaplar.Text = "Mevcut Kitaplar";
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            // 
            // frm_YoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibaryApplication.Properties.Resources._1641467553_70_www_funnyart_club_p_foni_s_knigami_76;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 582);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.btn_kitapEkle);
            this.Name = "frm_YoneticiPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_YoneticiPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.Button btn_kitaplar;
    }
}