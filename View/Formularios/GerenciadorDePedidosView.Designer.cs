namespace View.Formularios
{
    partial class GerenciadorDePedidosView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorDePedidosView));
            pnlPedidos = new Panel();
            dgPedidos = new DataGridView();
            btnNovoPedido = new Button();
            pnlMenuGerenciadorDePedidos = new Panel();
            btnCancelarPedido = new Button();
            btnEditarPedido = new Button();
            pnlItens = new Panel();
            dgItens = new DataGridView();
            lblPedidos = new Label();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            pnlPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            pnlMenuGerenciadorDePedidos.SuspendLayout();
            pnlItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgItens).BeginInit();
            SuspendLayout();
            // 
            // pnlPedidos
            // 
            pnlPedidos.Controls.Add(dgPedidos);
            pnlPedidos.Location = new Point(180, 33);
            pnlPedidos.Name = "pnlPedidos";
            pnlPedidos.Size = new Size(848, 206);
            pnlPedidos.TabIndex = 0;
            // 
            // dgPedidos
            // 
            dgPedidos.BackgroundColor = Color.WhiteSmoke;
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidos.Dock = DockStyle.Fill;
            dgPedidos.Location = new Point(0, 0);
            dgPedidos.Name = "dgPedidos";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPedidos.RowHeadersVisible = false;
            dgPedidos.RowHeadersWidth = 45;
            dgPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgPedidos.Size = new Size(848, 206);
            dgPedidos.TabIndex = 0;
            // 
            // btnNovoPedido
            // 
            btnNovoPedido.Location = new Point(6, 33);
            btnNovoPedido.Name = "btnNovoPedido";
            btnNovoPedido.Size = new Size(130, 50);
            btnNovoPedido.TabIndex = 1;
            btnNovoPedido.Text = "Novo Pedido";
            btnNovoPedido.UseVisualStyleBackColor = true;
            // 
            // pnlMenuGerenciadorDePedidos
            // 
            pnlMenuGerenciadorDePedidos.BackColor = Color.CadetBlue;
            pnlMenuGerenciadorDePedidos.BorderStyle = BorderStyle.FixedSingle;
            pnlMenuGerenciadorDePedidos.Controls.Add(btnCancelarPedido);
            pnlMenuGerenciadorDePedidos.Controls.Add(btnEditarPedido);
            pnlMenuGerenciadorDePedidos.Controls.Add(btnNovoPedido);
            pnlMenuGerenciadorDePedidos.Dock = DockStyle.Left;
            pnlMenuGerenciadorDePedidos.Location = new Point(0, 0);
            pnlMenuGerenciadorDePedidos.Name = "pnlMenuGerenciadorDePedidos";
            pnlMenuGerenciadorDePedidos.Size = new Size(152, 519);
            pnlMenuGerenciadorDePedidos.TabIndex = 2;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Location = new Point(6, 151);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(130, 50);
            btnCancelarPedido.TabIndex = 3;
            btnCancelarPedido.Text = "Cancelar Pedido";
            btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.Location = new Point(6, 92);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(130, 50);
            btnEditarPedido.TabIndex = 2;
            btnEditarPedido.Text = "Editar Pedido";
            btnEditarPedido.UseVisualStyleBackColor = true;
            // 
            // pnlItens
            // 
            pnlItens.Controls.Add(dgItens);
            pnlItens.Location = new Point(180, 290);
            pnlItens.Name = "pnlItens";
            pnlItens.Size = new Size(847, 206);
            pnlItens.TabIndex = 1;
            // 
            // dgItens
            // 
            dgItens.BackgroundColor = Color.WhiteSmoke;
            dgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItens.Dock = DockStyle.Fill;
            dgItens.Location = new Point(0, 0);
            dgItens.Name = "dgItens";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgItens.RowHeadersVisible = false;
            dgItens.RowHeadersWidth = 45;
            dgItens.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgItens.Size = new Size(847, 206);
            dgItens.TabIndex = 0;
            // 
            // lblPedidos
            // 
            lblPedidos.AutoSize = true;
            lblPedidos.Font = new Font("Franklin Gothic Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedidos.Location = new Point(180, 9);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(59, 20);
            lblPedidos.TabIndex = 3;
            lblPedidos.Text = "Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 255);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 4;
            label2.Text = "Itens do Pedido";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Location = new Point(152, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(888, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // GerenciadorDePedidosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 519);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Controls.Add(lblPedidos);
            Controls.Add(pnlItens);
            Controls.Add(pnlMenuGerenciadorDePedidos);
            Controls.Add(pnlPedidos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GerenciadorDePedidosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador De Pedidos";
            pnlPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            pnlMenuGerenciadorDePedidos.ResumeLayout(false);
            pnlItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPedidos;
        private DataGridView dgPedidos;
        private Panel pnlMenuGerenciadorDePedidos;
        private Button btnCancelarPedido;
        private Panel pnlItens;
        private DataGridView dgItens;
        private Label lblPedidos;
        private Label label2;
        public Button btnNovoPedido;
        public Button btnEditarPedido;
        private StatusStrip statusStrip1;
    }
}