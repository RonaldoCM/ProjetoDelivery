namespace View.Formularios
{
    partial class MenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
            pnlMenuSuperior = new Panel();
            btnConfiguracoes = new Button();
            btnCadastroDeProdutos = new Button();
            btnCadastroDePessoas = new Button();
            btnGerenciadorDePedidos = new Button();
            pnlMenuCentral = new Panel();
            barraStatus = new StatusStrip();
            stsLabelUsuario = new ToolStripStatusLabel();
            stsLabelNomeUsuario = new ToolStripStatusLabel();
            pnlMenuSuperior.SuspendLayout();
            pnlMenuCentral.SuspendLayout();
            barraStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuSuperior
            // 
            pnlMenuSuperior.BackColor = Color.CadetBlue;
            pnlMenuSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlMenuSuperior.Controls.Add(btnConfiguracoes);
            pnlMenuSuperior.Controls.Add(btnCadastroDeProdutos);
            pnlMenuSuperior.Controls.Add(btnCadastroDePessoas);
            pnlMenuSuperior.Controls.Add(btnGerenciadorDePedidos);
            pnlMenuSuperior.Dock = DockStyle.Left;
            pnlMenuSuperior.Location = new Point(0, 0);
            pnlMenuSuperior.Name = "pnlMenuSuperior";
            pnlMenuSuperior.Size = new Size(152, 436);
            pnlMenuSuperior.TabIndex = 0;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.Location = new Point(9, 204);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Size = new Size(130, 50);
            btnConfiguracoes.TabIndex = 3;
            btnConfiguracoes.Text = "Configurações";
            btnConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // btnCadastroDeProdutos
            // 
            btnCadastroDeProdutos.Location = new Point(9, 148);
            btnCadastroDeProdutos.Name = "btnCadastroDeProdutos";
            btnCadastroDeProdutos.Size = new Size(130, 50);
            btnCadastroDeProdutos.TabIndex = 2;
            btnCadastroDeProdutos.Text = "Cadastro de Produtos";
            btnCadastroDeProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCadastroDePessoas
            // 
            btnCadastroDePessoas.Location = new Point(9, 92);
            btnCadastroDePessoas.Name = "btnCadastroDePessoas";
            btnCadastroDePessoas.Size = new Size(130, 50);
            btnCadastroDePessoas.TabIndex = 1;
            btnCadastroDePessoas.Text = "Cadastro de Pessoas";
            btnCadastroDePessoas.UseVisualStyleBackColor = true;
            // 
            // btnGerenciadorDePedidos
            // 
            btnGerenciadorDePedidos.Location = new Point(9, 36);
            btnGerenciadorDePedidos.Name = "btnGerenciadorDePedidos";
            btnGerenciadorDePedidos.Size = new Size(130, 50);
            btnGerenciadorDePedidos.TabIndex = 0;
            btnGerenciadorDePedidos.Text = "Gerenciador de Pedidos";
            btnGerenciadorDePedidos.UseVisualStyleBackColor = true;
            // 
            // pnlMenuCentral
            // 
            pnlMenuCentral.BackColor = Color.LightBlue;
            pnlMenuCentral.BackgroundImage = Properties.Resources.pacote_de_caixas_de_papelao_sinal_de_icone_de_armazem_ou_conceito_de_comercio_eletronico_de_simbolo_em_ilustracao_3d_de_fundo_azul;
            pnlMenuCentral.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMenuCentral.Controls.Add(barraStatus);
            pnlMenuCentral.Dock = DockStyle.Fill;
            pnlMenuCentral.Location = new Point(152, 0);
            pnlMenuCentral.Name = "pnlMenuCentral";
            pnlMenuCentral.Size = new Size(760, 436);
            pnlMenuCentral.TabIndex = 1;
            // 
            // barraStatus
            // 
            barraStatus.BackColor = SystemColors.Control;
            barraStatus.Items.AddRange(new ToolStripItem[] { stsLabelUsuario, stsLabelNomeUsuario });
            barraStatus.Location = new Point(0, 414);
            barraStatus.Name = "barraStatus";
            barraStatus.RightToLeft = RightToLeft.Yes;
            barraStatus.Size = new Size(760, 22);
            barraStatus.TabIndex = 0;
            barraStatus.Text = "statusStrip1";
            // 
            // stsLabelUsuario
            // 
            stsLabelUsuario.Name = "stsLabelUsuario";
            stsLabelUsuario.Size = new Size(50, 17);
            stsLabelUsuario.Text = "Usuário:";
            // 
            // stsLabelNomeUsuario
            // 
            stsLabelNomeUsuario.Name = "stsLabelNomeUsuario";
            stsLabelNomeUsuario.Size = new Size(16, 17);
            stsLabelNomeUsuario.Text = "...";
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 436);
            Controls.Add(pnlMenuCentral);
            Controls.Add(pnlMenuSuperior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlMenuSuperior.ResumeLayout(false);
            pnlMenuCentral.ResumeLayout(false);
            pnlMenuCentral.PerformLayout();
            barraStatus.ResumeLayout(false);
            barraStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuSuperior;
        private Panel pnlMenuCentral;
        private StatusStrip barraStatus;
        private ToolStripStatusLabel stsLabelUsuario;
        private ToolStripStatusLabel stsLabelNomeUsuario;
        private Button btnCadastroDePessoas;
        private Button btnCadastroDeProdutos;
        private Button btnConfiguracoes;
        public Button btnGerenciadorDePedidos;
    }
}