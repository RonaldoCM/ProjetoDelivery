using View.Formularios;
using BusinessObjects;
using Model;
using System.Windows.Forms;

namespace View.Controllers
{
    public class LogInController
    {
        private readonly LogInView _view;
        private readonly PessoaBO _pessoaBO;

        public LogInController(LogInView view)
        {
            _view = view;
            _pessoaBO = new PessoaBO();

            // Vincular eventos da View aos métodos do Controller
            _view.btnLogIn.Click += OnLogInClick;
        }

        private void OnLogInClick(object sender, EventArgs e)
        {
            string nome = _view.txtUsuario.Text;
            string senha = _view.txtSenha.Text;

            // Cria o Model com os dados da View
            Pessoa pessoa = new Pessoa(nome, senha);

            // Chama o método de negócio para validar a pessoa
            bool resultado = _pessoaBO.ValidarPessoa(pessoa);

            if (resultado) 
            {
                //Cria uma instância do form
                MenuView menu = new MenuView();
                
                // Cria o Controller e vincula à View
                MenuController controller = new MenuController(menu);

                // Define o próximo formulário como o principal e fecha o formulário de login
                _view.Hide(); // Esconde o formulário de login temporariamente
                menu.Show();  // Abre o formulário principal

                menu.FormClosed += (s, args) => _view.Close(); // Garante que o login seja fechado ao fechar o Menu

            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
