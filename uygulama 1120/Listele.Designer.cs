namespace uygulama_1120
{
    partial class Listele
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwHayvanlar = new System.Windows.Forms.DataGridView();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cmbCinsi = new System.Windows.Forms.ComboBox();
            this.txtYeniYas = new System.Windows.Forms.TextBox();
            this.txtYeniİsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEngel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(581, 112);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(113, 77);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "guncelle ";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(581, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 77);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwHayvanlar
            // 
            this.dgwHayvanlar.AllowUserToAddRows = false;
            this.dgwHayvanlar.AllowUserToDeleteRows = false;
            this.dgwHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHayvanlar.Location = new System.Drawing.Point(64, 225);
            this.dgwHayvanlar.Name = "dgwHayvanlar";
            this.dgwHayvanlar.ReadOnly = true;
            this.dgwHayvanlar.Size = new System.Drawing.Size(553, 213);
            this.dgwHayvanlar.TabIndex = 2;
            this.dgwHayvanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHayvanlar_CellContentClick);
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbResim.Location = new System.Drawing.Point(399, 25);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(125, 177);
            this.pbResim.TabIndex = 3;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // cmbCinsi
            // 
            this.cmbCinsi.FormattingEnabled = true;
            this.cmbCinsi.Location = new System.Drawing.Point(105, 81);
            this.cmbCinsi.Name = "cmbCinsi";
            this.cmbCinsi.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsi.TabIndex = 15;
            // 
            // txtYeniYas
            // 
            this.txtYeniYas.Location = new System.Drawing.Point(105, 52);
            this.txtYeniYas.Name = "txtYeniYas";
            this.txtYeniYas.Size = new System.Drawing.Size(100, 20);
            this.txtYeniYas.TabIndex = 14;
            // 
            // txtYeniİsim
            // 
            this.txtYeniİsim.Location = new System.Drawing.Point(105, 25);
            this.txtYeniİsim.Name = "txtYeniİsim";
            this.txtYeniİsim.Size = new System.Drawing.Size(100, 20);
            this.txtYeniİsim.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "cins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "yas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "adi";
            // 
            // cbEngel
            // 
            this.cbEngel.AutoSize = true;
            this.cbEngel.Location = new System.Drawing.Point(64, 125);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(93, 17);
            this.cbEngel.TabIndex = 16;
            this.cbEngel.Text = "engel_durumu";
            this.cbEngel.UseVisualStyleBackColor = true;
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEngel);
            this.Controls.Add(this.cmbCinsi);
            this.Controls.Add(this.txtYeniYas);
            this.Controls.Add(this.txtYeniİsim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.dgwHayvanlar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "Listele";
            this.Text = "Listele";
            this.Load += new System.EventHandler(this.Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwHayvanlar;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ComboBox cmbCinsi;
        private System.Windows.Forms.TextBox txtYeniYas;
        private System.Windows.Forms.TextBox txtYeniİsim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEngel;
    }
}