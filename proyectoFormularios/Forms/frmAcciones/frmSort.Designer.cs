namespace Proyecto_de_forms.Forms.frmAcciones
{
    partial class frmSort
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
            btnVelocidad = new Button();
            btnAño = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVelocidad
            // 
            btnVelocidad.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnVelocidad.Location = new Point(280, 87);
            btnVelocidad.Name = "btnVelocidad";
            btnVelocidad.Size = new Size(244, 100);
            btnVelocidad.TabIndex = 3;
            btnVelocidad.Text = "VELOCIDAD";
            btnVelocidad.UseVisualStyleBackColor = true;
            btnVelocidad.Click += btnVelocidad_Click;
            // 
            // btnAño
            // 
            btnAño.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAño.Location = new Point(12, 87);
            btnAño.Name = "btnAño";
            btnAño.Size = new Size(262, 100);
            btnAño.TabIndex = 2;
            btnAño.Text = "AÑO";
            btnAño.UseVisualStyleBackColor = true;
            btnAño.Click += btnAño_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(126, 15);
            label1.Name = "label1";
            label1.Size = new Size(292, 54);
            label1.TabIndex = 4;
            label1.Text = "ORDENAR POR";
            // 
            // frmSort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 215);
            Controls.Add(label1);
            Controls.Add(btnVelocidad);
            Controls.Add(btnAño);
            Name = "frmSort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVelocidad;
        private Button btnAño;
        private Label label1;
    }
}