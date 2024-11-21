using View.Formularios;
using BusinessObjects;
using Model;


namespace View.Controllers
{
    public class PessoaController
    {
        private readonly PessoaView _view;
        private readonly PessoaBO _pessoaBO;

        public PessoaController(PessoaView view)
        {
            _view = view;
            _pessoaBO = new PessoaBO();

            // Vincular eventos da View aos métodos do Controller
            _view.btnSalvar.Click += OnSalvarClick;
        }

        private void OnSalvarClick(object sender, EventArgs e)
        {
            string nome = _view.txtNomePessoa.Text;
            string senha = string.Empty;

            // Cria o Model com os dados da View
            Pessoa pessoa = new Pessoa(nome, senha);

            // Chama o método de negócio para adicionar a pessoa
            var idPessoa = _pessoaBO.AdicionarPessoa(pessoa);

            if (idPessoa > 0)
            {
                MessageBox.Show(@"\Pessoa adicionada com sucesso.\");                                
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Pessoa não inserida");
            }

        }

        private void AtualizarLista()
        {
            //_view.ListPessoas.Items.Clear();

            var pessoas = _pessoaBO.ObterPessoas();

            //foreach (var pessoa in pessoas)
            //{
            //    _view.ListPessoas.Items.Add($"{pessoa.Nome} - {pessoa.Idade} anos");
            //}
        }

    }
}
