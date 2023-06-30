namespace GestionUsuarios
{
    partial class GestionUsuarios
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
            listClientes = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtTarjeta = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(12, 12);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(190, 304);
            listClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(256, 12);
            label1.Name = "label1";
            label1.Size = new Size(268, 30);
            label1.TabIndex = 1;
            label1.Text = "LISTADO DE CLIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 82);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(353, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Highlight;
            btnAgregar.Location = new Point(334, 286);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 30);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Firebrick;
            btnEliminar.Location = new Point(30, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar Cliente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(353, 133);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(147, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(274, 133);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 6;
            label3.Text = "Telefono:";
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(274, 218);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(226, 23);
            txtTarjeta.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(274, 185);
            label4.Name = "label4";
            label4.Size = new Size(135, 19);
            label4.TabIndex = 8;
            label4.Text = "Tarjeta de Crédito:";
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 392);
            Controls.Add(txtTarjeta);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listClientes);
            Name = "GestionUsuarios";
            Text = "Usuarios";
            Load += GestionUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Button btnEliminar;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtTarjeta;
        private Label label4;
    }
}