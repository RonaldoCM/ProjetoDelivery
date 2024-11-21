namespace View.Formularios
{
    partial class EditarPedidoView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPedidoView));
            pnlEditarPedidos = new Panel();
            lblQuantidade = new Label();
            numUpDwnQuantidadeItem = new NumericUpDown();
            cmbMunicipio = new ComboBox();
            lblMunicipio = new Label();
            cmbTipoLogradouro = new ComboBox();
            btnCancelarEdicaoPedido = new Button();
            btnSalvarPedido = new Button();
            btnAdicionarItem = new Button();
            lblProduto = new Label();
            lblBairroCliente = new Label();
            txtBairroCliente = new TextBox();
            cmbProduto = new ComboBox();
            pnlItensEdicaoPedido = new Panel();
            toolStripMenuGrid = new ToolStrip();
            tstplabelTotalPedido = new ToolStripLabel();
            tlsCifra = new ToolStripLabel();
            tlsValorTotalPedido = new ToolStripLabel();
            dgItensEdicaoPedido = new DataGridView();
            lblNumeroCasaCliente = new Label();
            lblEnderecoCliente = new Label();
            lblNomeCliente = new Label();
            txtNumeroCasaCliente = new TextBox();
            txtEnderecoCliente = new TextBox();
            txtNomeCliente = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            COLREMOVERITEM = new DataGridViewButtonColumn();
            COLNOMEPRODUTO = new DataGridViewTextBoxColumn();
            COLPRECOPRODUTO = new DataGridViewTextBoxColumn();
            COLQUANTIDADEITEMPEDIDO = new DataGridViewTextBoxColumn();
            COLDESCRICAOPRODUTO = new DataGridViewTextBoxColumn();
            pnlEditarPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDwnQuantidadeItem).BeginInit();
            pnlItensEdicaoPedido.SuspendLayout();
            toolStripMenuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgItensEdicaoPedido).BeginInit();
            SuspendLayout();
            // 
            // pnlEditarPedidos
            // 
            pnlEditarPedidos.Controls.Add(lblQuantidade);
            pnlEditarPedidos.Controls.Add(numUpDwnQuantidadeItem);
            pnlEditarPedidos.Controls.Add(cmbMunicipio);
            pnlEditarPedidos.Controls.Add(lblMunicipio);
            pnlEditarPedidos.Controls.Add(cmbTipoLogradouro);
            pnlEditarPedidos.Controls.Add(btnCancelarEdicaoPedido);
            pnlEditarPedidos.Controls.Add(btnSalvarPedido);
            pnlEditarPedidos.Controls.Add(btnAdicionarItem);
            pnlEditarPedidos.Controls.Add(lblProduto);
            pnlEditarPedidos.Controls.Add(lblBairroCliente);
            pnlEditarPedidos.Controls.Add(txtBairroCliente);
            pnlEditarPedidos.Controls.Add(cmbProduto);
            pnlEditarPedidos.Controls.Add(pnlItensEdicaoPedido);
            pnlEditarPedidos.Controls.Add(lblNumeroCasaCliente);
            pnlEditarPedidos.Controls.Add(lblEnderecoCliente);
            pnlEditarPedidos.Controls.Add(lblNomeCliente);
            pnlEditarPedidos.Controls.Add(txtNumeroCasaCliente);
            pnlEditarPedidos.Controls.Add(txtEnderecoCliente);
            pnlEditarPedidos.Controls.Add(txtNomeCliente);
            pnlEditarPedidos.Dock = DockStyle.Fill;
            pnlEditarPedidos.Location = new Point(0, 0);
            pnlEditarPedidos.Name = "pnlEditarPedidos";
            pnlEditarPedidos.Size = new Size(561, 498);
            pnlEditarPedidos.TabIndex = 0;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(300, 206);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 21;
            lblQuantidade.Text = "Quantidade";
            // 
            // numUpDwnQuantidadeItem
            // 
            numUpDwnQuantidadeItem.Location = new Point(300, 223);
            numUpDwnQuantidadeItem.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDwnQuantidadeItem.Name = "numUpDwnQuantidadeItem";
            numUpDwnQuantidadeItem.Size = new Size(69, 23);
            numUpDwnQuantidadeItem.TabIndex = 20;
            numUpDwnQuantidadeItem.TextAlign = HorizontalAlignment.Center;
            numUpDwnQuantidadeItem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.FormattingEnabled = true;
            cmbMunicipio.Location = new Point(12, 80);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(201, 23);
            cmbMunicipio.TabIndex = 19;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(12, 62);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(61, 15);
            lblMunicipio.TabIndex = 18;
            lblMunicipio.Text = "Município";
            // 
            // cmbTipoLogradouro
            // 
            cmbTipoLogradouro.FormattingEnabled = true;
            cmbTipoLogradouro.Location = new Point(12, 124);
            cmbTipoLogradouro.Name = "cmbTipoLogradouro";
            cmbTipoLogradouro.Size = new Size(104, 23);
            cmbTipoLogradouro.TabIndex = 16;
            // 
            // btnCancelarEdicaoPedido
            // 
            btnCancelarEdicaoPedido.Location = new Point(323, 465);
            btnCancelarEdicaoPedido.Name = "btnCancelarEdicaoPedido";
            btnCancelarEdicaoPedido.Size = new Size(111, 26);
            btnCancelarEdicaoPedido.TabIndex = 10;
            btnCancelarEdicaoPedido.Text = "Cancelar";
            btnCancelarEdicaoPedido.UseVisualStyleBackColor = true;
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.Location = new Point(440, 465);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(111, 26);
            btnSalvarPedido.TabIndex = 11;
            btnSalvarPedido.Text = "Salvar";
            btnSalvarPedido.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackgroundImage = Properties.Resources.add1;
            btnAdicionarItem.BackgroundImageLayout = ImageLayout.None;
            btnAdicionarItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarItem.Location = new Point(375, 220);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(101, 26);
            btnAdicionarItem.TabIndex = 8;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(12, 205);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 12;
            lblProduto.Text = "Produto";
            // 
            // lblBairroCliente
            // 
            lblBairroCliente.AutoSize = true;
            lblBairroCliente.Location = new Point(12, 152);
            lblBairroCliente.Name = "lblBairroCliente";
            lblBairroCliente.Size = new Size(38, 15);
            lblBairroCliente.TabIndex = 11;
            lblBairroCliente.Text = "Bairro";
            // 
            // txtBairroCliente
            // 
            txtBairroCliente.Location = new Point(12, 170);
            txtBairroCliente.Name = "txtBairroCliente";
            txtBairroCliente.Size = new Size(340, 23);
            txtBairroCliente.TabIndex = 5;
            // 
            // cmbProduto
            // 
            cmbProduto.BackColor = SystemColors.ControlLightLight;
            cmbProduto.ForeColor = Color.Black;
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(12, 223);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(282, 23);
            cmbProduto.TabIndex = 7;
            // 
            // pnlItensEdicaoPedido
            // 
            pnlItensEdicaoPedido.Controls.Add(toolStripMenuGrid);
            pnlItensEdicaoPedido.Controls.Add(dgItensEdicaoPedido);
            pnlItensEdicaoPedido.Location = new Point(12, 252);
            pnlItensEdicaoPedido.Name = "pnlItensEdicaoPedido";
            pnlItensEdicaoPedido.Size = new Size(539, 207);
            pnlItensEdicaoPedido.TabIndex = 8;
            // 
            // toolStripMenuGrid
            // 
            toolStripMenuGrid.Items.AddRange(new ToolStripItem[] { tstplabelTotalPedido, tlsCifra, tlsValorTotalPedido });
            toolStripMenuGrid.Location = new Point(0, 0);
            toolStripMenuGrid.Name = "toolStripMenuGrid";
            toolStripMenuGrid.Size = new Size(539, 25);
            toolStripMenuGrid.TabIndex = 1;
            toolStripMenuGrid.Text = "toolStripMenuGrid";
            // 
            // tstplabelTotalPedido
            // 
            tstplabelTotalPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tstplabelTotalPedido.Name = "tstplabelTotalPedido";
            tstplabelTotalPedido.Size = new Size(135, 22);
            tstplabelTotalPedido.Text = "Valor Total do Pedido";
            // 
            // tlsCifra
            // 
            tlsCifra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlsCifra.ForeColor = Color.Blue;
            tlsCifra.Name = "tlsCifra";
            tlsCifra.Size = new Size(23, 22);
            tlsCifra.Text = "R$";
            // 
            // tlsValorTotalPedido
            // 
            tlsValorTotalPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlsValorTotalPedido.ForeColor = Color.Blue;
            tlsValorTotalPedido.Name = "tlsValorTotalPedido";
            tlsValorTotalPedido.Size = new Size(17, 22);
            tlsValorTotalPedido.Text = "...";
            // 
            // dgItensEdicaoPedido
            // 
            dgItensEdicaoPedido.AllowUserToAddRows = false;
            dgItensEdicaoPedido.AllowUserToDeleteRows = false;
            dgItensEdicaoPedido.BackgroundColor = SystemColors.ControlLight;
            dgItensEdicaoPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItensEdicaoPedido.Columns.AddRange(new DataGridViewColumn[] { ID, COLREMOVERITEM, COLNOMEPRODUTO, COLPRECOPRODUTO, COLQUANTIDADEITEMPEDIDO, COLDESCRICAOPRODUTO });
            dgItensEdicaoPedido.Dock = DockStyle.Bottom;
            dgItensEdicaoPedido.Location = new Point(0, 28);
            dgItensEdicaoPedido.MultiSelect = false;
            dgItensEdicaoPedido.Name = "dgItensEdicaoPedido";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgItensEdicaoPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgItensEdicaoPedido.RowHeadersVisible = false;
            dgItensEdicaoPedido.RowHeadersWidth = 45;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgItensEdicaoPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgItensEdicaoPedido.RowTemplate.Height = 20;
            dgItensEdicaoPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgItensEdicaoPedido.Size = new Size(539, 179);
            dgItensEdicaoPedido.TabIndex = 9;
            // 
            // lblNumeroCasaCliente
            // 
            lblNumeroCasaCliente.AutoSize = true;
            lblNumeroCasaCliente.Location = new Point(468, 106);
            lblNumeroCasaCliente.Name = "lblNumeroCasaCliente";
            lblNumeroCasaCliente.Size = new Size(51, 15);
            lblNumeroCasaCliente.TabIndex = 7;
            lblNumeroCasaCliente.Text = "Número";
            // 
            // lblEnderecoCliente
            // 
            lblEnderecoCliente.AutoSize = true;
            lblEnderecoCliente.Location = new Point(12, 106);
            lblEnderecoCliente.Name = "lblEnderecoCliente";
            lblEnderecoCliente.Size = new Size(69, 15);
            lblEnderecoCliente.TabIndex = 6;
            lblEnderecoCliente.Text = "Logradouro";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(12, 18);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(44, 15);
            lblNomeCliente.TabIndex = 4;
            lblNomeCliente.Text = "Cliente";
            // 
            // txtNumeroCasaCliente
            // 
            txtNumeroCasaCliente.Location = new Point(468, 124);
            txtNumeroCasaCliente.Name = "txtNumeroCasaCliente";
            txtNumeroCasaCliente.Size = new Size(83, 23);
            txtNumeroCasaCliente.TabIndex = 4;
            // 
            // txtEnderecoCliente
            // 
            txtEnderecoCliente.Location = new Point(122, 124);
            txtEnderecoCliente.Name = "txtEnderecoCliente";
            txtEnderecoCliente.Size = new Size(340, 23);
            txtEnderecoCliente.TabIndex = 3;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(12, 36);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(201, 23);
            txtNomeCliente.TabIndex = 2;
            // 
            // ID
            // 
            ID.DataPropertyName = "IDPRODUTO";
            ID.Frozen = true;
            ID.HeaderText = "ID Produto";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // COLREMOVERITEM
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            COLREMOVERITEM.DefaultCellStyle = dataGridViewCellStyle1;
            COLREMOVERITEM.Frozen = true;
            COLREMOVERITEM.HeaderText = "";
            COLREMOVERITEM.Name = "COLREMOVERITEM";
            COLREMOVERITEM.Resizable = DataGridViewTriState.False;
            COLREMOVERITEM.Text = "Remover";
            COLREMOVERITEM.ToolTipText = "Remover Item";
            COLREMOVERITEM.Width = 60;
            // 
            // COLNOMEPRODUTO
            // 
            COLNOMEPRODUTO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            COLNOMEPRODUTO.DataPropertyName = "NOMEPRODUTO";
            COLNOMEPRODUTO.Frozen = true;
            COLNOMEPRODUTO.HeaderText = "Nome Produto";
            COLNOMEPRODUTO.Name = "COLNOMEPRODUTO";
            COLNOMEPRODUTO.Width = 111;
            // 
            // COLPRECOPRODUTO
            // 
            COLPRECOPRODUTO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            COLPRECOPRODUTO.DataPropertyName = "PRECOPRODUTO";
            COLPRECOPRODUTO.Frozen = true;
            COLPRECOPRODUTO.HeaderText = "Preço";
            COLPRECOPRODUTO.Name = "COLPRECOPRODUTO";
            COLPRECOPRODUTO.Width = 62;
            // 
            // COLQUANTIDADEITEMPEDIDO
            // 
            COLQUANTIDADEITEMPEDIDO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            COLQUANTIDADEITEMPEDIDO.DataPropertyName = "QUANTIDADEITEMPEDIDO";
            COLQUANTIDADEITEMPEDIDO.Frozen = true;
            COLQUANTIDADEITEMPEDIDO.HeaderText = "Quantidade";
            COLQUANTIDADEITEMPEDIDO.Name = "COLQUANTIDADEITEMPEDIDO";
            COLQUANTIDADEITEMPEDIDO.Width = 94;
            // 
            // COLDESCRICAOPRODUTO
            // 
            COLDESCRICAOPRODUTO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COLDESCRICAOPRODUTO.DataPropertyName = "DESCRICAOPRODUTO";
            COLDESCRICAOPRODUTO.HeaderText = "Descrição";
            COLDESCRICAOPRODUTO.Name = "COLDESCRICAOPRODUTO";
            // 
            // EditarPedidoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 498);
            Controls.Add(pnlEditarPedidos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditarPedidoView";
            StartPosition = FormStartPosition.CenterScreen;
            pnlEditarPedidos.ResumeLayout(false);
            pnlEditarPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDwnQuantidadeItem).EndInit();
            pnlItensEdicaoPedido.ResumeLayout(false);
            pnlItensEdicaoPedido.PerformLayout();
            toolStripMenuGrid.ResumeLayout(false);
            toolStripMenuGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgItensEdicaoPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEditarPedidos;
        private Panel pnlItensEdicaoPedido;
        private Label lblNumeroCasaCliente;
        private Label lblEnderecoCliente;
        private Label lblNomeCliente;
        private Label lblBairroCliente;
        private Label lblProduto;
        public Button btnAdicionarItem;
        private ToolStrip toolStripMenuGrid;
        private ToolStripLabel tstplabelTotalPedido;
        private ToolStripLabel tlsCifra;
        public Button btnCancelarEdicaoPedido;
        public Button btnSalvarPedido;
        private Label lblMunicipio;
        public TextBox txtNumeroCasaCliente;
        public TextBox txtEnderecoCliente;
        public TextBox txtNomeCliente;
        public TextBox txtBairroCliente;
        public ComboBox cmbTipoLogradouro;
        public ComboBox cmbMunicipio;
        public ToolStripLabel tlsValorTotalPedido;
        public DataGridView dgItensEdicaoPedido;
        public ComboBox cmbProduto;
        public NumericUpDown numUpDwnQuantidadeItem;
        private Label lblQuantidade;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn COLREMOVERITEM;
        private DataGridViewTextBoxColumn COLNOMEPRODUTO;
        private DataGridViewTextBoxColumn COLPRECOPRODUTO;
        private DataGridViewTextBoxColumn COLQUANTIDADEITEMPEDIDO;
        private DataGridViewTextBoxColumn COLDESCRICAOPRODUTO;
    }
}