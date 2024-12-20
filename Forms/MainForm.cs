using ProiectPASS.Forms;
using ProiectPASS.Models.Classes;
using ProiectPASS.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPASS
{
    public partial class MainForm : Form
    {
        private IStudent studentService;
        private List<Student> loadedStudents;

        public MainForm()
        {
            InitializeComponent();
            loadedStudents = new List<Student>();

            grpBoxIncarcare.Paint += grpBoxIncarcare_Paint;
            grpBoxVizualizare.Paint += grpBoxVizualizare_Paint;
            grpBoxFunctionalitati.Paint += grpBoxFunctionalitati_Paint;

            btnIncarcareXML.Enabled = true;
            btnIncarcareBD.Enabled = true;
            btnAfisareTabel.Enabled = false;
            btnPreziceMedia.Enabled = false;
            btnPreziceMedieScazuta.Enabled = false;
            btnZiBuna.Enabled = false;
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
        private void btnIncarcareXML_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Files", "Students.xml");

                studentService = new XMLStudent(filePath);

                loadedStudents = studentService.getStudents();

                StudentsTable studentsTableForm = new StudentsTable(loadedStudents);

                MessageBox.Show("Students have been loaded successfully from the XML file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIncarcareBD_Click(object sender, EventArgs e)
        {
            try
            {
                studentService = new DBStudent();

                loadedStudents = studentService.getStudents();

                StudentsTable studentsTableForm = new StudentsTable(loadedStudents);

                MessageBox.Show("Students have been loaded successfully from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnAfisareTabel_Click(object sender, EventArgs e)
        {
            if (studentService == null)
            {
                MessageBox.Show("No students have been loaded yet. Please initialize first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StudentsTable studentsTableForm = new StudentsTable(loadedStudents);
            studentsTableForm.ShowDialog();
        }

        private void btnPreziceMedia_Click(object sender, EventArgs e)
        {
            GoodDayForm goodDayForm = new GoodDayForm(studentService, "WillYourAverageGrowOrDrop");
            goodDayForm.ShowDialog();
        }

        private void btnPreziceMedieScazuta_Click(object sender, EventArgs e)
        {
            ComputeAverage();
        }

        private void btnZiBuna_Click(object sender, EventArgs e)
        {
            GoodDayForm goodDayForm = new GoodDayForm(studentService, "WillYouHaveAGoodOrBadDay");
            goodDayForm.ShowDialog();
        }

        private void ComputeAverage()
        {
            int sum = 0;
            int k = 0;

            foreach (Student student in loadedStudents)
            {
                if (student.Medie > 8)
                {
                    sum++;
                    int result = studentService.ComputeMedie(student);
                    if (result != 1) k++;
                }
            }

            MessageBox.Show($"There are {sum} students which have their average > 8. Out of these, only {k} are unlucky to have their average drop.. :(", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnableButtons()
        {
            btnIncarcareXML.Enabled = false;
            btnIncarcareBD.Enabled = false;
            btnAfisareTabel.Enabled = true;
            btnPreziceMedia.Enabled = true;
            btnPreziceMedieScazuta.Enabled = true;
            btnZiBuna.Enabled = true;
        }
    }
}
