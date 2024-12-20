using ProiectPASS.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPASS.Models.Classes
{
    internal class XMLStudent : IStudent

    {
        private readonly string filePath;
        public XMLStudent(string path)
        {
            filePath = path;
        }

        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            var xmlDocument = new System.Xml.XmlDocument();
            xmlDocument.Load(filePath);

            try
            {
                foreach (System.Xml.XmlNode studentNode in xmlDocument.SelectNodes("/StudentTable/Student"))
                {
                    Student student = new Student
                    {
                        NumarMatricol = studentNode["NumarMatricol"]?.InnerText,
                        Nume = studentNode["Nume"]?.InnerText,
                        Medie = double.Parse(studentNode["Medie"]?.InnerText ?? "0")
                    };
                    students.Add(student);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return students;
        }
        public Student getStudentByNrMatricol(string numarMatricol)
        {
            List<Student> students = getStudents();

            return students.FirstOrDefault(student => student.NumarMatricol == numarMatricol);
        }

        public int ComputeMedie(Student student)
        {
            int numarMatricolSum = student.NumarMatricol
                                          .Where(char.IsDigit)
                                          .Sum(c => c - '0');

            int numeSum = student.Nume
                                 .Where(char.IsLetter)
                                 .Sum(c => c);

            return (numarMatricolSum + numeSum) % 2;
        }
        
        public int GoodOrBadDay(Student student)
        {
            int day = DateTime.Now.Day;
            char firstLetter = student.Nume[0];

            int asciiFirstLetterValue = (int)firstLetter;
            int result = (day + asciiFirstLetterValue) % 2;

            return result;
        }
    }    
}
