namespace FormsC_CSV
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
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            listBoxRegistros = new ListBox();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAbrir = new Button();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(479, 33);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(479, 118);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 1;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(479, 72);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 2;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // listBoxRegistros
            // 
            listBoxRegistros.FormattingEnabled = true;
            listBoxRegistros.ItemHeight = 15;
            listBoxRegistros.Location = new Point(38, 194);
            listBoxRegistros.Name = "listBoxRegistros";
            listBoxRegistros.Size = new Size(689, 244);
            listBoxRegistros.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(67, 57);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(224, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(67, 86);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(100, 23);
            textBoxEdad.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(67, 115);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(339, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(382, 33);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(75, 23);
            buttonAbrir.TabIndex = 10;
            buttonAbrir.Text = "Abrir";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAbrir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Controls.Add(listBoxRegistros);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private ListBox listBoxRegistros;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAbrir;
    }
}
