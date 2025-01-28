namespace PDFMaker
{
    partial class PdfMakerForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PdfContent_label = new System.Windows.Forms.Label();
            this.PdfTitle_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PdfFileName_label = new System.Windows.Forms.Label();
            this.PdfFileName_textBox = new System.Windows.Forms.TextBox();
            this.PdfDocument_dataGridView = new System.Windows.Forms.DataGridView();
            this.Print_button = new System.Windows.Forms.Button();
            this.PdfContent_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PdfDocument_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PdfContent_label
            // 
            this.PdfContent_label.Location = new System.Drawing.Point(12, 205);
            this.PdfContent_label.Name = "PdfContent_label";
            this.PdfContent_label.Size = new System.Drawing.Size(172, 207);
            this.PdfContent_label.TabIndex = 7;
            this.PdfContent_label.Text = "То что написан в TextBox будет отображатся тут";
            // 
            // PdfTitle_textBox
            // 
            this.PdfTitle_textBox.Location = new System.Drawing.Point(113, 18);
            this.PdfTitle_textBox.Name = "PdfTitle_textBox";
            this.PdfTitle_textBox.Size = new System.Drawing.Size(172, 20);
            this.PdfTitle_textBox.TabIndex = 21;
            this.PdfTitle_textBox.Text = "This file is created for test work";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Title of document :";
            // 
            // PdfFileName_label
            // 
            this.PdfFileName_label.AutoSize = true;
            this.PdfFileName_label.Location = new System.Drawing.Point(376, 266);
            this.PdfFileName_label.Name = "PdfFileName_label";
            this.PdfFileName_label.Size = new System.Drawing.Size(55, 13);
            this.PdfFileName_label.TabIndex = 19;
            this.PdfFileName_label.Text = "File name:";
            // 
            // PdfFileName_textBox
            // 
            this.PdfFileName_textBox.Location = new System.Drawing.Point(455, 263);
            this.PdfFileName_textBox.Name = "PdfFileName_textBox";
            this.PdfFileName_textBox.Size = new System.Drawing.Size(97, 20);
            this.PdfFileName_textBox.TabIndex = 18;
            // 
            // PdfDocument_dataGridView
            // 
            this.PdfDocument_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PdfDocument_dataGridView.Location = new System.Drawing.Point(205, 55);
            this.PdfDocument_dataGridView.Name = "PdfDocument_dataGridView";
            this.PdfDocument_dataGridView.Size = new System.Drawing.Size(347, 192);
            this.PdfDocument_dataGridView.TabIndex = 17;
            // 
            // Print_button
            // 
            this.Print_button.Location = new System.Drawing.Point(477, 289);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(75, 23);
            this.Print_button.TabIndex = 16;
            this.Print_button.Text = "Печать";
            this.Print_button.UseVisualStyleBackColor = true;
            this.Print_button.Click += new System.EventHandler(this.Print_button_Click);
            // 
            // PdfContent_textBox
            // 
            this.PdfContent_textBox.Location = new System.Drawing.Point(12, 55);
            this.PdfContent_textBox.Multiline = true;
            this.PdfContent_textBox.Name = "PdfContent_textBox";
            this.PdfContent_textBox.Size = new System.Drawing.Size(172, 130);
            this.PdfContent_textBox.TabIndex = 15;
            this.PdfContent_textBox.Text = "Пишится в PDF файле ";
            this.PdfContent_textBox.TextChanged += new System.EventHandler(this.PdfContent_textBox_TextChanged);
            // 
            // PdfMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(586, 447);
            this.Controls.Add(this.PdfContent_label);
            this.Controls.Add(this.PdfTitle_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PdfFileName_label);
            this.Controls.Add(this.PdfFileName_textBox);
            this.Controls.Add(this.PdfDocument_dataGridView);
            this.Controls.Add(this.Print_button);
            this.Controls.Add(this.PdfContent_textBox);
            this.MaximizeBox = false;
            this.Name = "PdfMakerForm";
            this.Text = "PDF File Maker";
            this.Load += new System.EventHandler(this.PDFMakerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PdfDocument_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PdfContent_label;
        private System.Windows.Forms.TextBox PdfTitle_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PdfFileName_label;
        private System.Windows.Forms.TextBox PdfFileName_textBox;
        private System.Windows.Forms.DataGridView PdfDocument_dataGridView;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.TextBox PdfContent_textBox;
    }
}

