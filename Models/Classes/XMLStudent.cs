using ProiectPASS.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach (System.Xml.XmlNode studentNode in xmlDocument.SelectNodes("/StudentTable/Student"))
            {
                Student student = new Student
                {
                    numarMatricol = studentNode["NumarMatricol"]?.InnerText,
                    nume = studentNode["Nume"]?.InnerText,
                    medie = double.Parse(studentNode["Medie"]?.InnerText ?? "0")
                };
                students.Add(student);
            }
            return students;
        }
        public void addStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student getStudentByMedie(double medie)
        {
            throw new NotImplementedException();
        }

        public Student getStudentByNrMatricol(string numarMatricol)
        {
            throw new NotImplementedException();
        }     
    }    
}
