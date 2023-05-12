using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEstudiantes
{
    public class Curso
    {

        String nombre;
        int grade;

        public Curso(String nombre, int grade) { 
            
            this.nombre = nombre;
            this.grade = grade;
        }

        public String getNombre()
        {
            return nombre;
        }

        public int getGrade()
        {
            return grade;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setGrade(int grade)
        {
            this.grade = grade;
        }
    }
}
