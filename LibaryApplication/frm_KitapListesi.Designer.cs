namespace LibaryApplication
{
    partial class frm_KitapListesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_KitapListesi = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_gıncelle = new System.Windows.Forms.Button();
            this.txt_no = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(423, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitaplar";
            // 
            // dgv_KitapListesi
            // 
            this.dgv_KitapListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KitapListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_KitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KitapListesi.Location = new System.Drawing.Point(91, 112);
            this.dgv_KitapListesi.Name = "dgv_KitapListesi";
            this.dgv_KitapListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KitapListesi.Size = new System.Drawing.Size(842, 431);
            this.dgv_KitapListesi.TabIndex = 2;
            this.dgv_KitapListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_KitapListesi_CellMouseClick);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(718, 58);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_gıncelle
            // 
            this.btn_gıncelle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_gıncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gıncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gıncelle.ForeColor = System.Drawing.Color.White;
            this.btn_gıncelle.Location = new System.Drawing.Point(799, 58);
            this.btn_gıncelle.Name = "btn_gıncelle";
            this.btn_gıncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_gıncelle.TabIndex = 4;
            this.btn_gıncelle.Text = "Güncelle";
            this.btn_gıncelle.UseVisualStyleBackColor = false;
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(160, 40);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(100, 20);
            this.txt_no.TabIndex = 5;
            // 
            // frm_KitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 582);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.btn_gıncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_KitapListesi);
            this.Name = "frm_KitapListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_KitapListesi";
            this.Load += new System.EventHandler(this.frm_KitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_KitapListesi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_gıncelle;
        private System.Windows.Forms.TextBox txt_no;
    }
}