using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPASS.Models.Classes;

namespace ProiectPASS.Models.Interfaces
{
    internal interface IStudent
    {
        List<Student> getStudents();

        Student getStudentByNrMatricol(string numarMatricol);

        Student getStudentByMedie(double medie);

        void addStudent(Student student);
    }
}
