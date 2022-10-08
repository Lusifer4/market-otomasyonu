namespace market_otomasyonu
{
    partial class FrmUrunListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListe));
            this.label6 = new System.Windows.Forms.Label();
            this.txtidara = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkatagori = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(634, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "İd Ara:";
            // 
            // txtidara
            // 
            this.txtidara.Location = new System.Drawing.Point(685, 53);
            this.txtidara.Name = "txtidara";
            this.txtidara.Size = new System.Drawing.Size(157, 20);
            this.txtidara.TabIndex = 55;
            this.txtidara.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(814, 453);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 23);
            this.btnSil.TabIndex = 54;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 331);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Enabled = false;
            this.txtfiyat.Location = new System.Drawing.Point(176, 234);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // txtkatagori
            // 
            this.txtkatagori.Enabled = false;
            this.txtkatagori.Location = new System.Drawing.Point(176, 268);
            this.txtkatagori.Name = "txtkatagori";
            this.txtkatagori.Size = new System.Drawing.Size(100, 20);
            this.txtkatagori.TabIndex = 63;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Enabled = false;
            this.txtmiktar.Location = new System.Drawing.Point(176, 200);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(100, 20);
            this.txtmiktar.TabIndex = 62;
            // 
            // txturunad
            // 
            this.txturunad.Enabled = false;
            this.txturunad.Location = new System.Drawing.Point(176, 166);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(100, 20);
            this.txturunad.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Ürün Katagorisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Ürün Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Ürün Adı";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(176, 132);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Ürün İd:";
            // 
            // FrmUrunListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(964, 544);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkatagori);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtidara);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Liste";
            this.Load += new System.EventHandler(this.FrmUrunListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidara;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkatagori;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
    }
}