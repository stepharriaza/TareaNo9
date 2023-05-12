namespace AplicacionEstudiantes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtbCarnet = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorCarnet = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarnet.Location = new System.Drawing.Point(75, 130);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(64, 23);
            this.lblCarnet.TabIndex = 0;
            this.lblCarnet.Text = "Carnet:";
            // 
            // txtbCarnet
            // 
            this.txtbCarnet.Location = new System.Drawing.Point(144, 130);
            this.txtbCarnet.Name = "txtbCarnet";
            this.txtbCarnet.Size = new System.Drawing.Size(309, 23);
            this.txtbCarnet.TabIndex = 1;
            this.txtbCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCarnet_KeyPress);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(157, 73);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(299, 23);
            this.txtbNombre.TabIndex = 3;
            this.txtbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(75, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(409, 297);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblError.Location = new System.Drawing.Point(75, 233);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(44, 18);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorNombre.Location = new System.Drawing.Point(150, 99);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(39, 17);
            this.lblErrorNombre.TabIndex = 6;
            this.lblErrorNombre.Text = "label1";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorCarnet
            // 
            this.lblErrorCarnet.AutoSize = true;
            this.lblErrorCarnet.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorCarnet.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCarnet.Location = new System.Drawing.Point(140, 156);
            this.lblErrorCarnet.Name = "lblErrorCarnet";
            this.lblErrorCarnet.Size = new System.Drawing.Size(39, 17);
            this.lblErrorCarnet.TabIndex = 7;
            this.lblErrorCarnet.Text = "label1";
            this.lblErrorCarnet.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEstudiantes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuEstudiantes
            // 
            this.mnuEstudiantes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNotas});
            this.mnuEstudiantes.Name = "mnuEstudiantes";
            this.mnuEstudiantes.Size = new System.Drawing.Size(79, 20);
            this.mnuEstudiantes.Text = "Estudiantes";
            // 
            // mnuNotas
            // 
            this.mnuNotas.Name = "mnuNotas";
            this.mnuNotas.Size = new System.Drawing.Size(105, 22);
            this.mnuNotas.Text = "Notas";
            this.mnuNotas.Click += new System.EventHandler(this.mnuNotas_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.RosyBrown;
            this.btnListado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListado.Location = new System.Drawing.Point(288, 297);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(98, 30);
            this.btnListado.TabIndex = 9;
            this.btnListado.Text = "Ver listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(541, 371);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.lblErrorCarnet);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtbCarnet);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aplicacion de Estudiantes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCarnet;
        private TextBox txtbCarnet;
        private TextBox txtbNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private Label lblError;
        private Label lblErrorNombre;
        private Label lblErrorCarnet;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuEstudiantes;
        private ToolStripMenuItem mnuNotas;
        private Button btnListado;
    }
}