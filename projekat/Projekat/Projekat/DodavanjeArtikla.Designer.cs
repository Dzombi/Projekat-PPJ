namespace WindowsFormsApplication1
{
    partial class DodavanjeArtikla
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
            this.textBoxTražiŠifra = new System.Windows.Forms.TextBox();
            this.textBoxTražiNaziv = new System.Windows.Forms.TextBox();
            this.textBoxNazivArtikla = new System.Windows.Forms.TextBox();
            this.textBoxVrstaArtikla = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxKoličina = new System.Windows.Forms.TextBox();
            this.textBoxIDArtikla = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodavanjeArtikla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAžuriranjeArtikla = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonDodajKoličinu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTražiŠifra
            // 
            this.textBoxTražiŠifra.Location = new System.Drawing.Point(12, 13);
            this.textBoxTražiŠifra.Name = "textBoxTražiŠifra";
            this.textBoxTražiŠifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxTražiŠifra.TabIndex = 0;
            this.textBoxTražiŠifra.TextChanged += new System.EventHandler(this.textBoxTražiŠifra_TextChanged);
            // 
            // textBoxTražiNaziv
            // 
            this.textBoxTražiNaziv.Location = new System.Drawing.Point(118, 12);
            this.textBoxTražiNaziv.Name = "textBoxTražiNaziv";
            this.textBoxTražiNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxTražiNaziv.TabIndex = 1;
            this.textBoxTražiNaziv.TextChanged += new System.EventHandler(this.textBoxTražiNaziv_TextChanged);
            // 
            // textBoxNazivArtikla
            // 
            this.textBoxNazivArtikla.Location = new System.Drawing.Point(92, 207);
            this.textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            this.textBoxNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivArtikla.TabIndex = 2;
            // 
            // textBoxVrstaArtikla
            // 
            this.textBoxVrstaArtikla.Location = new System.Drawing.Point(92, 233);
            this.textBoxVrstaArtikla.Name = "textBoxVrstaArtikla";
            this.textBoxVrstaArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxVrstaArtikla.TabIndex = 3;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(92, 259);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 4;
            // 
            // textBoxKoličina
            // 
            this.textBoxKoličina.Location = new System.Drawing.Point(92, 290);
            this.textBoxKoličina.Name = "textBoxKoličina";
            this.textBoxKoličina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKoličina.TabIndex = 5;
            // 
            // textBoxIDArtikla
            // 
            this.textBoxIDArtikla.Location = new System.Drawing.Point(332, 233);
            this.textBoxIDArtikla.Name = "textBoxIDArtikla";
            this.textBoxIDArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDArtikla.TabIndex = 6;
            this.textBoxIDArtikla.TextChanged += new System.EventHandler(this.textBoxIDArtikla_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 153);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonDodavanjeArtikla
            // 
            this.buttonDodavanjeArtikla.Location = new System.Drawing.Point(71, 316);
            this.buttonDodavanjeArtikla.Name = "buttonDodavanjeArtikla";
            this.buttonDodavanjeArtikla.Size = new System.Drawing.Size(121, 34);
            this.buttonDodavanjeArtikla.TabIndex = 12;
            this.buttonDodavanjeArtikla.Text = "Dodavanje artikla";
            this.buttonDodavanjeArtikla.UseVisualStyleBackColor = true;
            this.buttonDodavanjeArtikla.Click += new System.EventHandler(this.buttonDodavanjeArtikla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Naziv artikla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vrsta artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID artikla:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dodaj količinu:";
            // 
            // buttonAžuriranjeArtikla
            // 
            this.buttonAžuriranjeArtikla.Location = new System.Drawing.Point(252, 316);
            this.buttonAžuriranjeArtikla.Name = "buttonAžuriranjeArtikla";
            this.buttonAžuriranjeArtikla.Size = new System.Drawing.Size(121, 34);
            this.buttonAžuriranjeArtikla.TabIndex = 21;
            this.buttonAžuriranjeArtikla.Text = "Ažuriranje artikla";
            this.buttonAžuriranjeArtikla.UseVisualStyleBackColor = true;
            this.buttonAžuriranjeArtikla.Click += new System.EventHandler(this.buttonAžuriranjeArtikla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(332, 280);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // buttonDodajKoličinu
            // 
            this.buttonDodajKoličinu.Location = new System.Drawing.Point(402, 316);
            this.buttonDodajKoličinu.Name = "buttonDodajKoličinu";
            this.buttonDodajKoličinu.Size = new System.Drawing.Size(121, 34);
            this.buttonDodajKoličinu.TabIndex = 23;
            this.buttonDodajKoličinu.Text = "Dodavanje količine";
            this.buttonDodajKoličinu.UseVisualStyleBackColor = true;
            this.buttonDodajKoličinu.Click += new System.EventHandler(this.buttonDodajKoličinu_Click);
            // 
            // DodavanjeArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 372);
            this.Controls.Add(this.buttonDodajKoličinu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAžuriranjeArtikla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodavanjeArtikla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxIDArtikla);
            this.Controls.Add(this.textBoxKoličina);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxVrstaArtikla);
            this.Controls.Add(this.textBoxNazivArtikla);
            this.Controls.Add(this.textBoxTražiNaziv);
            this.Controls.Add(this.textBoxTražiŠifra);
            this.Name = "DodavanjeArtikla";
            this.Text = "Dodavanje / Ažuriranje artikla";
            this.Load += new System.EventHandler(this.KreiranjeNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTražiŠifra;
        private System.Windows.Forms.TextBox textBoxTražiNaziv;
        private System.Windows.Forms.TextBox textBoxNazivArtikla;
        private System.Windows.Forms.TextBox textBoxVrstaArtikla;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxKoličina;
        private System.Windows.Forms.TextBox textBoxIDArtikla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodavanjeArtikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAžuriranjeArtikla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonDodajKoličinu;
    }
}