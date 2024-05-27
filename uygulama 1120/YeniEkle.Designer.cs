namespace uygulama_1120
{
    partial class YeniEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.cbEngel = new System.Windows.Forms.CheckBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgwHayvanlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(460, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(129, 103);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "hayvan_adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "yas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "cins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "fotoğraf_adi";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(114, 27);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 7;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(114, 54);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 8;
            // 
            // cmbCins
            // 
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Location = new System.Drawing.Point(114, 91);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(121, 21);
            this.cmbCins.TabIndex = 9;
            // 
            // cbEngel
            // 
            this.cbEngel.AutoSize = true;
            this.cbEngel.Location = new System.Drawing.Point(36, 130);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(93, 17);
            this.cbEngel.TabIndex = 10;
            this.cbEngel.Text = "engel_durumu";
            this.cbEngel.UseVisualStyleBackColor = true;
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbResim.Location = new System.Drawing.Point(310, 43);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(125, 177);
            this.pbResim.TabIndex = 1;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(20, 197);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "arama";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(114, 199);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(121, 20);
            this.txtAra.TabIndex = 12;
            // 
            // dgwHayvanlar
            // 
            this.dgwHayvanlar.AllowUserToAddRows = false;
            this.dgwHayvanlar.AllowUserToDeleteRows = false;
            this.dgwHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHayvanlar.Location = new System.Drawing.Point(53, 275);
            this.dgwHayvanlar.Name = "dgwHayvanlar";
            this.dgwHayvanlar.ReadOnly = true;
            this.dgwHayvanlar.Size = new System.Drawing.Size(240, 150);
            this.dgwHayvanlar.TabIndex = 13;
            // 
            // YeniEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwHayvanlar);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbEngel);
            this.Controls.Add(this.cmbCins);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnEkle);
            this.Name = "YeniEkle";
            this.Text = "YeniEkle";
            this.Load += new System.EventHandler(this.YeniEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.CheckBox cbEngel;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgwHayvanlar;
    }
}