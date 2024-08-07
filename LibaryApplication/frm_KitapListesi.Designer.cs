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
            this.dgv_KitapListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_KitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KitapListesi.Location = new System.Drawing.Point(112, 112);
            this.dgv_KitapListesi.Name = "dgv_KitapListesi";
            this.dgv_KitapListesi.Size = new System.Drawing.Size(806, 431);
            this.dgv_KitapListesi.TabIndex = 2;
            this.dgv_KitapListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_KitapListesi_CellMouseClick);
            // 
            // frm_KitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_KitapListesi);
            this.Name = "frm_KitapListesi";
            this.Text = "frm_KitapListesi";
            this.Load += new System.EventHandler(this.frm_KitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_KitapListesi;
    }
}