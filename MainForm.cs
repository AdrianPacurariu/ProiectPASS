using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPASS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            grpBoxIncarcare.Paint += grpBoxIncarcare_Paint;
            grpBoxVizualizare.Paint += grpBoxVizualizare_Paint;
            grpBoxFunctionalitati.Paint += grpBoxFunctionalitati_Paint;
        }

        private void grpBoxIncarcare_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomGroupBoxBorder(sender, e);
        }

        private void grpBoxVizualizare_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomGroupBoxBorder(sender, e);
        }

        private void grpBoxFunctionalitati_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomGroupBoxBorder(sender, e);
        }

        private void DrawCustomGroupBoxBorder(object sender, PaintEventArgs e)
        {          
            GroupBox groupBox = sender as GroupBox;
            if (groupBox == null) return;

            using (Pen pen = new Pen(Color.Black, 2))
            {
                SizeF textSize = e.Graphics.MeasureString(groupBox.Text, groupBox.Font);
                Rectangle rect = new Rectangle(
                    groupBox.ClientRectangle.X,
                    groupBox.ClientRectangle.Y + (int)(textSize.Height / 2),
                    groupBox.ClientRectangle.Width - 1,
                    groupBox.ClientRectangle.Height - (int)(textSize.Height / 2) - 1
                );

                e.Graphics.DrawRectangle(pen, rect);              
            }
        }
    }
}
