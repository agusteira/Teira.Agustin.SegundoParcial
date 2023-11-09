namespace Teira.Agustin.PrimerParcial.Forms
{
    partial class frmVehiculos
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
            txtAño = new TextBox();
            label2 = new Label();
            txtVelMax = new TextBox();
            label3 = new Label();
            txtColor = new TextBox();
            label4 = new Label();
            btnSubmit = new Button();
            btnCancelar = new Button();
            lblTipo = new Label();
            txtAtributo1 = new TextBox();
            lblAtributo1 = new Label();
            txtAtributo2 = new TextBox();
            lblAtributo2 = new Label();
            SuspendLayout();
            // 
            // txtAño
            // 
            txtAño.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAño.Location = new Point(12, 108);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(386, 52);
            txtAño.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 2;
            label2.Text = "Año Fabricacion:";
            // 
            // txtVelMax
            // 
            txtVelMax.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txtVelMax.Location = new Point(12, 228);
            txtVelMax.Name = "txtVelMax";
            txtVelMax.Size = new Size(386, 52);
            txtVelMax.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(241, 37);
            label3.TabIndex = 4;
            label3.Text = "Velocidad Maxima:";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txtColor.Location = new Point(12, 357);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(386, 52);
            txtColor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 317);
            label4.Name = "label4";
            label4.Size = new Size(263, 37);
            label4.TabIndex = 6;
            label4.Text = "Color predominante:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(12, 679);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(178, 76);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Aceptar";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(220, 679);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(178, 76);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Arial Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(129, 9);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(131, 56);
            lblTipo.TabIndex = 10;
            lblTipo.Text = "TIPO";
            lblTipo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAtributo1
            // 
            txtAtributo1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAtributo1.Location = new Point(12, 488);
            txtAtributo1.Name = "txtAtributo1";
            txtAtributo1.Size = new Size(386, 52);
            txtAtributo1.TabIndex = 12;
            // 
            // lblAtributo1
            // 
            lblAtributo1.AutoSize = true;
            lblAtributo1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtributo1.Location = new Point(12, 448);
            lblAtributo1.Name = "lblAtributo1";
            lblAtributo1.Size = new Size(202, 37);
            lblAtributo1.TabIndex = 11;
            lblAtributo1.Text = "Atributo extra 1";
            // 
            // txtAtributo2
            // 
            txtAtributo2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAtributo2.Location = new Point(12, 607);
            txtAtributo2.Name = "txtAtributo2";
            txtAtributo2.Size = new Size(386, 52);
            txtAtributo2.TabIndex = 14;
            // 
            // lblAtributo2
            // 
            lblAtributo2.AutoSize = true;
            lblAtributo2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtributo2.Location = new Point(12, 567);
            lblAtributo2.Name = "lblAtributo2";
            lblAtributo2.Size = new Size(202, 37);
            lblAtributo2.TabIndex = 13;
            lblAtributo2.Text = "Atributo extra 2";
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 767);
            Controls.Add(txtAtributo2);
            Controls.Add(lblAtributo2);
            Controls.Add(txtAtributo1);
            Controls.Add(lblAtributo1);
            Controls.Add(lblTipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSubmit);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(txtVelMax);
            Controls.Add(label3);
            Controls.Add(txtAño);
            Controls.Add(label2);
            Name = "frmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancelar;
        private ToolStripMenuItem tipoVehiculoToolStripMenuItem;
        private ToolStripMenuItem autoToolStripMenuItem;
        private ToolStripMenuItem avionToolStripMenuItem;
        private ToolStripMenuItem trenToolStripMenuItem;
        private Label lblTipo;
        private Label lblAtributo1;
        private Label lblAtributo2;
        public TextBox txtAtributo1;
        public TextBox txtAtributo2;
        public Button btnSubmit;
        protected TextBox txtAño;
        protected TextBox txtVelMax;
        protected TextBox txtColor;
    }
}