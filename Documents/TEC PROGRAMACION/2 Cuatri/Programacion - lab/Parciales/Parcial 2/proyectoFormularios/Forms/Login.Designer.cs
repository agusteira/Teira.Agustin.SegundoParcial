namespace Teira.Agustin.PrimerParcial.Forms
{
    partial class Login
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
            txtMail = new TextBox();
            txtPassword = new TextBox();
            labelMail = new Label();
            label1 = new Label();
            btnLogin = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(35, 87);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(521, 34);
            txtMail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(35, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(521, 34);
            txtPassword.TabIndex = 1;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.Location = new Point(25, 30);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(294, 54);
            labelMail.TabIndex = 2;
            labelMail.Text = "Ingrese Correo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 155);
            label1.Name = "label1";
            label1.Size = new Size(374, 54);
            label1.TabIndex = 3;
            label1.Text = "Ingrese Contraseña:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(189, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(176, 71);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(371, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(185, 71);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 334);
            Controls.Add(btnCancelar);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(labelMail);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtPassword;
        private Label labelMail;
        private Label label1;
        private Button btnLogin;
        private Button btnCancelar;
    }
}