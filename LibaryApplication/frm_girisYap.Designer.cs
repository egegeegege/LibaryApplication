namespace LibaryApplication
{
    partial class frm_girisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_girisYap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_kayitOl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_gmail
            // 
            this.txt_gmail.Location = new System.Drawing.Point(116, 226);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(176, 20);
            this.txt_gmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gmail";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(116, 277);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(176, 20);
            this.txt_sifre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_girisYap.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_girisYap.ForeColor = System.Drawing.Color.White;
            this.btn_girisYap.Location = new System.Drawing.Point(116, 364);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(162, 60);
            this.btn_girisYap.TabIndex = 3;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(116, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 37);
            this.panel1.TabIndex = 4;
            // 
            // link_kayitOl
            // 
            this.link_kayitOl.AutoSize = true;
            this.link_kayitOl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.link_kayitOl.Location = new System.Drawing.Point(153, 330);
            this.link_kayitOl.Name = "link_kayitOl";
            this.link_kayitOl.Size = new System.Drawing.Size(88, 13);
            this.link_kayitOl.TabIndex = 4;
            this.link_kayitOl.TabStop = true;
            this.link_kayitOl.Text = "Kayıt olmadınmı ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(394, 542);
            this.Controls.Add(this.link_kayitOl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_gmail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel link_kayitOl;
    }
}

