using ProiectPASS.Models.Classes;
using ProiectPASS.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPASS.Forms
{
    public partial class GoodDayForm : Form
    {
        private readonly IStudent studentService;
        public GoodDayForm(IStudent studentService, string title)
        {
            InitializeComponent();
            this.studentService = studentService;
            this.Text = title;
        }

        private void btnPreziceMedia_Click(object sender, EventArgs e)
        {
            string inputNrMatricol = txtBoxNrMatricol.Text.Trim();

            Student foundStudent = studentService.getStudentByNrMatricol(inputNrMatricol);

            if (foundStudent == null)
            {
                MessageBox.Show("Numar matricol invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(this.Text == "WillYourAverageGrowOrDrop")
            {
                int result = studentService.ComputeMedie(foundStudent);

                string prediction = result == 1 ? "... grow! :)" : "... drop! :(";

                MessageBox.Show($"For {foundStudent.Nume} the average grade will {prediction}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                int result = studentService.GoodOrBadDay(foundStudent);

                string prediction = result == 1 ? "... Good day! :)" : "... Bad day! :(";

                MessageBox.Show($"For {foundStudent.Nume} today is a {prediction}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
    }
}
