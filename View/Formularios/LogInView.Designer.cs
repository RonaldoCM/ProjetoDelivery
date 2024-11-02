namespace View.Formularios
{
    partial class LogInView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInView));
            pnlLogIn = new Panel();
            pctrBoxLogIn = new PictureBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogIn = new Button();
            pnlLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBoxLogIn).BeginInit();
            SuspendLayout();
            // 
            // pnlLogIn
            // 
            pnlLogIn.BackColor = Color.CadetBlue;
            pnlLogIn.BackgroundImageLayout = ImageLayout.None;
            pnlLogIn.Controls.Add(pctrBoxLogIn);
            pnlLogIn.Controls.Add(txtUsuario);
            pnlLogIn.Controls.Add(txtSenha);
            pnlLogIn.Controls.Add(btnLogIn);
            pnlLogIn.Dock = DockStyle.Fill;
            pnlLogIn.Location = new Point(0, 0);
            pnlLogIn.Name = "pnlLogIn";
            pnlLogIn.Size = new Size(300, 294);
            pnlLogIn.TabIndex = 0;
            // 
            // pctrBoxLogIn
            // 
            pctrBoxLogIn.Image = (Image)resources.GetObject("pctrBoxLogIn.Image");
            pctrBoxLogIn.Location = new Point(75, 35);
            pctrBoxLogIn.Name = "pctrBoxLogIn";
            pctrBoxLogIn.Size = new Size(154, 85);
            pctrBoxLogIn.SizeMode = PictureBoxSizeMode.CenterImage;
            pctrBoxLogIn.TabIndex = 3;
            pctrBoxLogIn.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(52, 143);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(202, 25);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(52, 184);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(202, 25);
            txtSenha.TabIndex = 2;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(92, 229);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(121, 37);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Entrar";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 294);
            Controls.Add(pnlLogIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            pnlLogIn.ResumeLayout(false);
            pnlLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBoxLogIn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogIn;
        private PictureBox pctrBoxLogIn;
        public Button btnLogIn;
        public TextBox txtUsuario;
        public TextBox txtSenha;
    }
}