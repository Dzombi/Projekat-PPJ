namespace WindowsFormsApplication1
{
    partial class BrisanjeNarudžbe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDNarudzbe = new System.Windows.Forms.TextBox();
            this.buttonBrisanjeNarudžbe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID narudžbe:";
            // 
            // textBoxIDNarudzbe
            // 
            this.textBoxIDNarudzbe.Location = new System.Drawing.Point(94, 211);
            this.textBoxIDNarudzbe.Name = "textBoxIDNarudzbe";
            this.textBoxIDNarudzbe.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDNarudzbe.TabIndex = 2;
            // 
            // buttonBrisanjeNarudžbe
            // 
            this.buttonBrisanjeNarudžbe.Location = new System.Drawing.Point(212, 202);
            this.buttonBrisanjeNarudžbe.Name = "buttonBrisanjeNarudžbe";
            this.buttonBrisanjeNarudžbe.Size = new System.Drawing.Size(134, 36);
            this.buttonBrisanjeNarudžbe.TabIndex = 3;
            this.buttonBrisanjeNarudžbe.Text = "Brisanje narudžbe";
            this.buttonBrisanjeNarudžbe.UseVisualStyleBackColor = true;
            this.buttonBrisanjeNarudžbe.Click += new System.EventHandler(this.buttonBrisanjeNarudžbe_Click);
            // 
            // BrisanjeNarudžbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 262);
            this.Controls.Add(this.buttonBrisanjeNarudžbe);
            this.Controls.Add(this.textBoxIDNarudzbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BrisanjeNarudžbe";
            this.Text = "Prikaz/Brisanje narudžbe";
            this.Load += new System.EventHandler(this.BrisanjeNarudžbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDNarudzbe;
        private System.Windows.Forms.Button buttonBrisanjeNarudžbe;
    }
}