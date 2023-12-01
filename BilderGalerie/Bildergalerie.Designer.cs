namespace BilderGalerie
{
    partial class Bildergalerie
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxDateien = new System.Windows.Forms.ListBox();
            this.labelDateien = new System.Windows.Forms.Label();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.pictureBoxBild = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBild)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDateien
            // 
            this.listBoxDateien.FormattingEnabled = true;
            this.listBoxDateien.HorizontalScrollbar = true;
            this.listBoxDateien.ItemHeight = 16;
            this.listBoxDateien.Location = new System.Drawing.Point(12, 28);
            this.listBoxDateien.Name = "listBoxDateien";
            this.listBoxDateien.Size = new System.Drawing.Size(184, 420);
            this.listBoxDateien.TabIndex = 0;
            this.listBoxDateien.SelectedIndexChanged += new System.EventHandler(this.listBoxDateien_SelectedIndexChanged);
            // 
            // labelDateien
            // 
            this.labelDateien.AutoSize = true;
            this.labelDateien.Location = new System.Drawing.Point(12, 9);
            this.labelDateien.Name = "labelDateien";
            this.labelDateien.Size = new System.Drawing.Size(81, 16);
            this.labelDateien.TabIndex = 1;
            this.labelDateien.Text = "Bild-Dateien";
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Location = new System.Drawing.Point(15, 460);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(181, 32);
            this.buttonHinzufuegen.TabIndex = 2;
            this.buttonHinzufuegen.Text = "Hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonHinzufuegen.Click += new System.EventHandler(this.buttonHinzufuegen_Click);
            // 
            // pictureBoxBild
            // 
            this.pictureBoxBild.Location = new System.Drawing.Point(224, 28);
            this.pictureBoxBild.Name = "pictureBoxBild";
            this.pictureBoxBild.Size = new System.Drawing.Size(702, 464);
            this.pictureBoxBild.TabIndex = 3;
            this.pictureBoxBild.TabStop = false;
            // 
            // Bildergalerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 504);
            this.Controls.Add(this.pictureBoxBild);
            this.Controls.Add(this.buttonHinzufuegen);
            this.Controls.Add(this.labelDateien);
            this.Controls.Add(this.listBoxDateien);
            this.Name = "Bildergalerie";
            this.Text = "Bildergalerie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDateien;
        private System.Windows.Forms.Label labelDateien;
        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.PictureBox pictureBoxBild;
    }
}

