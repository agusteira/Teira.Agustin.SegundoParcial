namespace Proyecto_de_forms.Forms.frmAcciones
{
    partial class visualizadorLogins
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
            lstLogins = new ListBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lstLogins
            // 
            lstLogins.FormattingEnabled = true;
            lstLogins.ItemHeight = 15;
            lstLogins.Location = new Point(0, 0);
            lstLogins.Name = "lstLogins";
            lstLogins.Size = new Size(788, 394);
            lstLogins.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(313, 400);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 54);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // visualizadorLogins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(btnVolver);
            Controls.Add(lstLogins);
            Name = "visualizadorLogins";
            Text = "visualizadorLogins";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstLogins;
        private Button btnVolver;
    }
}