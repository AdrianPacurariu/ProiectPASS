﻿namespace ProiectPASS.Forms
{
    partial class GoodDayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNrMatricol = new System.Windows.Forms.TextBox();
            this.btnPreziceMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti numarul matricol:\r\n";
            // 
            // txtBoxNrMatricol
            // 
            this.txtBoxNrMatricol.Location = new System.Drawing.Point(12, 48);
            this.txtBoxNrMatricol.Name = "txtBoxNrMatricol";
            this.txtBoxNrMatricol.Size = new System.Drawing.Size(438, 22);
            this.txtBoxNrMatricol.TabIndex = 1;
            // 
            // btnPreziceMedia
            // 
            this.btnPreziceMedia.BackColor = System.Drawing.Color.White;
            this.btnPreziceMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreziceMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreziceMedia.Location = new System.Drawing.Point(12, 76);
            this.btnPreziceMedia.Name = "btnPreziceMedia";
            this.btnPreziceMedia.Size = new System.Drawing.Size(438, 43);
            this.btnPreziceMedia.TabIndex = 2;
            this.btnPreziceMedia.Text = "Let\'s see...";
            this.btnPreziceMedia.UseVisualStyleBackColor = false;
            this.btnPreziceMedia.Click += new System.EventHandler(this.btnPreziceMedia_Click);
            // 
            // GoodDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 128);
            this.Controls.Add(this.btnPreziceMedia);
            this.Controls.Add(this.txtBoxNrMatricol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNrMatricol;
        private System.Windows.Forms.Button btnPreziceMedia;
    }
}