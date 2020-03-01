namespace DRAlpha2
{
    partial class ViteEMadreviteHomepage
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViteEMadreviteHomepage));
            this.label1 = new System.Windows.Forms.Label();
            this.viteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.madreviteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // viteButton
            // 
            this.viteButton.BackColor = System.Drawing.Color.White;
            this.viteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viteButton.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(27)))), ((int)(((byte)(4)))));
            this.viteButton.Image = ((System.Drawing.Image)(resources.GetObject("viteButton.Image")));
            this.viteButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.viteButton.Location = new System.Drawing.Point(286, 274);
            this.viteButton.Name = "viteButton";
            this.viteButton.Size = new System.Drawing.Size(262, 202);
            this.viteButton.TabIndex = 1;
            this.viteButton.Text = "VITE";
            this.viteButton.UseVisualStyleBackColor = false;
            this.viteButton.Click += new System.EventHandler(this.viteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 133);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // madreviteButton
            // 
            this.madreviteButton.BackColor = System.Drawing.Color.White;
            this.madreviteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.madreviteButton.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madreviteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(27)))), ((int)(((byte)(4)))));
            this.madreviteButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.madreviteButton.Location = new System.Drawing.Point(592, 274);
            this.madreviteButton.Name = "madreviteButton";
            this.madreviteButton.Size = new System.Drawing.Size(262, 202);
            this.madreviteButton.TabIndex = 4;
            this.madreviteButton.Text = "MADREVITE";
            this.madreviteButton.UseVisualStyleBackColor = false;
            this.madreviteButton.Click += new System.EventHandler(this.madreviteButton_Click);
            // 
            // ViteEMadreviteHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(19)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1443, 774);
            this.Controls.Add(this.madreviteButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viteButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ViteEMadreviteHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRalpha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button madreviteButton;
    }
}

