namespace LibaryApplication
{
    partial class frm_KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KitapEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kitapadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ciltno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sayfasayısı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_basımyılı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_yayınevi = new System.Windows.Forms.TextBox();
            this.txt_baskısayısı = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.pic_kitapresim = new System.Windows.Forms.PictureBox();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_resimyukle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kitapresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabın Adı";
            // 
            // txt_kitapadı
            // 
            this.txt_kitapadı.Location = new System.Drawing.Point(70, 184);
            this.txt_kitapadı.Name = "txt_kitapadı";
            this.txt_kitapadı.Size = new System.Drawing.Size(135, 20);
            this.txt_kitapadı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cilt No";
            // 
            // txt_ciltno
            // 
            this.txt_ciltno.Location = new System.Drawing.Point(70, 247);
            this.txt_ciltno.Name = "txt_ciltno";
            this.txt_ciltno.Size = new System.Drawing.Size(135, 20);
            this.txt_ciltno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // txt_sayfasayısı
            // 
            this.txt_sayfasayısı.Location = new System.Drawing.Point(70, 317);
            this.txt_sayfasayısı.Name = "txt_sayfasayısı";
            this.txt_sayfasayısı.Size = new System.Drawing.Size(135, 20);
            this.txt_sayfasayısı.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Basım Yılı";
            // 
            // txt_basımyılı
            // 
            this.txt_basımyılı.Location = new System.Drawing.Point(70, 380);
            this.txt_basımyılı.Name = "txt_basımyılı";
            this.txt_basımyılı.Size = new System.Drawing.Size(135, 20);
            this.txt_basımyılı.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(223, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazar";
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(260, 184);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(135, 20);
            this.txt_yazar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(223, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yayınevi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(223, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Baskı Sayısı";
            // 
            // txt_yayınevi
            // 
            this.txt_yayınevi.Location = new System.Drawing.Point(260, 317);
            this.txt_yayınevi.Name = "txt_yayınevi";
            this.txt_yayınevi.Size = new System.Drawing.Size(135, 20);
            this.txt_yayınevi.TabIndex = 1;
            // 
            // txt_baskısayısı
            // 
            this.txt_baskısayısı.Location = new System.Drawing.Point(260, 247);
            this.txt_baskısayısı.Name = "txt_baskısayısı";
            this.txt_baskısayısı.Size = new System.Drawing.Size(135, 20);
            this.txt_baskısayısı.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(223, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kitabın Resmi";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(260, 380);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(135, 20);
            this.FileName.TabIndex = 1;
            // 
            // pic_kitapresim
            // 
            this.pic_kitapresim.Location = new System.Drawing.Point(568, 60);
            this.pic_kitapresim.Name = "pic_kitapresim";
            this.pic_kitapresim.Size = new System.Drawing.Size(174, 221);
            this.pic_kitapresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_kitapresim.TabIndex = 2;
            this.pic_kitapresim.TabStop = false;
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.BackColor = System.Drawing.Color.Green;
            this.btn_kitapEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kitapEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitapEkle.ForeColor = System.Drawing.Color.White;
            this.btn_kitapEkle.Location = new System.Drawing.Point(562, 348);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(185, 71);
            this.btn_kitapEkle.TabIndex = 3;
            this.btn_kitapEkle.Text = "Kitap Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = false;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(562, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_resimyukle
            // 
            this.btn_resimyukle.Location = new System.Drawing.Point(401, 380);
            this.btn_resimyukle.Name = "btn_resimyukle";
            this.btn_resimyukle.Size = new System.Drawing.Size(75, 20);
            this.btn_resimyukle.TabIndex = 5;
            this.btn_resimyukle.Text = "Resim Yükle";
            this.btn_resimyukle.UseVisualStyleBackColor = true;
            this.btn_resimyukle.Click += new System.EventHandler(this.btn_resimyukle_Click);
            // 
            // frm_KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(857, 534);
            this.Controls.Add(this.btn_resimyukle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kitapEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_kitapresim);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_basımyılı);
            this.Controls.Add(this.txt_baskısayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_yayınevi);
            this.Controls.Add(this.txt_ciltno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sayfasayısı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_kitapadı);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "frm_KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_KitapEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pic_kitapresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kitapadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ciltno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sayfasayısı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_basımyılı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_yayınevi;
        private System.Windows.Forms.TextBox txt_baskısayısı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.PictureBox pic_kitapresim;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_resimyukle;
    }
}