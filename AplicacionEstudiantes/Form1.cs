namespace AplicacionEstudiantes
{
    public partial class Form1 : Form
    {

        Estudiante[] estudiantes = new Estudiante[5];
        int contador = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Hola");
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
    }
}