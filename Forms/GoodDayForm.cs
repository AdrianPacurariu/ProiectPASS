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
        public GoodDayForm(IStudent studentService)
        {
            InitializeComponent();
            this.studentService = studentService;
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

            string studentName = foundStudent.Nume;
            int day = DateTime.Now.Day;
            char firstLetter = studentName[0];

            int asciiFirstLetterValue = (int)firstLetter;
            int result = (day + asciiFirstLetterValue) % 2;

            string prediction = result == 1 ? "... Good day! :)" : "... Bad day! :(";

            MessageBox.Show($"For {studentName} today is a {prediction}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
