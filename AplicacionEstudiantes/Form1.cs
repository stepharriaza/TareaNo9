namespace AplicacionEstudiantes
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        Estudiante[] estudiantes = new Estudiante[5];
        int contador = 0;


        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(existStudent(txtbCarnet.Text)))
            {
                if (contador < 5)
                {
                    bool verificado = true;
                    if (txtbCarnet.Text == "")
                    {
                        lblErrorCarnet.Text = "El carnet no puede ser vacío";
                        lblErrorCarnet.Visible = true;
                        verificado = false;
                    }
                    if (txtbNombre.Text == "")
                    {
                        lblErrorNombre.Text = "El carnet no puede ser vacío";
                        lblErrorNombre.Visible = true;
                        verificado = false;
                    }
                    if (verificado)
                    {
                        lblErrorNombre.Visible = false;
                        lblErrorCarnet.Visible = false;
                        estudiantes[contador] = new Estudiante(txtbNombre.Text, txtbCarnet.Text);
                        contador++;

                        txtbCarnet.Text = "";
                        txtbNombre.Text = "";

                    }


                }
                else
                {
                    lblError.Text = "No es posible almacenar estudiante";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Ya existe un nombre con este carnet";
                lblError.Visible = true;
            }
        }

        private void txtbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (contador < 5)
                {
                    bool verificado = true;
                    if (txtbCarnet.Text == "")
                    {
                        lblErrorCarnet.Text = "El carnet no puede ser vacío";
                        lblErrorCarnet.Visible = true;
                        verificado = false;
                    }
                    if (txtbNombre.Text == "")
                    {
                        lblErrorNombre.Text = "El carnet no puede ser vacío";
                        lblErrorNombre.Visible = true;
                        verificado = false;
                    }
                    if (verificado)
                    {
                        lblErrorNombre.Visible = false;
                        lblErrorCarnet.Visible = false;
                        estudiantes[contador] = new Estudiante(txtbNombre.Text, txtbCarnet.Text);
                        contador++;

                        txtbCarnet.Text = "";
                        txtbNombre.Text = "";

                    }


                }
                else
                {
                    lblError.Text = "No es posible almacenar estudiante";
                    lblError.Visible = true;
                }
            }
        }

        private void txtbCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (contador < 5)
                {
                    bool verificado = true;
                    if (txtbCarnet.Text == "")
                    {
                        lblErrorCarnet.Text = "El carnet no puede ser vacío";
                        lblErrorCarnet.Visible = true;
                        verificado = false;
                    }
                    if (txtbNombre.Text == "")
                    {
                        lblErrorNombre.Text = "El carnet no puede ser vacío";
                        lblErrorNombre.Visible = true;
                        verificado = false;
                    }
                    if (verificado)
                    {
                        lblErrorNombre.Visible = false;
                        lblErrorCarnet.Visible = false;
                        estudiantes[contador] = new Estudiante(txtbNombre.Text, txtbCarnet.Text);
                        contador++;

                        txtbCarnet.Text = "";
                        txtbNombre.Text = "";

                    }


                }
                else
                {
                    lblError.Text = "No es posible almacenar estudiante";
                    lblError.Visible = true;
                }
            }
            
        }

        public bool existStudent(String studentId) { 
        
            bool result = false;

            foreach(Estudiante item in estudiantes)
            {
                if(item != null && item.getId() == studentId)
                {
                    result = true;
                    break;
                }
            }

            return result;

        }

        public Estudiante findStudent(String studentId)
        {
            Estudiante estudiante = null;

            foreach (Estudiante item in estudiantes) {

                if (item != null && item.getId() == studentId) { 
                    estudiante= item;
                    break;
                }
            }

            return estudiante;

        }

        private void mnuNotas_Click(object sender, EventArgs e)
        {
            FormularioNotas notas = new FormularioNotas();
            notas.Show();
        }
    
        public Estudiante[] getEstudiantes()
        {
            return estudiantes;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach(Estudiante item in estudiantes)
            {
                if(item != null)
                {
                    message += item.getId() + " - " + item.getNombre() + "\n";
                    foreach (Curso course in item.getCursos()) {
                        if (course != null) {
                            message += "\t" + course.getNombre() + " - " + course.getGrade() + "\n";
                        }
                    }
                }
            }

            MessageBox.Show(message);
        }
    }
}