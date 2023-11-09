namespace Teira.Agustin.PrimerParcial.Forms
{
    partial class frmElegirTipo
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
            btnAuto = new Button();
            btnAvion = new Button();
            btnTren = new Button();
            SuspendLayout();
            // 
            // btnAuto
            // 
            btnAuto.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuto.Location = new Point(12, 47);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(177, 100);
            btnAuto.TabIndex = 0;
            btnAuto.Text = "AUTO";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnAvion
            // 
            btnAvion.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAvion.Location = new Point(215, 47);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(177, 100);
            btnAvion.TabIndex = 1;
            btnAvion.Text = "AVION";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // btnTren
            // 
            btnTren.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnTren.Location = new Point(420, 47);
            btnTren.Name = "btnTren";
            btnTren.Size = new Size(177, 100);
            btnTren.TabIndex = 2;
            btnTren.Text = "TREN";
            btnTren.UseVisualStyleBackColor = true;
            btnTren.Click += btnTren_Click;
            // 
            // frmElegirTipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 197);
            Controls.Add(btnTren);
            Controls.Add(btnAvion);
            Controls.Add(btnAuto);
            Name = "frmElegirTipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmElegirTipo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAuto;
        private Button btnAvion;
        private Button btnTren;
    }
}