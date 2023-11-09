namespace Teira.Agustin.PrimerParcial.Forms
{
    partial class formCRUD
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
            boxObjetcts = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtFecha = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnOrdenamientoAscendente = new Button();
            btnEncender = new Button();
            btnOrdenamientoDescendente = new Button();
            label4 = new Label();
            btnSerializar = new Button();
            btnDeserializar = new Button();
            txtUsuario = new Label();
            btnVisualidorLogins = new Button();
            SuspendLayout();
            // 
            // boxObjetcts
            // 
            boxObjetcts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            boxObjetcts.FormattingEnabled = true;
            boxObjetcts.ItemHeight = 28;
            boxObjetcts.Location = new Point(12, 100);
            boxObjetcts.Name = "boxObjetcts";
            boxObjetcts.Size = new Size(879, 564);
            boxObjetcts.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(897, 100);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 75);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(897, 181);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 75);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(897, 262);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 75);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtFecha
            // 
            txtFecha.AutoSize = true;
            txtFecha.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.Location = new Point(685, 681);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(0, 37);
            txtFecha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 35);
            label2.Name = "label2";
            label2.Size = new Size(55, 31);
            label2.TabIndex = 6;
            label2.Text = "Año";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 35);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 7;
            label1.Text = "Vel Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(237, 35);
            label3.Name = "label3";
            label3.Size = new Size(68, 31);
            label3.TabIndex = 8;
            label3.Text = "Color";
            // 
            // btnOrdenamientoAscendente
            // 
            btnOrdenamientoAscendente.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenamientoAscendente.Location = new Point(897, 508);
            btnOrdenamientoAscendente.Name = "btnOrdenamientoAscendente";
            btnOrdenamientoAscendente.Size = new Size(75, 75);
            btnOrdenamientoAscendente.TabIndex = 9;
            btnOrdenamientoAscendente.Text = "↑";
            btnOrdenamientoAscendente.UseVisualStyleBackColor = true;
            btnOrdenamientoAscendente.Click += btnOrdenamientoAscendente_Click;
            // 
            // btnEncender
            // 
            btnEncender.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnEncender.Location = new Point(897, 589);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(75, 75);
            btnEncender.TabIndex = 10;
            btnEncender.Text = "E";
            btnEncender.UseVisualStyleBackColor = true;
            btnEncender.Click += btnEncender_Click;
            // 
            // btnOrdenamientoDescendente
            // 
            btnOrdenamientoDescendente.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenamientoDescendente.Location = new Point(897, 427);
            btnOrdenamientoDescendente.Name = "btnOrdenamientoDescendente";
            btnOrdenamientoDescendente.Size = new Size(75, 75);
            btnOrdenamientoDescendente.TabIndex = 11;
            btnOrdenamientoDescendente.Text = "↓";
            btnOrdenamientoDescendente.UseVisualStyleBackColor = true;
            btnOrdenamientoDescendente.Click += btnOrdenamientoDescendente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(700, 35);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 12;
            label4.Text = "Estado";
            // 
            // btnSerializar
            // 
            btnSerializar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSerializar.Location = new Point(398, 18);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(105, 75);
            btnSerializar.TabIndex = 13;
            btnSerializar.Text = "cargar";
            btnSerializar.UseVisualStyleBackColor = true;
            btnSerializar.Click += btnSerializar_Click;
            // 
            // btnDeserializar
            // 
            btnDeserializar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeserializar.Location = new Point(520, 19);
            btnDeserializar.Name = "btnDeserializar";
            btnDeserializar.Size = new Size(97, 75);
            btnDeserializar.TabIndex = 14;
            btnDeserializar.Text = "guardar";
            btnDeserializar.UseVisualStyleBackColor = true;
            btnDeserializar.Click += btnDeserializar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(106, 681);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(70, 37);
            txtUsuario.TabIndex = 15;
            txtUsuario.Text = "User";
            // 
            // btnVisualidorLogins
            // 
            btnVisualidorLogins.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisualidorLogins.Location = new Point(894, 11);
            btnVisualidorLogins.Name = "btnVisualidorLogins";
            btnVisualidorLogins.Size = new Size(75, 75);
            btnVisualidorLogins.TabIndex = 16;
            btnVisualidorLogins.Text = "VL";
            btnVisualidorLogins.UseVisualStyleBackColor = true;
            btnVisualidorLogins.Click += btnVisualidorLogins_Click;
            // 
            // formCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 739);
            Controls.Add(btnVisualidorLogins);
            Controls.Add(txtUsuario);
            Controls.Add(btnDeserializar);
            Controls.Add(btnSerializar);
            Controls.Add(label4);
            Controls.Add(btnOrdenamientoDescendente);
            Controls.Add(btnEncender);
            Controls.Add(btnOrdenamientoAscendente);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtFecha);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(boxObjetcts);
            Name = "formCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox boxObjetcts;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Label txtFecha;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnOrdenamientoAscendente;
        private Button btnEncender;
        private Button btnOrdenamientoDescendente;
        private Label label4;
        private Button btnSerializar;
        private Button btnDeserializar;
        private Label txtUsuario;
        private Button btnVisualidorLogins;
    }
}