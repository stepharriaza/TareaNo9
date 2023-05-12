using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEstudiantes
{
    public class Estudiante
    {

        private String nombre;
        private String id;
        private Curso[] cursos = new Curso[2];

        public Estudiante(string nombre, string id)
        {
            this.nombre=nombre;
            this.id=id;
        }

        public String getId() { 
            return id;        
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setId(String id) { 
            this.id = id;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public Curso[] getCursos() {
            return this.cursos;
        }



    }
}
