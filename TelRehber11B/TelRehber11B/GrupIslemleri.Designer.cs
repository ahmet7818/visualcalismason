namespace TelRehber11B
{
    partial class GrupIslemleri
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtGrupAd = new System.Windows.Forms.TextBox();
            this.txtGrupAciklama = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgwGrupTablosu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGrupTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(143, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGrupAd
            // 
            this.txtGrupAd.Location = new System.Drawing.Point(143, 68);
            this.txtGrupAd.Name = "txtGrupAd";
            this.txtGrupAd.Size = new System.Drawing.Size(223, 20);
            this.txtGrupAd.TabIndex = 1;
            // 
            // txtGrupAciklama
            // 
            this.txtGrupAciklama.Location = new System.Drawing.Point(143, 108);
            this.txtGrupAciklama.Name = "txtGrupAciklama";
            this.txtGrupAciklama.Size = new System.Drawing.Size(223, 20);
            this.txtGrupAciklama.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgwGrupTablosu
            // 
            this.dgwGrupTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGrupTablosu.Location = new System.Drawing.Point(91, 210);
            this.dgwGrupTablosu.Name = "dgwGrupTablosu";
            this.dgwGrupTablosu.Size = new System.Drawing.Size(445, 211);
            this.dgwGrupTablosu.TabIndex = 5;
            this.dgwGrupTablosu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGrupTablosu_CellClick);
            this.dgwGrupTablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGrupTablosu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grup Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grup Açıklama:";
            // 
            // GrupIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwGrupTablosu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGrupAciklama);
            this.Controls.Add(this.txtGrupAd);
            this.Controls.Add(this.btnEkle);
            this.Name = "GrupIslemleri";
            this.Text = "GrupIslemleri";
            this.Load += new System.EventHandler(this.GrupIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGrupTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtGrupAd;
        private System.Windows.Forms.TextBox txtGrupAciklama;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgwGrupTablosu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}