﻿
namespace ImagensNaTela
{
    partial class TelaImagem
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
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.openFileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoto
            // 
            this.pnlFoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoto.Controls.Add(this.pbxFoto);
            this.pnlFoto.Location = new System.Drawing.Point(243, 40);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(295, 348);
            this.pnlFoto.TabIndex = 0;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(18, 21);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(260, 312);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 0;
            this.pbxFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(345, 394);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 1;
            this.btnFoto.Text = "Burcar";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // openFileDialogFoto
            // 
            this.openFileDialogFoto.FileName = "openFileDialog1";
            // 
            // TelaImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pnlFoto);
            this.Name = "TelaImagem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaboratóriodeImagem";
            this.pnlFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoto;
    }
}