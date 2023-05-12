using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEstudiantes
{
    public partial class FormularioNotas : Form
    {
        public FormularioNotas()
        {
            InitializeComponent();

            Form1.instance.getEstudiantes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Estudiante item in Form1.instance.getEstudiantes()) { 
            
                if(item != null && item.getId() == txtbCarnet.Text)
                {
                    item.getCursos()[0] = new Curso (txtbCurso.Text, Int32.Parse(txtbNota.Text));
                }
            }
        }
    }
}
