using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPASS.Models.Classes;

namespace ProiectPASS.Models.Interfaces
{
    public interface IStudent
    {
        List<Student> getStudents();

        Student getStudentByNrMatricol(string numarMatricol);
    }
}
