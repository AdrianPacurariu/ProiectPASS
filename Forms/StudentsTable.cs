using ProiectPASS.Models.Classes;
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
    public partial class StudentsTable : Form
    {
        public StudentsTable(List<Student> students)
        {
            InitializeComponent();

            DataGridView dataGridViewStudents = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AutoGenerateColumns = true 
            };

            dataGridViewStudents.DataSource = students;

            Controls.Add(dataGridViewStudents);
        }
    }
}
