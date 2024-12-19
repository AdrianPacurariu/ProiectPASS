using MySql.Data.MySqlClient;
using ProiectPASS.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPASS.Models.Classes
{
    internal class DBStudent : IStudent
    {

        private readonly string connectionString = "Server=localhost;Port=3306;Database=student;Uid=root;Pwd=root;";

        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();

            string query = "SELECT numarMatricol, nume, medie FROM student.students";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            NumarMatricol = reader["numarMatricol"].ToString(),
                            Nume = reader["nume"].ToString(),
                            Medie = Convert.ToDouble(reader["medie"])
                        };

                        students.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return students;
        }

        public Student getStudentByNrMatricol(string numarMatricol)
        {
            throw new NotImplementedException();
        }
    }
}
