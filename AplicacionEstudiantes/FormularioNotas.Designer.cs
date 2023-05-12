namespace AplicacionEstudiantes
{
    partial class FormularioNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbCarnet = new System.Windows.Forms.TextBox();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtbCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtbNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbCarnet
            // 
            this.txtbCarnet.Location = new System.Drawing.Point(150, 101);
            this.txtbCarnet.Name = "txtbCarnet";
            this.txtbCarnet.Size = new System.Drawing.Size(309, 23);
            this.txtbCarnet.TabIndex = 3;
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarnet.Location = new System.Drawing.Point(81, 101);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(64, 23);
            this.lblCarnet.TabIndex = 2;
            this.lblCarnet.Text = "Carnet:";
            // 
            // txtbCurso
            // 
            this.txtbCurso.Location = new System.Drawing.Point(150, 153);
            this.txtbCurso.Name = "txtbCurso";
            this.txtbCurso.Size = new System.Drawing.Size(309, 23);
            this.txtbCurso.TabIndex = 5;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.Location = new System.Drawing.Point(81, 153);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(56, 23);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso:";
            // 
            // txtbNota
            // 
            this.txtbNota.Location = new System.Drawing.Point(150, 209);
            this.txtbNota.Name = "txtbNota";
            this.txtbNota.Size = new System.Drawing.Size(309, 23);
            this.txtbNota.TabIndex = 7;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNota.Location = new System.Drawing.Point(81, 209);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(51, 23);
            this.lblNota.TabIndex = 6;
            this.lblNota.Text = "Nota:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(229, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormularioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtbNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtbCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtbCarnet);
            this.Controls.Add(this.lblCarnet);
            this.Name = "FormularioNotas";
            this.Text = "FormularioNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbCarnet;
        private Label lblCarnet;
        private TextBox txtbCurso;
        private Label lblCurso;
        private TextBox txtbNota;
        private Label lblNota;
        private Button btnGuardar;
    }
}