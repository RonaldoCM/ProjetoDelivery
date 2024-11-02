using BusinessObjects;
using Model;
using System.Data;
using View.Formularios;

namespace View.Controllers
{
    public class EditarPedidoController
    {
        private readonly EditarPedidoView _editarPedidoView;
        private readonly PessoaBO _pessoaBO;
        private readonly LogradouroBO _logradouroBO;
        private readonly CidadeBO _cidadeBO;
        private readonly PedidoBO _pedidoBO;
        private readonly ProdutoBO _produtoBO;

        public EditarPedidoController(EditarPedidoView view)
        {
            _pessoaBO = new PessoaBO();
            _logradouroBO = new LogradouroBO();
            _pedidoBO = new PedidoBO();
            _cidadeBO = new CidadeBO();
            _produtoBO = new ProdutoBO();

            _editarPedidoView = view;

            // Associa o evento Load ao método OnFormLoad
            _editarPedidoView.Load += OnFormLoad;

            _editarPedidoView.btnSalvarPedido.Click += BtnSalvarPedido_Click;
            _editarPedidoView.btnAdicionarItem.Click += BtnAdicionarItem_Click;
            _editarPedidoView.dgItensEdicaoPedido.CellClick += DgItensEdicaoPedido_CellClick;

        }

        private void DgItensEdicaoPedido_CellClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) 
            {
                if (e.ColumnIndex == 1)
                {
                    var linhaSelecionada = _editarPedidoView.dgItensEdicaoPedido.CurrentRow;
                    RemoverItemDoPedido(linhaSelecionada);
                }
            }
        }

        private void OnFormLoad(object? sender, EventArgs e)
        {
            try
            {
                _editarPedidoView.Text = "Inserção de Pedido";

                _editarPedidoView.cmbMunicipio.DataSource = _cidadeBO.GetAllCidades();
                _editarPedidoView.cmbMunicipio.DisplayMember = "Nome";
                _editarPedidoView.cmbMunicipio.ValueMember = "Id";

                _editarPedidoView.cmbTipoLogradouro.DataSource = _logradouroBO.ListarTipoLogradouro();
                _editarPedidoView.cmbTipoLogradouro.DisplayMember = "Descricao";
                _editarPedidoView.cmbTipoLogradouro.ValueMember = "Id";

                _editarPedidoView.cmbProduto.DataSource = _produtoBO.GetAllProdutos();
                _editarPedidoView.cmbProduto.DisplayMember = "Nome";
                _editarPedidoView.cmbProduto.ValueMember = "Id";

                _editarPedidoView.tlsValorTotalPedido.Text = "0,00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o formulário: " + ex.Message);
            }
        }


        private void BtnAdicionarItem_Click(object? sender, EventArgs e)
        {
            AdicionarItemAoPedido();
        }

        private void AdicionarItemAoPedido()
        {
            // Captura o item selecionado no ComboBox
            DataRowView produtoSelecionado = (DataRowView)_editarPedidoView.cmbProduto.SelectedItem;

            // Cria uma nova linha no DataGridView
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(_editarPedidoView.dgItensEdicaoPedido);

            // Adiciona os valores do produto selecionado nas colunas do DataGridView
            row.Cells[0].Value = produtoSelecionado["Id"];
            row.Cells[1].Value = "Remover";
            row.Cells[2].Value = produtoSelecionado["Nome"];
            row.Cells[3].Value = produtoSelecionado["Preco"];
            row.Cells[5].Value = produtoSelecionado["Descricao"];
            row.Cells[4].Value = _editarPedidoView.numUpDwnQuantidadeItem.Value;

            // Adiciona a nova linha no DataGridView
            _editarPedidoView.dgItensEdicaoPedido.Rows.Add(row);

            var frete = 0.00M;

            _editarPedidoView.tlsValorTotalPedido.Text = CalcularValorTotalDoPedido(frete).ToString();

        }

        private void RemoverItemDoPedido(DataGridViewRow row)
        {
            _editarPedidoView.dgItensEdicaoPedido.Rows.Remove(row);

            var frete = 0.00M;
            CalcularValorTotalDoPedido(frete);
            _editarPedidoView.tlsValorTotalPedido.Text = CalcularValorTotalDoPedido(frete).ToString();
        }

        private decimal CalcularValorTotalDoPedido(decimal frete)
        {
            decimal valorTotal = 0.00M;

            foreach (DataGridViewRow row in _editarPedidoView.dgItensEdicaoPedido.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    // Captura o preço unitário (célula 2) e a quantidade (célula 3)
                    decimal precoUnitario = Convert.ToDecimal(row.Cells[3].Value);
                    int quantidade = Convert.ToInt32(row.Cells[4].Value);

                    // Calcula o valor do item (preço unitário * quantidade)
                    decimal valorItem = precoUnitario * quantidade;

                    // Soma ao total
                    valorTotal += valorItem;
                }
            }

            return valorTotal + frete;
        }

        private void BtnSalvarPedido_Click(object? sender, EventArgs e)
        {
            SalvarPedido();

        }

        private void SalvarPedido()
        {
            try
            {
                IsValidated();

                //Salva pessoa - aguarda retorno
                string nome = _editarPedidoView.txtNomeCliente.Text;
                string senha = string.Empty;

                // Cria o Model com os dados da View
                Pessoa pessoa = new Pessoa(nome, senha);

                // Chama o método de negócio para adicionar a pessoa
                bool resultado = _pessoaBO.AdicionarPessoa(pessoa);

                int cidadeLogradouro = _editarPedidoView.cmbMunicipio.SelectedIndex;
                int tipoLogradouro = _editarPedidoView.cmbTipoLogradouro.SelectedIndex;
                string descricaoLogradouro = _editarPedidoView.txtEnderecoCliente.Text;
                string numeroCasaLogradouro = _editarPedidoView.txtNumeroCasaCliente.Text;
                string bairroLogradouro = _editarPedidoView.txtBairroCliente.Text;

                //carregar o objeto TipoLogradouro para enviar
                Logradouro logradouro = new Logradouro(descricaoLogradouro, numeroCasaLogradouro, tipoLogradouro, cidadeLogradouro);

                //Salva endereço - aguarda retorno
                _logradouroBO.AdicionarLogradouro(logradouro);

                FreteView frete = new FreteView();

                FreteController freteController = new FreteController(frete);

                frete.ShowDialog();
                var vFrete = frete.txbValorFrete.Text;

                string codigoPedido = "CEC1966";
                decimal valorFrete = decimal.Parse(vFrete);
                decimal valorTotalPedido = CalcularValorTotalDoPedido(valorFrete);
                int idSituacao = 1; //Criado
                int idCliente = 1; //Inserir o ID criado no insert de pessoa acima.


                List<ItensPedido> itensPedido = new List<ItensPedido>();

                //DEVE IR PARA DENTRO DO FOREACH
                // Captura os dados das células da linha atual
                int idProduto = 1;   //Convert.ToInt32(row.Cells["IdProduto"].Value);
                int quantidade = 1;   //Convert.ToInt32(row.Cells["Quantidade"].Value);
                decimal precoUnitario = 25.5M; //Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);

                // Cria um novo item do pedido
                ItensPedido item = new ItensPedido
                {
                    IdProduto = idProduto,
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario

                };

                itensPedido.Add(item);

                //loop para pegar os dados do datagrid e inserir na lista de itens do pedido.
                foreach (DataGridViewRow row in _editarPedidoView.dgItensEdicaoPedido.Rows)
                {
                    //// Captura os dados das células da linha atual
                    //int idProduto = 1;   //Convert.ToInt32(row.Cells["IdProduto"].Value);
                    //int quantidade = 1;   //Convert.ToInt32(row.Cells["Quantidade"].Value);
                    //decimal precoUnitario = 25.5M; //Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);

                    //// Cria um novo item do pedido
                    //ItensPedido item = new ItensPedido
                    //{
                    //    IdProduto = idProduto,
                    //    Quantidade = quantidade,
                    //    PrecoUnitario = precoUnitario

                    //};

                    //itensPedido.Add(item);

                }


                //Salva pedido + Itens
                Pedido pedido = new Pedido(codigoPedido, DateTime.Now, valorFrete, valorTotalPedido, idSituacao, idCliente, itensPedido);

                var inserido = _pedidoBO.AdicionarPedido(pedido);






                //Limpa tela
                //Atualiza tela de trás.
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditarPedido()
        {
            // Se for uma edição de pedido, carregar os dados existentes no formulário
            //int pedidoId = 1; // Exemplo de ID do pedido
            //var table = _pedidoBO.BuscarPedidoPorId(pedidoId); // Método fictício para buscar um pedido pelo ID

            //if (table.Rows.Count > 0)
            //{
            // Preenche os campos com os dados do pedido (se o retorno fosse um tipo de Pedido).
            //_editarPedidoView.txtNomeCliente.Text = pedido.Cliente.Nome;
            //_editarPedidoView.txtEnderecoCliente.Text = pedido.Logradouro.Descricao;
            //_editarPedidoView.txtNumeroCasaCliente.Text = pedido.Logradouro.Numero;
            //_editarPedidoView.txtBairroCliente.Text = pedido.Logradouro.Bairro;
            //_editarPedidoView.txtValorFrete.Text = pedido.ValorFrete.ToString();

            //_editarPedidoView.txtNomeCliente.Text = table.Rows[0]["NOME"].ToString();
            //_editarPedidoView.txtEnderecoCliente.Text = table.Rows[0]["DESCRICAO"].ToString();
            //_editarPedidoView.txtNumeroCasaCliente.Text = table.Rows[0]["NUMERO"].ToString();
            //_editarPedidoView.txtBairroCliente.Text = table.Rows[0]["BAIRRO"].ToString();
            //_editarPedidoView.txtValorFrete.Text = table.Rows[0]["VALORFRETE"].ToString();


            // Preencher DataGridView com os itens do pedido, se necessário
            //_editarPedidoView.dgItensEdicaoPedido.DataSource = pedido.ItensPedido;


            //}

        }

        private void IsValidated()
        {
            if (string.IsNullOrEmpty(_editarPedidoView.txtNomeCliente.Text))
                throw new Exception("O Nome do Cliente é obrigatório");

            if (_editarPedidoView.cmbTipoLogradouro.SelectedItem == null)
                throw new Exception("O Logradouro do Cliente é obrigatório");

            if (string.IsNullOrEmpty(_editarPedidoView.txtEnderecoCliente.Text))
                throw new Exception("O Endereço do Cliente é obrigatório");

            if (string.IsNullOrEmpty(_editarPedidoView.txtNumeroCasaCliente.Text))
                throw new Exception("O Número da Casa do Cliente é obrigatório");

            if (string.IsNullOrEmpty(_editarPedidoView.txtBairroCliente.Text))
                throw new Exception("O Bairro do Cliente é obrigatório");

        }

        private void DeletarPedido()
        {

        }

        private void BuscarPedido()
        {

        }

    }
}
