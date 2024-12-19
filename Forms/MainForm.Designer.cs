namespace ProiectPASS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpBoxIncarcare = new System.Windows.Forms.GroupBox();
            this.btnIncarcareBD = new System.Windows.Forms.Button();
            this.btnIncarcareXML = new System.Windows.Forms.Button();
            this.grpBoxVizualizare = new System.Windows.Forms.GroupBox();
            this.btnAfisareTabel = new System.Windows.Forms.Button();
            this.grpBoxFunctionalitati = new System.Windows.Forms.GroupBox();
            this.btnZiBuna = new System.Windows.Forms.Button();
            this.btnPreziceMedieScazuta = new System.Windows.Forms.Button();
            this.btnPreziceMedia = new System.Windows.Forms.Button();
            this.AppLogo = new System.Windows.Forms.PictureBox();
            this.grpBoxIncarcare.SuspendLayout();
            this.grpBoxVizualizare.SuspendLayout();
            this.grpBoxFunctionalitati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxIncarcare
            // 
            this.grpBoxIncarcare.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxIncarcare.Controls.Add(this.btnIncarcareBD);
            this.grpBoxIncarcare.Controls.Add(this.btnIncarcareXML);
            this.grpBoxIncarcare.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxIncarcare.Location = new System.Drawing.Point(12, 418);
            this.grpBoxIncarcare.Name = "grpBoxIncarcare";
            this.grpBoxIncarcare.Size = new System.Drawing.Size(356, 163);
            this.grpBoxIncarcare.TabIndex = 3;
            this.grpBoxIncarcare.TabStop = false;
            this.grpBoxIncarcare.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxIncarcare_Paint);
            // 
            // btnIncarcareBD
            // 
            this.btnIncarcareBD.BackColor = System.Drawing.Color.White;
            this.btnIncarcareBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncarcareBD.Image = global::ProiectPASS.Properties.Resources.DBIcon;
            this.btnIncarcareBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncarcareBD.Location = new System.Drawing.Point(6, 93);
            this.btnIncarcareBD.Name = "btnIncarcareBD";
            this.btnIncarcareBD.Size = new System.Drawing.Size(344, 56);
            this.btnIncarcareBD.TabIndex = 2;
            this.btnIncarcareBD.Text = "Incarcare studenti din baza date";
            this.btnIncarcareBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncarcareBD.UseVisualStyleBackColor = false;
            this.btnIncarcareBD.Click += new System.EventHandler(this.btnIncarcareBD_Click);
            // 
            // btnIncarcareXML
            // 
            this.btnIncarcareXML.BackColor = System.Drawing.Color.White;
            this.btnIncarcareXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncarcareXML.Image = global::ProiectPASS.Properties.Resources.XmlIcon;
            this.btnIncarcareXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncarcareXML.Location = new System.Drawing.Point(6, 24);
            this.btnIncarcareXML.Name = "btnIncarcareXML";
            this.btnIncarcareXML.Size = new System.Drawing.Size(344, 56);
            this.btnIncarcareXML.TabIndex = 1;
            this.btnIncarcareXML.Text = "Incarcare studenti din fisier XML";
            this.btnIncarcareXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncarcareXML.UseVisualStyleBackColor = false;
            this.btnIncarcareXML.Click += new System.EventHandler(this.btnIncarcareXML_Click);
            // 
            // grpBoxVizualizare
            // 
            this.grpBoxVizualizare.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxVizualizare.Controls.Add(this.btnAfisareTabel);
            this.grpBoxVizualizare.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxVizualizare.Location = new System.Drawing.Point(374, 488);
            this.grpBoxVizualizare.Name = "grpBoxVizualizare";
            this.grpBoxVizualizare.Size = new System.Drawing.Size(287, 93);
            this.grpBoxVizualizare.TabIndex = 4;
            this.grpBoxVizualizare.TabStop = false;
            this.grpBoxVizualizare.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxVizualizare_Paint);
            // 
            // btnAfisareTabel
            // 
            this.btnAfisareTabel.BackColor = System.Drawing.Color.White;
            this.btnAfisareTabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfisareTabel.Image = global::ProiectPASS.Properties.Resources.TableIcon;
            this.btnAfisareTabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfisareTabel.Location = new System.Drawing.Point(6, 23);
            this.btnAfisareTabel.Name = "btnAfisareTabel";
            this.btnAfisareTabel.Size = new System.Drawing.Size(275, 56);
            this.btnAfisareTabel.TabIndex = 1;
            this.btnAfisareTabel.Text = "Afisare tabel studenti";
            this.btnAfisareTabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAfisareTabel.UseVisualStyleBackColor = false;
            this.btnAfisareTabel.Click += new System.EventHandler(this.btnAfisareTabel_Click);
            // 
            // grpBoxFunctionalitati
            // 
            this.grpBoxFunctionalitati.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxFunctionalitati.Controls.Add(this.btnZiBuna);
            this.grpBoxFunctionalitati.Controls.Add(this.btnPreziceMedieScazuta);
            this.grpBoxFunctionalitati.Controls.Add(this.btnPreziceMedia);
            this.grpBoxFunctionalitati.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFunctionalitati.Location = new System.Drawing.Point(667, 346);
            this.grpBoxFunctionalitati.Name = "grpBoxFunctionalitati";
            this.grpBoxFunctionalitati.Size = new System.Drawing.Size(383, 235);
            this.grpBoxFunctionalitati.TabIndex = 5;
            this.grpBoxFunctionalitati.TabStop = false;
            this.grpBoxFunctionalitati.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxFunctionalitati_Paint);
            // 
            // btnZiBuna
            // 
            this.btnZiBuna.BackColor = System.Drawing.Color.White;
            this.btnZiBuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZiBuna.Image = global::ProiectPASS.Properties.Resources.NumberThree;
            this.btnZiBuna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZiBuna.Location = new System.Drawing.Point(6, 165);
            this.btnZiBuna.Name = "btnZiBuna";
            this.btnZiBuna.Size = new System.Drawing.Size(371, 56);
            this.btnZiBuna.TabIndex = 3;
            this.btnZiBuna.Text = "Vei avea o zi buna?";
            this.btnZiBuna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZiBuna.UseVisualStyleBackColor = false;
            // 
            // btnPreziceMedieScazuta
            // 
            this.btnPreziceMedieScazuta.BackColor = System.Drawing.Color.White;
            this.btnPreziceMedieScazuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreziceMedieScazuta.Image = global::ProiectPASS.Properties.Resources.NumberTwo;
            this.btnPreziceMedieScazuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreziceMedieScazuta.Location = new System.Drawing.Point(6, 92);
            this.btnPreziceMedieScazuta.Name = "btnPreziceMedieScazuta";
            this.btnPreziceMedieScazuta.Size = new System.Drawing.Size(371, 56);
            this.btnPreziceMedieScazuta.TabIndex = 2;
            this.btnPreziceMedieScazuta.Text = "Cati studenti vor avea media scazuta?";
            this.btnPreziceMedieScazuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreziceMedieScazuta.UseVisualStyleBackColor = false;
            // 
            // btnPreziceMedia
            // 
            this.btnPreziceMedia.BackColor = System.Drawing.Color.White;
            this.btnPreziceMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreziceMedia.Image = global::ProiectPASS.Properties.Resources.NumberOne;
            this.btnPreziceMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreziceMedia.Location = new System.Drawing.Point(6, 24);
            this.btnPreziceMedia.Name = "btnPreziceMedia";
            this.btnPreziceMedia.Size = new System.Drawing.Size(371, 56);
            this.btnPreziceMedia.TabIndex = 1;
            this.btnPreziceMedia.Text = "Media ta va creste sau va scadea?";
            this.btnPreziceMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreziceMedia.UseVisualStyleBackColor = false;
            // 
            // AppLogo
            // 
            this.AppLogo.Image = global::ProiectPASS.Properties.Resources.Logo;
            this.AppLogo.Location = new System.Drawing.Point(374, 0);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new System.Drawing.Size(432, 432);
            this.AppLogo.TabIndex = 0;
            this.AppLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 593);
            this.Controls.Add(this.grpBoxFunctionalitati);
            this.Controls.Add(this.grpBoxVizualizare);
            this.Controls.Add(this.AppLogo);
            this.Controls.Add(this.grpBoxIncarcare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoroscopeApp";
            this.grpBoxIncarcare.ResumeLayout(false);
            this.grpBoxVizualizare.ResumeLayout(false);
            this.grpBoxFunctionalitati.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AppLogo;
        private System.Windows.Forms.Button btnIncarcareXML;
        private System.Windows.Forms.Button btnIncarcareBD;
        private System.Windows.Forms.GroupBox grpBoxIncarcare;
        private System.Windows.Forms.GroupBox grpBoxVizualizare;
        private System.Windows.Forms.Button btnAfisareTabel;
        private System.Windows.Forms.GroupBox grpBoxFunctionalitati;
        private System.Windows.Forms.Button btnPreziceMedieScazuta;
        private System.Windows.Forms.Button btnPreziceMedia;
        private System.Windows.Forms.Button btnZiBuna;
    }
}

