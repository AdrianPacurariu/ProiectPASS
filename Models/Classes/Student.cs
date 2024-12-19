using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPASS.Models.Classes
{
    public class Student
    {
        private string numarMatricol;
        private string nume;
        private double medie;

        public string NumarMatricol
        {
            get { return numarMatricol; }
            set { numarMatricol = value; }
        }

        public string Nume
        {
            get { return nume; } 
            set { nume = value; }  
        }

        public double Medie
        {
            get { return medie; } 
            set { medie = value; }
        }
    }
}
