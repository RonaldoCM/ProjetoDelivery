namespace View.Formularios
{
    partial class FreteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreteView));
            txbValorFrete = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txbValorFrete
            // 
            txbValorFrete.BackColor = SystemColors.Menu;
            txbValorFrete.BorderStyle = BorderStyle.None;
            txbValorFrete.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbValorFrete.Location = new Point(91, 26);
            txbValorFrete.MaxLength = 5;
            txbValorFrete.Name = "txbValorFrete";
            txbValorFrete.Size = new Size(83, 36);
            txbValorFrete.TabIndex = 2;
            txbValorFrete.Text = "0,00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 37);
            label1.TabIndex = 3;
            label1.Text = "R$";
            // 
            // FreteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 90);
            Controls.Add(label1);
            Controls.Add(txbValorFrete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FreteView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txbValorFrete;
        private Label label1;
    }
}